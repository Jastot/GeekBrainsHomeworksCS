using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //5. а) Написать программу, которая запрашивает массу и рост человека, 
        //   вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //   б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        //   Чудаков Г.А.

        public static void IMT(double rost, double ves)
        {
            rost /= 100;
            double imt =ves / Math.Pow(rost,2), how;
            
            if(imt >= 18.5)
            {
                if (imt >= 25.1)
                {
                    if (imt >= 30.0)
                    {
                        if (imt >= 34.6)
                        {
                            if (imt >= 40.0)
                            {
                                how = 25.0 * Math.Pow(rost, 2);
                                how = ves - how;
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Ожирение 3ой степени, нужно сбросить "+ how+ " кг ");
                            }
                            else
                            {
                                how = 25.0 * Math.Pow(rost, 2);
                                how = ves - how;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ожирение 2ой степени, нужно сбросить " + how + " кг ");
                            }
                        }
                        else
                        {
                            how = 25.0 * Math.Pow(rost, 2);
                            how = ves - how;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Ожирение 1ой степени, нужно сбросить " + how + " кг ");
                        }
                    }
                    else
                    {
                        how = 25 * Math.Pow(rost, 2);
                        how = ves - how;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Жир уже в пути, нужно сбросить " + how + " кг ");
                    }
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Все в норме");
                }
            }
            else
            {
                how = 18.5 * Math.Pow(rost, 2);
                how -= ves;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("СРОЧНО ЗАГРУЗИТЬ В СЕБЯ БУЛКУ ВЕСОМ " + how + " кг ");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
