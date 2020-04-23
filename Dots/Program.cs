using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Dots
{
    class Program
    {
        /*    
        а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        Чудаков Г.А.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            // здесь представлено решения под пункто а
            /*double formula = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));*/
            Console.WriteLine("Результат {0:F2} ", formula(x1,y1,x2,y2));

            Helpfull.Pause();
        }

        static double formula(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


    }
}
