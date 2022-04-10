namespace Human
{
    public class Worker : Human
    {
        public decimal Wage { get; set; }
        public decimal HoursWorked { get; set; }

        public decimal CalculateHourlyWages()
        {
            return Wage * HoursWorked;
        }

        public Worker(string firstName, string lastName, decimal wage, decimal hoursWorked): base(firstName, lastName)
        {
            Wage = wage;
            HoursWorked = hoursWorked;
        }
    }
}
