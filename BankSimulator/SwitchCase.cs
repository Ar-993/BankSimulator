using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulator
{
    using System;
    class SwCase
    {
        private static Money rubles = new Money("RUB", 1000.00m);
        private static Money euro = new Money("EUR", 150.00m);
        private static Money dollar = new Money("USD", 50.00m);
        public static void DepositSw()
        {
            bool f = true;
            bool boolValue;
            decimal rub;
            decimal eur;
            decimal usd;
            Console.WriteLine("Какую валюту надо пополнить?");
            Console.WriteLine("----");
            Console.WriteLine("1 - RUB");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - USD");
            Console.WriteLine("----");
            Console.WriteLine("0 - выйти в меню");

            Console.Write("Ваш выбор: ");
            string depositChoise = Console.ReadLine();

            Console.Clear();    

            switch (depositChoise)
            {
                case "1":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите пополнить?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out rub);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите положить(число)");
                        else
                        {
                            f = false;
                            rubles.DepositMoney(rub);
                        }
                    }
                    break;

                case "2":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите пополнить?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out eur);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите положить(число)");
                        else
                        {
                            f = false;
                            euro.DepositMoney(eur);
                        }
                    }
                    break;
                case "3":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите пополнить?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out usd);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите положить(число)");
                        else
                        {
                            f = false;
                            dollar.DepositMoney(usd);
                        }
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неккоретно введены данные,введите ещё раз");
                    Console.ReadKey();
                    DepositSw(); // Рекурсивный вызов для повторного показа меню
                    break;
            }
        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
        Console.ReadKey();
        Console.Clear();
        }
        public static void WithdrawSw()
        {
            bool f = true;
            bool boolValue;
            decimal rub;
            decimal eur;
            decimal usd;

            Console.WriteLine("Какую валюту вы хотите снять?");
            Console.WriteLine("----");
            Console.WriteLine("1 - RUB");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - USD");
            Console.WriteLine("----");
            Console.WriteLine("0 - выйти в меню");

            string withdrawChoise = Console.ReadLine();

            Console.Clear();

            switch (withdrawChoise)
            {
                case "1":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите снять?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out rub);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите снять(число)");
                        else
                        {
                            f = false;
                            rubles.WithdrawMoney(rub);
                        }
                    }
                    break;
                case "2":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите снять?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out eur);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите снять(число)");
                        else
                        {
                            f = false;
                            euro.WithdrawMoney(eur);
                        }
                    }
                    break;
                case "3":
                    while (f)
                    {
                        Console.WriteLine("Сколько вы хотите снять?");
                        string input = Console.ReadLine();

                        boolValue = decimal.TryParse(input, out usd);

                        if (boolValue != true)
                            Console.WriteLine("Ошибка. Введите сумму, которую хотите снять(число)");
                        else
                        {
                            f = false;
                            dollar.WithdrawMoney(usd);
                        }
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неккоретно введены данные,введите ещё раз");
                    Console.ReadKey();
                    WithdrawSw(); // Рекурсивный вызов для повторного показа меню
                    break;
            }
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
            Console.Clear();
        }
        public static void BalanceSw()
        {
            Console.WriteLine("Какой баланс валюты вам нужен?");
            Console.WriteLine("----");
            Console.WriteLine("1 - RUB");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - USD");
            Console.WriteLine("----");
            Console.WriteLine("0 - выйти в меню");

            string balanceChoise = Console.ReadLine();

            Console.Clear();

            switch (balanceChoise)
            {
                case "1":
                    rubles.GetBalance();
                    break;
                case "2":
                    euro.GetBalance(); 
                    break;
                case "3":
                    dollar.GetBalance();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неккоретно введены данные,введите ещё раз");
                    Console.ReadKey();
                    BalanceSw(); // Рекурсивный вызов для повторного показа меню
                    break;
            }
            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
