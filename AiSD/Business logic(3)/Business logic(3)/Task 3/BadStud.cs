using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
   public class BadStud
    {
        public List<Student> FullList { get; set; }
        public BadStud(List<Student> fullList)
        {
            FullList = fullList;
        }

        /* Вывести список студентов на отчисление (4 и более отрицательных оценки)*/
        public List<Student> GetBadStudList()
        {
            return FullList.Where(x =>x.Kurs>1 && x.Medb.Where(y => y < 3).Count() >= 3).ToList();
        }
    }
}
