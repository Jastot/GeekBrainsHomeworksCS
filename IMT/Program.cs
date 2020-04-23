using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class Program
    {
        /*Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h);
        где m — масса тела в килограммах, h — рост в метрах.

        Чудаков Г.А.
        */


        static void Main(string[] args)
        {
            Console.Write("Введите рост в формате а.аа : ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(weight/Math.Pow(height,2));


            Helpfull.Pause();
        }
    }
}
