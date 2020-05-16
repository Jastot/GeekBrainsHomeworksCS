using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    partial class HW5
    {
        /*3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. 
         * Регистр можно не учитывать:
        а) с использованием методов C#;
        б) *разработав собственный алгоритм.
        Например:
        badc являются перестановкой abcd.*/
        public static void Polimorf()
        {
            string str1 = "abcd";
            string str2 = "badc";
            string str3 = "fdsa";
            CompareThisTwoStr(str1, str2);
            CompareThisTwoStr(str2, str3);
            OwnCompareThisTwoStr(str1,str2);
            OwnCompareThisTwoStr(str2, str3);
        }

        public static void CompareThisTwoStr(string str1, string str2)
        {
            string str1start = str1;
            string str2start = str2;
            //логично будет выстроить по алфавиту и сравнить, раз у нас abcd & badc равны.
            str1 = new string(str1.OrderBy(ch => ch).ToArray());
            str2 = new string(str2.OrderBy(ch => ch).ToArray());
            if (str1.CompareTo(str2) == 0) Console.WriteLine("Строка ("+ str1start + ") и ("+ str2start + ") являются перестановкой друг друга");
            else Console.WriteLine("Строка (" + str1start + ") и (" + str2start + ") не являются перестановкой друг друга");
        }
        public static void OwnCompareThisTwoStr(string str1, string str2)
        {
            List<string> listStr = new List<string>();

            List<string> listStr2 = new List<string>();

            for (int i = 0; i < str1.Length; i++)
            {
                listStr.Add(Convert.ToString(str1[i]));
                listStr2.Add(Convert.ToString(str2[i]));
            }
            int itsTrue = 0;
            for (int i = 0; i < listStr.Count; i++)
            {
                for (int j = 0; j < listStr2.Count; j++)
                {
                    if (listStr[i] == listStr2[j])
                    {
                        itsTrue++;
                    }
                }
            }
            if (itsTrue == listStr.Count)
            {
                Console.WriteLine("Строка (" + str1 + ") и (" + str2 + ") являются перестановкой друг друга");
            }
            else Console.WriteLine("Строка (" + str1 + ") и (" + str2 + ") не являются перестановкой друг друга");
        }
    }
}
