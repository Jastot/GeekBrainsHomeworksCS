using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //  1. Написать метод, возвращающий минимальное из трех чисел.
        //  Чудаков Г.А.

        public static void Minimum(int a, int b, int c)
        {

            if ((a < b) && (a < c))
            {
                Console.WriteLine("Result: " + a);
            }
            else { 
                if (b < a && b < c)
                {
                      Console.WriteLine("Result: " + b);
                }
                else Console.WriteLine("Result: " + c);
            }
        }

    }
}
