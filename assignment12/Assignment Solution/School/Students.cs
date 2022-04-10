namespace School
{
    public class Students : People
    {
        public int IdNumber { get; set; }

        public Students(string name, int number): base(name)
        {
            Name = name;
            IdNumber = number;
        }
    }
}
