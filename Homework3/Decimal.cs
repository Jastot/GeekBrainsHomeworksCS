using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    partial class HW3
    {
        /* 3. 
          * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел. 
          * Done
          * 
          * Предусмотреть методы сложения, вычитания, умножения и деления дробей.  
          * Done
          * 
          * Написать программу, демонстрирующую все разработанные элементы класса. 
          * 
          * Done
          **Добавить проверку, чтобы знаменатель не равнялся 0.
          * Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
          * Done
          * 
          * Добавить упрощение дробей.
          * Done
          * 
                Чудаков Г.А.
        */
        struct DecimalClass
        {
            private int up, down;
            public DecimalClass(int up, int down)
            {
                this.up = up;
                this.down = down;
            }
            public void SetUp(int v)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (v == 0) throw new ArgumentOutOfRangeException("0 не дробное число!!!");
                Console.ForegroundColor = ConsoleColor.White;
                up = v;
            }

            public void SetDown(int v)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (v == 0) throw new ArgumentOutOfRangeException("Куда 0 в знаменатель пихаешь!!!");
                Console.ForegroundColor = ConsoleColor.White;
                down = v;
                if (down == up)
                {
                    up /= up;
                    down /= down;
                }
            }
            public DecimalClass Summation(DecimalClass other)
            {
                DecimalClass newOne = new DecimalClass(up * other.down + other.up * down , down * other.down);
                return newOne;
            }
            public DecimalClass Subtraction(DecimalClass other)
            { 
                DecimalClass newOne = new DecimalClass(up * other.down - other.up * down, down * other.down);
                return newOne;
            }
            public DecimalClass Мultiplication(DecimalClass other)
            {
                DecimalClass newOne = new DecimalClass(up * other.up, down * other.down);
                return newOne;
            }
            public DecimalClass Division(DecimalClass other)
            {
                DecimalClass newOne = new DecimalClass(up *  other.down , down * other.up);
                return newOne;
            }
            public DecimalClass Prosto()
            {
                 int stack;
                 if(up>down)
                 {
                    stack = up;
                 }
                 else
                 {
                    stack = down;

                 }
                 int i = 1;
                 while(i<stack)
                 {
                    if(up%i==0 && down%i==0)
                    {
                       up /= i;
                       down /= i;
                       i = 1;
                    }
                    i++;
                 }
            DecimalClass newOne = new DecimalClass(up, down);
            return newOne;
            }
            public double GetUp()
            {
                return up;
            }
            public double GetDown()
            {
                return down;
            }

        }
        public static void Decimal()
        {
            DecimalClass FirstOne = new DecimalClass();
            FirstOne.SetUp(15);
            FirstOne.SetDown(18);
            DecimalClass SecondOne = new DecimalClass();
            SecondOne.SetUp(2);
            SecondOne.SetDown(5);
            Console.WriteLine("Сложение 2ух дробных чисел = "+ FirstOne.Summation(SecondOne).Prosto().GetUp() +
                "/" + FirstOne.Summation(SecondOne).Prosto().GetDown() + "\n");
            Console.WriteLine("Вычитание 2ух дробных чисел = " + FirstOne.Subtraction(SecondOne).Prosto().GetUp() +
                "/" + FirstOne.Subtraction(SecondOne).Prosto().GetDown() + "\n");
            Console.WriteLine("Перемножение 2ух дробных чисел = " + FirstOne.Мultiplication(SecondOne).Prosto().GetUp() +
                "/" + FirstOne.Мultiplication(SecondOne).Prosto().GetDown() + "\n");
            Console.WriteLine("Деление 2ух дробных чисел = " + FirstOne.Division(SecondOne).Prosto().GetUp() +
                "/" + FirstOne.Division(SecondOne).Prosto().GetDown() + "\n");
            Console.WriteLine("Вот это сейчас упростим: " + FirstOne.GetUp() +"/"+FirstOne.GetDown()+ "\n");
            Console.WriteLine("Упрощаю: " + FirstOne.Prosto().GetUp() + "/" + FirstOne.Prosto().GetDown() + "\n");
        }
    }
}
