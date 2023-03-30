using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace second2
{
    class second21
    {
        public void main()
        {
            int schet = 0, number = 0, schetOshibok = 0, num = 0, schetPer = 0, per228 = 0, summa1 = 0, num1 = 0, number1 = 0, cen1, num2;
            bool zad3 = true;
            string prod, cen, num8;
            int min12 = 0, iii = 0; ;
            int[,] array23 = new int[5, 6];
            int[] arrayfin = new int[5];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("mas[" + i + "," + j + "]: ");

                    string elem777 = Console.ReadLine();
                    if (int.TryParse(elem777, out iii))
                    {
                        array23[i, j] = iii;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверное значение! Повторите ввод:\n");
                        j--;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //Console.Write(" mas[" + i + "," + j + "]: " + array23[i, j] + " ");
                    Console.Write($" {array23[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ответ:\n");

            for (int i = 0; i < 5; i++)
            {
                min12 = 0;
                for (int j = 0; j < 6; j++)
                {
                    if (array23[i, j] > min12)
                    {
                        min12 = array23[i, j];
                    }
                }
                Console.WriteLine($"{min12} ");
            }


        }
    }
}