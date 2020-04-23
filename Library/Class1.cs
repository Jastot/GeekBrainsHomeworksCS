using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Helpfull
    {
        public static int Sum(int x, int y)
        {
            return x + y;
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
