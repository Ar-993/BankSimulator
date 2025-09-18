

namespace BankSimulator
{
    using System;
    class Money 
    {
        //public int  { get; private set; }

        private decimal _balance;
        public string currency { get; private set; }

        public Money(string curr, decimal bal)
        {
            currency = curr;
            _balance = bal;
        }

        public bool WithdrawMoney(decimal value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Сумма должна быть положительным!", nameof(value));
                return false;
            }
            else if (value > _balance)
            {
                Console.WriteLine($"Нема денег на карте(.  Баланс состоявляет: {_balance} {currency} ");
                return false;
            }
            _balance -= value;
            Console.WriteLine($"Снято: {value} {currency}. Осталось: {_balance} {currency}");
            return true;
        }

        public void DepositMoney(decimal dMoney)
        {
            if (dMoney <= 0)
            {
                Console.WriteLine("Сумма пополнения должна быть положительной");
            }
            _balance += dMoney;
            Console.WriteLine($"Пополнено: {dMoney} {currency}. Баланс составляет {_balance} ");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Ваш баланс состовляет: {_balance} {currency}");
        }
    }
}

