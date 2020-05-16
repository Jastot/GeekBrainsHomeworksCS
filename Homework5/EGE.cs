using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace Homework5
{
    partial class HW5
    {
        /*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
        школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
        превосходит 100, каждая из следующих N строк имеет следующий формат:
        <Фамилия> <Имя> <оценки>,
        где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
        более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
        пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
        Пример входной строки:
        Иванов Петр 4 5 3
        Требуется написать как можно более эффективную программу, которая будет выводить на экран
        фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
        набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
        */
        public struct EGEList
        {
            public string FI { get; set; }
            public string marks { get; set; }
            public double SRC { get; set; }
        }
        public static EGEList[] CreationEGEList()
        {
            StreamReader sr = new StreamReader("dataEGE.txt");
            int count = int.Parse(sr.ReadLine());
            EGEList[] fullEgeList = new EGEList[count];
            for (int i = 0; i < count; i++)
            {
                string[] student = sr.ReadLine().Split();
                // Console.WriteLine(student[0], student[1], student[2], student[3], student[4]);
                fullEgeList[i].FI += student[0] + " " + student[1];
                fullEgeList[i].marks = student[2] + " " + student[3] + " " + student[4];
                fullEgeList[i].SRC = (Convert.ToDouble(student[2]) + Convert.ToDouble(student[3]) + Convert.ToDouble(student[4])) / 3;
               /* Console.WriteLine(fullEgeList[i].FI);
                Console.WriteLine(fullEgeList[i].marks);
                Console.WriteLine(fullEgeList[i].SRC);*/
            }
            return fullEgeList;
        }
        public static void EGE()
        {
            EGEList[] fullEgeList = CreationEGEList();
            FindThreeRetards(fullEgeList);
        }
       
        public static void FindThreeRetards(EGEList[] fullEgeList)
        {
            var sortedSRC = from u in fullEgeList
                              orderby u.SRC
                              select u;
            double flag = 6;
            int count = 0;
            foreach (EGEList SRCList in sortedSRC)
            {
                if (flag == SRCList.SRC) Console.WriteLine("Оболтус: " + SRCList.FI + " набрал: " + SRCList.SRC);
                if (count != 3)
                {
                    Console.WriteLine("Оболтус: "+ SRCList.FI + " набрал: " + SRCList.SRC);
                    count++;
                    flag = SRCList.SRC;
                } 
            }
        }
    }
}
