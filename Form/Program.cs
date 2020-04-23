using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Form
{
    class Program
    {
     /*
     Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
     В результате вся информация выводится в одну строчку:
     a) используя  склеивание;
     b) используя форматированный вывод;
     c) используя вывод со знаком $.

     Чудаков Г.А.
     */
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            #region a
            Console.WriteLine("Меня зовут "+ surname + " " + name + " мне " + age + "лет, мой рост " + height + " и мой вес " + weight);
            #endregion
            #region b
            Console.WriteLine("Меня зовут {0:F2} {1:F2} мне {2:F2} лет, мой рост {3:F2} и мой вес {4:F2}", surname, name, age, height, weight);
            #endregion
            #region c
            Console.WriteLine($"Меня зовут {surname:F2} {name:F2} мне {age:F2} лет, мой рост {height:F2} и мой вес {weight:F2}");
            #endregion
            Helpfull.Pause();

        }
    }
}
