using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    

    class Program
    {

        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - Time");
                Console.WriteLine("2 - TryParse");
                Console.WriteLine("3 - Decimal");

                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 3);
            return m;
        }

        static void Main(string[] args)
        {
            int menu;
            do
            {
                menu = Menu();
                switch (menu)
                {
                    case 1:
                        HW3.Time();
                        break;
                    case 2:
                        HW3.tryParse();
                        break;
                    case 3:
                        HW3.Decimal();
                        break;
                    default:
                        Console.WriteLine("Такого пункта нет в меню!");
                        break;
                }
            }
            while (menu != 0);
        }
    }
}
