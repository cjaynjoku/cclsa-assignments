namespace Animal
{
    public class Kitten : Cat
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }
        public Kitten(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }
    }
}
