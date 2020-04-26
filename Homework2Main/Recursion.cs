using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {

        //  7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        //    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        //    Чудаков Г.А.

        static void RecADoB(int a, int b)
        {
            for(int i=a; i <= b; i++) Console.WriteLine(i);
        }
        static void SumADoB(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++) sum += i;   
            Console.WriteLine("Сумма от а до б: "+sum);
        }
        public static void Recursion()
        {
            int a, b; 
            Console.WriteLine("Введите не равные числа ");
            Console.WriteLine("Введите первое число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a<b)
            {
                Console.WriteLine("Все числа от а до б ");
                RecADoB(a, b);
                SumADoB(a, b);
            }
            else 
            {
                Console.WriteLine("Все числа от а до б ");
                RecADoB(b, a);
                SumADoB(b, a);
            }
        }
    }
}
