using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWithPrintAndPause
{
    public class PrintAndPause
    {

         /**Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
          
         Чудаков Г.А.    
         */
        static void PrintInCenter(string info, int length)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - length / 2, Console.WindowHeight / 2);
            Console.WriteLine(info);
            Console.ReadKey();
        }
        public static void Pause()
        {
            Console.ReadKey();
        }
        public static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
