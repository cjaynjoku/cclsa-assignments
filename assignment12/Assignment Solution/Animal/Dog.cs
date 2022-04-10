namespace Animal
{
    public class Dog: Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
        public Dog(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }
    }
}
