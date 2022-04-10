namespace Animal
{
    public class Frog : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("Brah");
        }
        public Frog(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }
    }
}
