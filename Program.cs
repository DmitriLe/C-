using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using first1;
using second2;
using third3;

void main()
{
    first11 first12 = new first11();
    second21 second22 = new second21();
    third31 third32 = new third31();
    int schet = 0, number = 0, schetOshibok = 0, num = 0, schetPer = 0, per228 = 0, summa1 = 0, num1 = 0, number1 = 0, cen1, num2;
    bool zad3 = true;
    string prod, cen, num8;
    #region
    while (schet == 0)
    {
        while (schetOshibok == 0)
        {
            Console.WriteLine("\nВведите номер пункта меню:\n");
            Console.WriteLine("1.Решить первую задачу\n");
            Console.WriteLine("2.Решить вторую задачу\n");
            Console.WriteLine("3.Решить третью задачу\n");
            Console.WriteLine("4.Выход из программы\n");
            string NomerZadachi = Console.ReadLine();
            if (int.TryParse(NomerZadachi, out num))
            {
                schetOshibok++;
                number = num;
            }
            else
            {
                Console.WriteLine("Вы ввели не число!\n");
            }
            switch (number)
            {
                case 1:

                    first12.main();

                    schetOshibok = 0;
                    break;
                case 2:
                    second22.main();

                    schetOshibok = 0;
                    break;
                case 3:
                    third32.main();
                    schetOshibok = 0;
                    break;

                case 4:
                    Console.WriteLine("До свидания!\n");
                    schet++;
                    break;
                default:
                    schetOshibok = 0;
                    Console.WriteLine("!!!Пожалуйста введите номер пункта меню!!!\n");
                    break;
            }
        }
    }
    #endregion
}

main();

