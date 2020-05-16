using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Homework5
{
    partial class HW5
    {
        /*1. Создать программу, которая будет проверять корректность ввода логина. 
         * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
         * при этом цифра не может быть первой:
        а) без использования регулярных выражений;
        б) с использованием регулярных выражений.
             */

        public static void LogPass()
        {
            //a
            Console.WriteLine("Введите логин");
            string login1 = Console.ReadLine();
            for (int i = 0; i < login1.Length; i++)
            {
                if (i == 0) if ((login1[0] == '0')|| (login1[0] == '1') || (login1[0] == '2') 
                        || (login1[0] == '3') || (login1[0] == '4') 
                        || (login1[0] == '5') || (login1[0] == '6') || (login1[0] == '7') || (login1[0] == '8')
                        || (login1[0] == '9')) Console.WriteLine("Логин не подходит(Первая цифра)");
                if ((i < 2) || (i > 10)) Console.WriteLine("Логин не подходит(Длинна от 2 до 10 не соблюдена)"); 
            }
            
            //b
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Regex regEx = new Regex(@"\D.\w{1,9}", RegexOptions.IgnoreCase);
            MatchCollection matches = regEx.Matches(login);
            if (matches.Count==1)
            {
                Console.WriteLine("Логин подходит");
            }
            else
            {
                Console.WriteLine("Логин не подходит");
            }

        }
    }
}
