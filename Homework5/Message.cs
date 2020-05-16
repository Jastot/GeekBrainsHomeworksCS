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
        /*
         * 2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения, которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            Продемонстрируйте работу программы на текстовом файле с вашей программой.
        */
        class Message
        {
            public static StringBuilder CreationMessage()
            {
                StringBuilder str = new StringBuilder();
                StreamReader sr = new StreamReader("dataM.txt");
                string a;
                while ((a=sr.ReadLine())!=null)
                {
                    str.Append(a+"\n");
                }
                return str;
            }
            public static void A(string str,int n)
            {
                Regex regEx = new Regex($"\\b\\w{{1,{n}}}\\b");
                /*
                  Использую функцию Matches выше созданного регулярного выражения
                  которая ищет в тексте последовательности символов 
                  удовлетворяющие шаблону поиска, 
                  и возвращает их в виде коллекции объектов типа Match 
                */
                MatchCollection matches = regEx.Matches(str); //string input, string pattern // string input
                Console.WriteLine(matches.Count);
                foreach (Match m in matches)
                {
                    Console.WriteLine("Слово {0} позиция {1} длина {2}", m.Value, m.Index, m.Length);
                }
            }
            public static void B(ref string str, char k)
            {
                Regex regEx = new Regex($"\\w+{k}\\b");
                // string replacement = null;
                str = regEx.Replace(str, string.Empty);
            }
            public static void C(string str)
            {
                Regex regEx = new Regex(@"\b\w+\b");
                MatchCollection matches = regEx.Matches(str);
                Console.WriteLine(matches.Count);
                int max = 0;
                string maxWord = "";
                foreach (Match m in matches)
                {
                    if (m.Length > max)
                    {
                        max = m.Length;
                        maxWord = m.Value;
                    }
                }
                Console.WriteLine(maxWord + " Length: " + max);




            }
            public static void D(string str)
            {
                Regex regEx = new Regex(@"\b\w+\b");
                MatchCollection matches = regEx.Matches(str);
                //Console.WriteLine(matches.Count);
                int max = 0;
                string maxWord = "";
                int indexM=0;
                int count = 0;
                StringBuilder newStr = new StringBuilder();
                
                foreach (Match m in matches)
                {
                    //Console.WriteLine(m.Index+" "+m);
                    if (m.Length >= max)
                    {
                        if (count != 0)
                        {
                            newStr.Remove(0,newStr.Length);
                            indexM = 0;
                        }
                        
                        max = m.Length;
                       // maxWord = m.Value;
                        
                        
                        if (max == m.Length)
                        {
                            if (count == 0) 
                            {
                                indexM = 0;
                                count++;
                            }
                            else
                            {
                                indexM += m.Length + 1;
                                count = 0;
                            }
                            //Console.WriteLine(indexM);
                            newStr.Append(m.Value + "\n" );
                        }
                       
                    }

                }
                Console.WriteLine(newStr);
            }
        }


        public static void Messages()
        {
            Console.WriteLine(Message.CreationMessage());
            string str = Message.CreationMessage().ToString();
            Console.WriteLine("Введите граничащее число");
            int n =Convert.ToInt32(Console.ReadLine());
            Message.A(str, n);
            Console.WriteLine("Конечный символ");
            char k = Convert.ToChar(Console.ReadLine());
            Message.B(ref str, k);
            Console.WriteLine(str);
            Message.C(str);
            Message.D(str);
        }
    }
}
