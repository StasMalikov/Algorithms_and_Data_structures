using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_logic_3_
{
   public class Random_Student
    {
        public static List<Student> RandomStd(int num)
        {
            List<Student> Randomlist= new List<Student>();
            List<Student> Datalist = new List<Student>();
            Student s0 = new Student { FIO = "Мухин Самуил Рудольфович", Year = DateTime.Parse("1.07.1999"), Medb = new double[4] { 2.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 1 };
            Student s1 = new Student { FIO = "Овчинников Иннокентий Кириллович", Year = DateTime.Parse("2.08.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 2 };
            Student s2 = new Student { FIO = "Киселёв Артем Вадимович", Year = DateTime.Parse("28.04.1996"), Medb = new double[6] { 2, 4.2, 2.5, 4, 2.9, 3.8 }, Kurs = 3, Group = 2 };
            Student s3 = new Student { FIO = "Логинов Афанасий Максимович", Year = DateTime.Parse("15.02.1998"), Medb = new double[6] { 4, 4.2, 4.1, 4, 4, 4 }, Kurs = 3, Group = 4 };
            Student s4 = new Student { FIO = "Борисов Борис Бориславович", Year = DateTime.Parse("02.04.2000"), Medb = new double[2] { 4.4, 4.2 }, Kurs = 1, Group = 3 };
            Student s5 = new Student { FIO = "Карасев Виктор Михайлович", Year = DateTime.Parse("09.08.1997"), Medb = new double[8] { 3.2, 4.2, 4.1, 4, 4, 4, 4.3, 4.3 }, Kurs = 4, Group = 1 };
            Student s6 = new Student { FIO = "Чернышов Алексей Викторович", Year = DateTime.Parse("03.03.1999"), Medb = new double[2] { 5, 4.2 }, Kurs = 1, Group = 2 };
            Student s7 = new Student { FIO = "Греков Андрей Валерьевич", Year = DateTime.Parse("05.11.1998"), Medb = new double[6] { 4.5, 2.8, 2.2, 2, 3.8, 4 }, Kurs = 3, Group = 3 };
            Student s8 = new Student { FIO = "Серпухов Павел Алексеевич", Year = DateTime.Parse("12.12.1996"), Medb = new double[8] { 4.1, 4.2, 4.1, 3.9, 3.8, 3.7, 4, 3.8}, Kurs = 4, Group = 2 };
            Student s9 = new Student { FIO = "Керинский Илья Петрович", Year = DateTime.Parse("26.07.1997"), Medb = new double[8] { 4.3, 4.2, 4.1, 3.8, 4, 4.6, 4.5, 4.4 }, Kurs = 4, Group = 4 };
            Student s10 = new Student { FIO = "Быков Богдан Антонович", Year = DateTime.Parse("12.08.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4.1 }, Kurs = 2, Group = 1 };
            Student s11 = new Student { FIO = "Семенов Петр Анатольевич", Year = DateTime.Parse("14.07.1999"), Medb = new double[4] { 4.3,1.8, 2, 2.8 }, Kurs = 2, Group = 1 };
            Student s12 = new Student { FIO = "Осипов Харитон Всеволодович", Year = DateTime.Parse("23.04.1999"), Medb = new double[4] { 4.3, 4.2, 4.1, 4 }, Kurs = 2, Group = 2 };
            Student s13 = new Student { FIO = "Белова Анна Валерьевна", Year = DateTime.Parse("27.01.2000"), Medb = new double[8] { 4.1, 4.2, 4, 4, 4, 3.8, 3.7, 3.7 }, Kurs = 4, Group = 2 };
            Student s14 = new Student { FIO = "Серов Андрей Сергеевич", Year = DateTime.Parse("15.05.1998"), Medb = new double[6] { 4, 4.2, 4.1, 4, 4, 4 }, Kurs = 3, Group = 4 };
            Student s15 = new Student { FIO = "Конев Владимир Павлович", Year = DateTime.Parse("02.09.2000"), Medb = new double[2] { 4.4, 4 }, Kurs = 1, Group = 3 };
            Student s16 = new Student { FIO = "Антонов Виктор Антонович", Year = DateTime.Parse("02.05.1996"), Medb = new double[8] { 4.2, 2.3, 4.1, 2.1, 2.2, 4, 4.3, 4.3 }, Kurs = 4, Group = 1 };
            Student s17 = new Student { FIO = "Горбунов Сергей Анатольевич", Year = DateTime.Parse("03.03.2000"), Medb = new double[2] { 5, 4.2 }, Kurs = 1, Group = 2 };
            Student s18 = new Student { FIO = "Шаев Илья Олегович", Year = DateTime.Parse("05.11.1997"), Medb = new double[6] { 4.5, 4.2, 4.1, 4, 4, 3.6 }, Kurs = 3, Group = 3 };
            Student s19 = new Student { FIO = "Мелехов Юрий Владиславович ", Year = DateTime.Parse("12.12.1995"), Medb = new double[8] { 4.1, 4, 4.1, 3.9, 3.8, 3.7, 4, 3.8 }, Kurs = 4, Group = 2 };
            Datalist.Add(s0); Datalist.Add(s1);Datalist.Add(s2);
            Datalist.Add(s3); Datalist.Add(s4); Datalist.Add(s5); Datalist.Add(s6);
            Datalist.Add(s7); Datalist.Add(s8); Datalist.Add(s9); Datalist.Add(s10);
            Datalist.Add(s11); Datalist.Add(s12); Datalist.Add(s13);
            Datalist.Add(s14); Datalist.Add(s15); Datalist.Add(s16);
            Datalist.Add(s17);Datalist.Add(s18); Datalist.Add(s19);
            Random rnd = new Random();
            for (int i = 0; i <num; i++)
            {
                Randomlist.Add(Datalist[rnd.Next(0, 19)]);
            }
            return Randomlist;
        }
    }
}
