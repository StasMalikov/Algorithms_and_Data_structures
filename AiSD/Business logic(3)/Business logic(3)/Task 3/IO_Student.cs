using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Business_logic_3_;

namespace Business_logic_3_
{
    public class IO_Student
    {
        public List<Student> List_Sudent { get; set; }
        public string FileName { get; set; }
        public  IO_Student(string fileName)
        {
            FileName = fileName;
            List_Sudent = new List<Student>();
        }

        public void Write(List<Student> s)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(f, s);
            }
        }
        public void Read()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                List<Student> deserilizeStd = (List<Student>)formatter.Deserialize(f);
                foreach (Student s in deserilizeStd)
                {
                    List_Sudent.Add(s);
                }
            }
        }
    }

}
