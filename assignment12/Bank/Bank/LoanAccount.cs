namespace Bank
{
    public class LoanAccount : Bank, IDepositMoney
    {
        public LoanAccount()
        {

        }
        public LoanAccount(Customers customer, decimal balance, int numberOfMonths) : base(customer, balance, numberOfMonths)
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
                if(NumberOfMonths < 4)
                {
                    InterestRate = 0;
                }
            }

            if (Customer is Company)
            {
                if(NumberOfMonths < 3)
                {
                    InterestRate = 0;
                }
            }

            return base.CalculateInterest();
        }
    }
}
