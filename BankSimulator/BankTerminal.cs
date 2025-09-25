using System;
using System.Collections.Generic;

namespace BankSimulator
{
    class BankTerminal 
    {
        
        private static Dictionary<string, Money> accounts = new Dictionary<string, Money>
        {
            { "RUB", new Money("RUB", 1000.00m) },
            { "EUR", new Money("EUR", 150.00m) },
            { "USD", new Money("USD", 50.00m) }
            //{ "CNY", new Money("CNY", 300.00m) }
        };

        private static Money SelectAccount()
        {
            Console.WriteLine("Выберите валюту:");
            Console.WriteLine("----");
            Console.WriteLine("1 - RUB");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - USD");
            Console.WriteLine("----");
            Console.WriteLine("0 - вернуться в меню");

            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": return accounts["RUB"];
                case "2": return accounts["EUR"];
                case "3": return accounts["USD"];
                case "0": return null;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    Console.ReadKey();
                    Console.Clear();
                    return null;
            }
        }

        private static decimal GetAmountFromUser(string action)
        {
            while (true)
            {
                Console.WriteLine($"Введите сумму, которую хотите {action}:");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal amount) && amount > 0)
                {
                    return amount;
                }
                Console.WriteLine("Ошибка. Введите положительное число.");
            }
        }

        public static void Deposit() 
        {
            Money account = SelectAccount();
            if (account != null)
            {
                decimal amount = GetAmountFromUser("пополнить");
                account.DepositMoney(amount);
                Console.WriteLine("Операция выполнена успешно.");
            }
            // Если account == null, просто выходим
        }

        public static void Withdraw()
        {
            Money account = SelectAccount();
            if (account != null)
            {
                decimal amount = GetAmountFromUser("снять");
                account.WithdrawMoney(amount); 
                Console.WriteLine("Операция выполнена успешно.");
            }
        }

        public static void ShowBalance()
        {
            Money account = SelectAccount();
            if (account != null)
            {
                Console.Clear();
                Console.WriteLine($"Ваш баланс составляет: {account.Balance} {account.Currency}");
            }
        }
    }
}