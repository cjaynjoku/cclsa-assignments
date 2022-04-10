namespace Animal
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            System.Console.WriteLine("meoww");
        }

        public Cat(int age, string name, GenderType gender): base(age, name, gender)
        {

        }
    }
}
