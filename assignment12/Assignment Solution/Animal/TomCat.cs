namespace Animal
{
    public class TomCat : Cat
    {
        public override void MakeSound()
        {
            base.MakeSound();
        }
        public TomCat(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }
    }
}
