namespace Bank
{
    public class MortgageAccount : Bank, IDepositMoney
    {
        public MortgageAccount()
        {

        }
        public MortgageAccount(Customers customer, decimal balance, int numberOfMonths) : base(customer, balance, numberOfMonths)
        {
        }
        public void DepositMoney()
        {
            System.Console.WriteLine("Simulating Depositing Money");
        }

        public override decimal CalculateInterest()
        {
            if (Customer is Individual)
            {
                if (NumberOfMonths <= 6)
                {
                    InterestRate = 0;
                }
            }

            if (Customer is Company)
            {
                if (NumberOfMonths <= 12)
                {
                    InterestRate = 0.5m * InterestRate;
                }
            }


            return base.CalculateInterest();
        }
    }

}
