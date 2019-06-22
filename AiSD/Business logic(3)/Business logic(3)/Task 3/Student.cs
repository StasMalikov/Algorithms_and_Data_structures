using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Business_logic_3_
{
    [Serializable]
    public class Student
    {
        public string FIO { get; set; }
        public DateTime Year { get; set; }
        public double[] Medb { get; set; }
        public byte Kurs { get; set; }
        public byte Group { get; set; }
    }
}

