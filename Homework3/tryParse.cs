using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /*2. 
    а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    Требуется подсчитать сумму всех нечетных положительных чисел. 
    Сами числа и сумму вывести на экран, используя tryParse;
    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
    При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

       Чудаков Г.А.
    */
    partial class HW3
    {
        static int c = 0;
        static bool flag;
        static int count;
        static int Odd(int x)
        {
            if (x % 2 != 0)
            {
                c += x;
                //Console.WriteLine("это с" + c);
            }
            return c;
        }
        static int Input(string m)
        {
            do
            {
                Console.WriteLine(m);
                Console.WriteLine("Для выхода введите 0");
                string line = Console.ReadLine();
                flag = Error(line);
            } while (flag == false);
            return count;
        }
        static bool Error(string line)
        {
            flag = int.TryParse(line, out count);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flag == false ? "ERR\n" : "");
            Console.ForegroundColor = ConsoleColor.White;
            return flag;
        }
        public static void tryParse()
        {
            int count;
            do
            {
                count = Input("Input a number:");
                Odd(count);
            }
            while (count != 0);
            Console.WriteLine("Сумма всех введенных нечетных положительных чисел: " + c + "\n");
        }
    }
}
