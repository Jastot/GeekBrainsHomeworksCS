using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //3. С клавиатуры вводятся числа, пока не будет введен 0. 
        //  Подсчитать сумму всех нечетных положительных чисел.
        //  Чудаков Г.А.
        public static void WhileNotZero()
        {
            double c=-1;
            double count = 0;
            while (c != 0)
            {
                Console.WriteLine("Введите цифру ");
                c = Convert.ToInt32(Console.ReadLine());
                if(c % 2 != 0)
                {
                    count += c;
                }
            }
            
            Console.WriteLine("Result: "+count);
        }
        
    }
}
