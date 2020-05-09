using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace Homework4
{
    partial class HW4
    {
        /*3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
         * Создайте структуру Account, содержащую Login и Password.*/
        struct Account
        {
            //private string login, pass;
            private string[] bank;
            /*public Account(string l, string p)
            {
               // this.login = l;
               // this.pass = p;
                this.bank = new string[2];
                this.bank[0] = l;
                this.bank[1] = p;
            }*/
         
            public Account(string l, string p)
            {
                bank = new string[2];
                this.bank[0] = l;
                this.bank[1] = p;
            }

            public void TryingToPass()
            {
                int yourtry = 1;
                string log;
                string pass;
                do
                {
                    Console.WriteLine("Введите Login ");
                    log = Console.ReadLine();
                    Console.WriteLine("Введите Password ");
                    pass = Console.ReadLine();
                    if (bank[0] == log && bank[1] == pass)
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
        
        public static void LogPass()
        {
            string[] mass;
            StreamReader sr;
            string f = "D:\\1.txt";
            sr = new StreamReader(f);
            string s;
            mass = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    s = sr.ReadLine();
                    mass[i] = s;
                }
            sr.Close();
            Account newAc = new Account(mass[0],mass[1]);
            Account newAc2 = new Account(mass[2], mass[3]);
            Console.WriteLine(mass[0] + " " + mass[1]);
            Console.WriteLine(mass[2] + " " + mass[3]);
            newAc.TryingToPass();
            newAc2.TryingToPass();
        }
    }
}
