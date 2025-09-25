using System;

namespace BankSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== БАНКОВСКИЙ СИМУЛЯТОР ===");
                Console.WriteLine("1 - Пополнить счет");
                Console.WriteLine("2 - Снять деньги");
                Console.WriteLine("3 - Показать баланс");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BankTerminal.Deposit();
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                        Console.ReadKey();
                        break;

                    case "2":
                        BankTerminal.Withdraw();
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                        Console.ReadKey();
                        break;

                    case "3":
                        BankTerminal.ShowBalance();
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                        Console.ReadKey();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}