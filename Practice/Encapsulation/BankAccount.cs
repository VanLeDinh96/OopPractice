namespace Practice.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        // constructor
        public BankAccount(decimal balance)
        {
            this.balance = balance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
