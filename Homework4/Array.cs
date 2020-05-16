using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace Homework4
{
    partial class HW4
    {
        /*2. а) Дописать класс для работы с одномерным массивом. 
         * Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
         * Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse,
         * меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на определенное число,
         * свойство MaxCount, возвращающее количество максимальных элементов. 
         * В Main продемонстрировать работу класса.
         б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
         Чудаков Г.А.
             */

        class OwnArray
        {
            int[] a;
            int Max;
            //индексатор - специальное свойство
            public int this[int index]
            {
                get
                {
                    return a[index];
                }
            }



            public OwnArray(int l)
            {
                a = new int[l];
            }
            public OwnArray(int l, int min, int max) : this(l)
            {
                Max = max;
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(min, max + 1);
                }
            }
            public void WriteToFile(string filename)
            {
                StreamWriter sw;
                sw = new StreamWriter(filename);

                foreach (int elem in a)
                {
                    sw.WriteLine(elem.ToString());
                }
                sw.Close();
            }
            StreamReader sr;
            public OwnArray(string f)
            {

                if (File.Exists(f) == false)
                {
                    a = new int[10];
                    return;
                }
                int i = 0;
                try
                {
                    sr = new StreamReader(f);
                    string s = sr.ReadLine();
                    int l = int.Parse(s);
                    a = new int[l];
                    for (i = 0; i < l; i++)
                    {
                        s = sr.ReadLine();
                        a[i] = int.Parse(s);
                    }
                    sr.Close();
                }
                catch (FormatException)
                {
                    a[i] = 0;
                }
                catch (Exception exc)
                {
                    a = new int[10];
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    //if(sr!=null)
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

            public int SumEven()
            {
                int s = 0;
                foreach (int elem in a)
                {
                    if (elem % 2 == 0) s = s + elem;
                }
                return s;
            }
            public void Delete()
            {
                a = null;
            }
            public void Multi(int m)
            {
                for(int i = 0; i< a.Length;i++)
                {
                    a[i] *= m;
                }
            }
            public void Inverse()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] *= -1;
                }
            }
            public int Sum()
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum+=a[i];
                }
                return sum;
            }
            public void PrintArray()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i]+" ");
                }
                Console.WriteLine();
            }
            public int MaxCount()
            {
                int Count = 0;
                //int max = 0; // только для данного примера
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > Max)
                    {
                        Max = a[i];
                        Count = 0;
                    }
                    if (a[i] == Max)
                    {
                        Count++;
                    }
                }

                return Count;
            }
        }
        public static void Array()
        {
            //string filename = "D:\\1.txt";
            OwnArray own = new OwnArray(10,1,10);
            //OwnArray own = new OwnArray(filename);
            Console.WriteLine(own.Sum());
            Console.WriteLine(own.MaxCount());
            own.PrintArray();
            own.Multi(10);
            own.PrintArray();
            own.Inverse();
            own.PrintArray(); 
            own.Inverse();
            own.WriteToFile("D:\\1.txt");
            //Console.WriteLine(own[0]);
            //Console.WriteLine(own);
            
            Console.ReadLine();
        }
        
    }
}
