namespace Animal
{
    public abstract class Animal
    {
        public int Age { get; set; }

        public string Name { get; set; }
        
        public GenderType Gender { get; set; }


        public virtual void MakeSound()
        {
            System.Console.WriteLine("Animals Generic Sound");
        }

        public Animal()
        {

        }

        public Animal(int age, string name, GenderType gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }
    }
}
