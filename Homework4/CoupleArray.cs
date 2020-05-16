using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    partial class HW4
    {
        /*1. Дан целочисленный массив из 20 элементов. 
         * Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
         * Написать программу, позволяющую найти и вывести количество пар элементов массива, 
         * в которых хотя бы одно число делится на 3. 
         * В данной задаче под парой подразумевается два подряд идущих элемента массива. 
         * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
         Чудаков Г.А.
             */

        class FullArray
        {
            int[] array;
            int Count;
            public FullArray(int l)
            {
                array = new int[l];
            }
            public void RandArray()
            {
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-10000, 10000);
                }
            }
            public void PrintArray()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Это "+i+" элемент массика и он равен: "+array[i]);
                }
            }
            public void PrintCount()
            {
                Console.WriteLine("Количество пар = "+Count);
            }
            public void FindAPair()
            {
                Count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                   if ((array[i] % 3 == 0) || (array[i+1] % 3 == 0))
                   {
                        Count++;
                   }
                }
            }
        }
        public static void CoupleArray()
        {
            int a;
            Console.WriteLine("Введите размер массива");
            a = Convert.ToInt32(Console.ReadLine());
            FullArray own = new FullArray(a);
            own.RandArray();
            own.PrintArray();
            own.FindAPair();
            own.PrintCount();
            Console.ReadLine();
        }
    }
}
