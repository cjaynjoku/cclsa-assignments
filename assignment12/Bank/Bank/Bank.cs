namespace Bank
{
    public abstract class Bank
    {
        public static int totalAccounts = 0;

        public Customers Customer { get; set; }
        
        public decimal Balance { get; set; }

        // Initialized a value to facilitate the Solution test
        public decimal InterestRate { get; set; } = 0.1m;

        public int NumberOfMonths { get; set; }

        public virtual decimal CalculateInterest()
        {
            return InterestRate * NumberOfMonths;
        }

        public Bank()
        {

        }

        public Bank(Customers customer, decimal balance, int numberOfMonths)
        {
            Customer = customer;
            Balance = balance;
            NumberOfMonths = numberOfMonths;

            totalAccounts++;
        }

    }
}
