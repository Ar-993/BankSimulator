namespace BankSimulator
{
    public class Money
    {
        public string Currency { get; private set; }
        public decimal Balance { get; private set; }

        public Money(string currency, decimal initialBalance)
        {
            Currency = currency;
            Balance = initialBalance;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public bool WithdrawMoney(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }
    }
}