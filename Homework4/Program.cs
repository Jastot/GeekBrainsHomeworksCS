using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - CoupleArray");
                Console.WriteLine("2 - Array");
                Console.WriteLine("3 - LogPass");
                Console.WriteLine("4 - TwoArraysFull");

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
                        HW4.CoupleArray();
                        break;
                    case 2:
                        HW4.Array();
                        break;
                    case 3:
                        HW4.LogPass();
                        break;
                    case 4:
                        HW4.TwoArraysFull();
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
