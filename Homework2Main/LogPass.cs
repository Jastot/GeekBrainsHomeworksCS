using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Main
{
    partial class Homework2
    {
        //4. Реализовать метод проверки логина и пароля. 
        //  На вход подается логин и пароль. 
        //  На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //  Используя метод проверки логина и пароля, написать программу: 
        //  пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        //  С помощью цикла do while ограничить ввод пароля тремя попытками.
        //  Чудаков Г.А.
        public static void LogPass()
        {
            int yourtry = 1;
            string TrueLog = "root", TruePass = "GeekBrains";
        
            string log;
            string pass;
            do
            {
                Console.WriteLine("Введите Login ");
                log = Console.ReadLine();
                Console.WriteLine("Введите Password ");
                pass = Console.ReadLine();
                if (TrueLog == log && TruePass == pass)
                {
                    Console.WriteLine("True");
                    yourtry = 5;
                }
                else
                {
                    Console.WriteLine("False");
                    yourtry++;
                }
            }
            while (yourtry <= 3);
        }

    }
}
