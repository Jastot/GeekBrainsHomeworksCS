using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - LogPass");
                Console.WriteLine("2 - Messages");
                Console.WriteLine("3 - Polymorf");
                Console.WriteLine("4 - EGE");

                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 4);
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
                        HW5.LogPass();
                        break;
                    case 2:
                        HW5.Messages();
                        break;
                    case 3:
                        HW5.Polimorf();
                        break;
                    case 4:
                        HW5.EGE();
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
