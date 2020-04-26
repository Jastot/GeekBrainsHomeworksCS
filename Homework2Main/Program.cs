using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    class Program
    {
        //Нашаманил. 
        //вроде все работает верно. только час-полтора убил на проверку кода,а на сам код минут 50...
        //Чудаков Г.А.
        static int Menu()
        {
            int m;
            do
            {
                Console.WriteLine("1 - Minimum");
                Console.WriteLine("2 - SumOfFigure");
                Console.WriteLine("3 - WhileNotZero");
                Console.WriteLine("4 - LogPass");
                Console.WriteLine("5 - IMT");
                Console.WriteLine("6 - GoodNumber");
                Console.WriteLine("7 - Recursion");
                Console.WriteLine("0 - Exit");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 0 && m > 3);
            return m;
        }


        static void Main(string[] args)
        {
            int a, b, c;
            int figure;
            double rost, ves;
            int menu;
            do
            {
                menu = Menu();
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Введите первое число ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите второе число ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите третье число ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Homework2.Minimum(a,b,c);
                        break;
                    case 2:
                        Console.WriteLine("Введите большое число ");
                        figure = Convert.ToInt32(Console.ReadLine());
                        Homework2.SumOfFigure(figure);
                        break;
                    case 3:
                        Homework2.WhileNotZero();
                        break;
                    case 4:
                        Homework2.LogPass();
                        break;
                    case 5:
                        Console.WriteLine("Введите рост ");
                        rost = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите вес ");
                        ves = Convert.ToDouble(Console.ReadLine());
                        Homework2.IMT(rost,ves);
                        break;
                    case 6:
                        DateTime dt = DateTime.Now;
                        Console.WriteLine(dt);
                        Homework2.GoodNumber();
                        DateTime dt2 = DateTime.Now;
                        TimeSpan timeSpan = dt2 - dt;
                        Console.WriteLine("Вот столько секунд это заняло "+timeSpan.TotalSeconds);
                        break;
                    case 7:
                        Homework2.Recursion();
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
