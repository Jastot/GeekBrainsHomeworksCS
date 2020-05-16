using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    partial class HW4
    {
        /*4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)
             *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
              Дополнительные задачи
              в) Обработать возможные исключительные ситуации при работе с файлами.

            Чудаков Г.А.
        */
        class TwoArrays
        {
            int[,] a;
            int Max;
            public int this[int index,int index2]
            {
                get
                {
                    return a[index,index2];
                }
            }
            public TwoArrays(int l, int l2)
            {
                a = new int[l,l2];
                
            }
            public TwoArrays(int l,int l2, int min, int max) : this(l,l2)
            {
                Max = max;
                Random random = new Random();
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i,j] = random.Next(min, max + 1);
                    }
                    
                }
            }
            public void WriteToFile(string filename)
            {
                StreamWriter sw;
                List<string> list = new List<string>();
                sw = new StreamWriter(filename);
                int c = 0;
                for(int i = 0;i< a.GetLength(0);i++)
                {
                    string str = "";
                    for (int j = 0; j< a.GetLength(1); j++)
                    { 
                        str+=Convert.ToString(a[i, j])+" ";
                    }
                    list.Add(str);
                    c++;
                }
                for(int i=0;i<c;i++)
                sw.WriteLine(list[i]);
                sw.Close();
            }
            StreamReader sr;
            public TwoArrays(string f)
            {
                List<int[]> listForSplitLines = new List<int[]>();
                if (File.Exists(f) == false)
                {
                    a = new int[10,10];
                    return;
                }
                int i = 0;
                int j = 0;
                try
                {
                    sr = new StreamReader(f);
                    string s;
                   
                    double count = 0;
                    while (sr.EndOfStream == false)
                    {
                        s = sr.ReadLine();
                        count++;
                        Console.Write(count+"    ");
                        Console.Write(s+" ");
                        Console.WriteLine(sr.EndOfStream);
                    }
                    Console.WriteLine("Посчитал");
                    sr.Close();
                    sr = new StreamReader(f);
                    for (int y = 0; y < count; y++)
                    {
                        s = sr.ReadLine();
                        listForSplitLines.Add(System.Array.ConvertAll(s.Trim(' ').Split(' '), int.Parse));
                    }
                    int maxL = 0;
                    for (int y = 0; y < listForSplitLines.Count; y++) if (maxL < listForSplitLines[i].Length) maxL = listForSplitLines[i].Length;
                    a = new int[listForSplitLines.Count,maxL];
                    for (i = 0; i < a.GetLength(0); i++)
                    {
                        for (j = 0; j < a.GetLength(1); j++)
                        {
                            int counter = listForSplitLines[i].Length;
                            if ((j < maxL) && (j >= counter))
                            {
                                a[i, j] = 0;
                            }
                            else a[i, j] = listForSplitLines[i][j];
                            Console.Write(a[i, j]+ " ");
                        }
                        Console.WriteLine();

                    }
                    /*sr = new StreamReader(f);
                    Console.WriteLine("Посчитал");
                    Math.Sqrt(count);
                    int l1;
                    int l2;
                    
                    if (count%(count/2) != 0) ;
                    else ;
                    a = new int[l,l2];
                    for (i = 0; i < a.GetLength(0); i++)
                    {
                        for (j = 0; j < a.GetLength(1); j++)
                        {
                            s = sr.ReadLine();
                            a[i,j] = Convert.ToInt32(s);
                            Console.WriteLine(a[i, j]);
                        }
                        
                    }
                    sr.Close();*/
                }
                catch (FormatException)
                {
                    a[i,j] = 0;
                }
                catch (Exception exc)
                {
                    a = new int[10,10];
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    sr?.Close();
                }

            }
            public override string ToString()
            {
                string s = "";
                /* for (int i = 0; i < a.Length; i++)
                 {
                     s = s + a[i].ToString() + " ";
                 }*/
                foreach (int elem in a)
                {
                    s = s + elem.ToString() + " ";
                }
                return s;
            }

            public int SumEven(int C)
            {
                int Count = 0;
                int sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum += a[i, j];
                    }

                }
                return Count;
            }
            public void Delete()
            {
                a = null;
            }
            public void Multi(int m)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] *= m;
                    }
                }
                Console.WriteLine("Домножили на "+m);
            }
            public void Inverse()
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] *= -1;
                    }
                   
                }
                Console.WriteLine("ПРОИЗОШЛА ИНВЕРСИЯ");
            }
            public void Sum()
            {
                int sum = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        sum += a[i, j];
                    }

                }
                Console.WriteLine("Сумма всех элементов " + sum);
            }
            public void PrintArray()
            {
             
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i,j]+" ");
                    }
                    Console.WriteLine();
                }
               
                Console.WriteLine();
            }
            public void MaxCount()
            {
                int Count = 0;
                
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i,j] > Max)
                        {
                            Max = a[i,j];
                            Count = 0;
                        }
                        if (a[i,j] == Max)
                        {
                            Count++;
                        }
                    }
                    
                }
                Console.WriteLine("Количество максимальных элементов " + Count);
                Console.WriteLine("Максимальный элемент " + Max);
            }
        }
        public static void TwoArraysFull()
        {
            string filename = "D:\\1.txt";
            TwoArrays own = new TwoArrays(10, 10, 1, 10);
            //TwoArrays own = new TwoArrays(filename); 
            own.Sum();
            own.MaxCount();
            own.PrintArray();

            own.Multi(10);
            own.PrintArray();
            own.Inverse();
            own.PrintArray();
            own.Inverse();
            own.WriteToFile(filename);


            Console.ReadLine();
        }

    }
}
