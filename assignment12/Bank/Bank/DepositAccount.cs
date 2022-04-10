namespace Bank
{
    public class DepositAccount : Bank, IDepositMoney, IWithdrawMoney
    {
        public DepositAccount()
        {

        }
        public DepositAccount(Customers customer, decimal balance, int numberOfMonths) : base(customer, balance, numberOfMonths)
        {
        }

        public void DepositMoney()
        {
            System.Console.WriteLine("Simulating Depositing Money");

        }

        public void WithdrawMoney()
        {
            System.Console.WriteLine("Simulating Withdrawing Money");
        }

        public override decimal CalculateInterest()
        {
            if ((Balance > 1) && (Balance < 1000))
            {
                InterestRate = 0;
            }

            return base.CalculateInterest();
        }
    }
}
