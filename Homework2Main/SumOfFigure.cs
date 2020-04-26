using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //  2. Написать метод подсчета количества цифр числа.
        //  Чудаков Г.А.
        public static void SumOfFigure(int figure)
        {
            int count = 0;
            while(figure >= 0)
            {
                if (figure == 0)
                {
                    figure--;
                }
                else
                { 
                    figure /= 10;
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
        }
        
    }
}
