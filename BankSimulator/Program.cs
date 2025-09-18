namespace BankSimulator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            //Money rubles = new Money("RUB", 1000.00m);
            //Money euro = new Money("EUR", 150.00m);
            //Money dollar = new Money("USD", 50.00m);
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

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        SwCase.DepositSw();
                        break;

                    case "2":
                        SwCase.WithdrawSw();
                        break;

                    case "3":
                        SwCase.BalanceSw();
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