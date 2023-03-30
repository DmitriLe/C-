using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace third3
{
    class third31
    {
        public void main()
        {
            List<Pokupka> spisok = new List<Pokupka>();
            spisok.Add(new Pokupka("Kola", 990));
            spisok.Add(new Pokupka("Chips", 1038));
            spisok.Add(new Pokupka("Sugar", 160));
            int schet = 0, number = 0, schetOshibok = 0, num = 0, schetPer = 0, per228 = 0, summa1 = 0, num1 = 0, number1 = 0, cen1, num2;
            bool zad3 = true;
            string prod, cen, num8;
            int min12 = 0, iii = 0; ;
            int[,] array23 = new int[5, 6];
            int[] arrayfin = new int[5];
            while (zad3 == true)
            {
                bool zad33 = true;
                while (zad33 == true)
                {
                    Console.WriteLine("\n1. Показать список\n");
                    Console.WriteLine("2. Добавить элемент\n");
                    Console.WriteLine("3. Показать элементы, стоимостью не менее 1000\n");
                    Console.WriteLine("4. Выход из списка\n");
                    string NomerZadachi11 = Console.ReadLine();
                    if (int.TryParse(NomerZadachi11, out num1))
                    {
                        if (num1 >= 1 && num1 <= 4)
                        {
                            number1 = num1;
                            zad33 = false;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неверное значение!\nВведите номер пункта меню!\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неверное значение!\nВведите номер пункта меню!\n");
                    }
                }
                switch (number1)
                {
                    case 1:
                        for (int i = 0; i < spisok.Count; i++)
                        {
                            Console.WriteLine($"\n{spisok[i].Product} {spisok[i].Cena}\n");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите продукт:\n");
                        prod = Console.ReadLine();
                        Console.WriteLine("Введите цену:\n");
                        cen = Console.ReadLine();
                        cen1 = int.Parse(cen);
                        spisok.Add(new Pokupka(prod, cen1));
                        break;
                    case 3:
                        for (int i = 0; i < spisok.Count; i++)
                        {
                            if (spisok[i].Cena >= 1000)
                            {
                                Console.WriteLine($"\n{spisok[i].Product} {spisok[i].Cena}");
                            }
                        }
                        break;
                    case 4:
                        zad3 = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значение!\n");
                        break;
                }
            }


        }

        public struct Pokupka
        {
            private string product;
            private int cena;

            public Pokupka(string pp, int pop)
            {
                product = pp;
                cena = pop;
            }

            public string Product
            {
                get { return product; }
                set
                {
                    product = value;
                }
            }

            public int Cena
            {
                get { return cena; }
                set
                {
                    cena = value;
                }
            }
        }

    }
}