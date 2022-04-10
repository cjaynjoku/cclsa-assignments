using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // The derived class Individual is a typeOf the base class Customers
            Individual sabalyMatthew = new Individual();
            Company adidas = new Company();

            Customers[] customersArray = { sabalyMatthew, adidas };

            // Deposit Account customer check
            DepositAccount depositAccount0 = new DepositAccount(sabalyMatthew, 9.55m, 7);
            Console.WriteLine(depositAccount0.CalculateInterest());
            

            // Deposit Account company check
            DepositAccount depositAccount1 = new DepositAccount(adidas, 10490.55m, 7);
            Console.WriteLine(depositAccount1.CalculateInterest());
            depositAccount1.DepositMoney();
            depositAccount1.WithdrawMoney();

            Console.WriteLine();

            // Loan Account customer check
            LoanAccount loanAccount0 = new LoanAccount(sabalyMatthew, 45.66m, 4);
            Console.WriteLine(loanAccount0.CalculateInterest());

            // Loan Account company check
            LoanAccount loanAccount1 = new LoanAccount(adidas, 10645.22m, 2);
            Console.WriteLine(loanAccount1.CalculateInterest());
            loanAccount1.DepositMoney();


            Console.WriteLine();

            // Mortgage Account customer check
            MortgageAccount mortgageAccount0 = new MortgageAccount(sabalyMatthew, 789.55m, 8);
            Console.WriteLine(mortgageAccount0.CalculateInterest());

            // Mortgage Account company check
            MortgageAccount mortgageAccount1 = new MortgageAccount(adidas, 234789.55m, 12);
            Console.WriteLine(mortgageAccount1.CalculateInterest());
            mortgageAccount1.DepositMoney();


            // Checking the total number of bank accounts
            Console.WriteLine(Bank.totalAccounts);

        }
    }
}
