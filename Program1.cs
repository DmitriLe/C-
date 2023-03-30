using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace first1
{
    class first11
    {
        public void main()
        {
            int schet = 0, number = 0, schetOshibok = 0, num = 0, schetPer = 0, per228 = 0, summa1 = 0, num1 = 0, number1 = 0, cen1, num2;
            bool zad3 = true;
            string prod, cen, num8;
            int min12 = 0, iii = 0; ;
            int[,] array23 = new int[5, 6];
            int[] arrayfin = new int[5];

            while (schetPer == 0)
            {
                Console.WriteLine("Введите количество элементов массива(не менее 15):\n");
                string kolvo = Console.ReadLine();
                if (int.TryParse(kolvo, out per228))
                {
                    if (per228 >= 15)
                    {
                        schetPer++;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверное значение!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверные значения!\n");
                }
            }

            int[] array1 = new int[per228];

            Console.WriteLine("Введите элементы массива:\n");

            for (int i = 0; i < per228; i++)
            {
                string elem = Console.ReadLine();
                if (int.TryParse(elem, out array1[i]))
                {
                    if (array1[i] > 0)
                    {
                        summa1 += array1[i];
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели неверное значение! Повторите ввод:\n");
                    i--;
                }
            }

            Console.WriteLine($"Сумма всех положительных элементов равна: {summa1}");




        }
    }
}