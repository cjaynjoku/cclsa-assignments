using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat aCat = new Cat(16, "SomeCat", GenderType.male);

            Dog aDog = new Dog(5, "Hitdolf", GenderType.female);

            Frog aFrog = new Frog(1, "SomeFrog", GenderType.male);

            Kitten aKitten = new Kitten(2, "SomeKitten", GenderType.female);

            TomCat aTomCat = new TomCat(5, "Felix", GenderType.male);

            Animal[] animalArray = new Animal[5]
            {
                aCat, aDog, aFrog, aKitten, aTomCat
            };

            PrintArray(animalArray);

        }

        public static void PrintArray(Animal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Animal's name: " + array[i].Name);
                Console.WriteLine("Animal's age: " + array[i].Age);
                Console.Write("Sound from animal: ");
                array[i].MakeSound();
                Console.WriteLine();
            }
        }
    }
}
