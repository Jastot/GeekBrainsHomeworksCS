using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obmen
{
    class Program
    {

        /*
        Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
        б) *без использования третьей переменной.  

        Чудаков Г.А.
        */


        static void Main(string[] args)
        {
            #region triperem
            int a = 0;
            int b = 1;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a: " + a + "b: " + b);
            Console.ReadKey();
            #endregion
            #region dveperem
            int d = 0;
            int f = 1;
            d = d + f;
            f = d - f;
            d = d - f;

            Console.WriteLine("f: " + f + "d: " + d);
            Console.ReadKey();

            #endregion

        }
    }
}
