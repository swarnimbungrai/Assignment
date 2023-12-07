
namespace AssignmentW4
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;


        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //Method to deposit an amount into the account
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        // Method to withdraw an amount from the account
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
    }
}
