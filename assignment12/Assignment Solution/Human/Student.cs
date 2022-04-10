namespace Human
{
    public class Student : Human
    {
        public double Mark { get; set; }
        
        public Student(string firstName, string lastName, double mark) : base(firstName, lastName)
        {
            Mark = mark;
        }
    }
   
}
