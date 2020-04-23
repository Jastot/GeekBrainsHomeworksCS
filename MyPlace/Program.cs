using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryWithPrintAndPause;


namespace MyPlace
{
    class Program
    {

        /* 
        а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        б) *Сделать задание, только вывод организовать в центре экрана.
        в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        
        Чудаков Г.А.     
        */

        static void Main(string[] args)
        {
            string info = BringInfo();
            int length = info.Length-2;
            Console.WriteLine(length);
            PrintInCenter(info, length);
        }

        static void PrintInCenter(string info,int length)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - length/2, Console.WindowHeight / 2 );
            Console.WriteLine(info);
            Console.ReadKey();
        }

        static string BringInfo()
        {
            string info;
            Console.Write("Введите имя: ");
            info = Console.ReadLine() + " ";
            Console.Write("Введите фамилию: ");
            info += Console.ReadLine() + " ";
            Console.Write("Введите город: ");
            info += Console.ReadLine();
            return info; 
        }
    }
}
