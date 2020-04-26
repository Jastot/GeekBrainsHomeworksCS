using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //  6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //  Хорошим называется число, которое делится на сумму своих цифр. 
        //  Реализовать подсчет времени выполнения программы, используя структуру DateTime.
        //  Чудаков Г.А.
        public static void GoodNumber()
        {
            Console.WriteLine("Ожидайте. Подсчет уже начат");
            int count=0;
            
            for (int i = 0;i<1E+9;i++)
            {
                if(i == 1E+9/2)
                {
                    DateTime dtForWork = DateTime.Now;
                    Console.WriteLine(dtForWork);
                    Console.WriteLine("Половина роботы выполнена, работяги пашут, не переключайтесь!");
                }
                double sup = 0;
                int c = i;
                while (c >= 0)
                {
                   
                    if (c == 0)
                    {
                        c--;
                    }
                    else
                    {
                        sup +=c % 10;
                        c /= 10;
                    }
                }
                if (i % sup == 0)
                {
                    count++;
                   
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
