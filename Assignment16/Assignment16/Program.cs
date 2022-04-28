using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment16
{
    internal class Program
    {
        public static string text = "StarLight is the light emitted by start.[1] It typically reders to visible electromagnetic radiation from stars" +
                            "other than the Sun, observable from the Earth at night, althoug a component of starlight is observable from Earth during daytime. " +
                            "Sunlight is the term used for the Sun's starlgiht observed during daytime.[2] " +
                            "During nighttime, albedo describes solar reflections from other Solar System objects, including moonlight, planet shine and zodiacal light. [3]";

        static void Main(string[] args)
        {
            StringMethod();
        }

        public static void StringMethod()
        {
            // 1. Extracting parts of the text
            int index1 = text.IndexOf("observable");
            string firstPart = text.Substring(index1, 15);
            int index2 = text.IndexOf("zodiacal");
            string secondPart = text.Substring(index2 - 10, 10);

            string fullText = firstPart + secondPart;
            Console.WriteLine(fullText);


            // 2. Replacing Sun in the text to "Solar Emission".
            string newText = text.Replace("Sun", "Solar Emission");
            Console.WriteLine(newText);


            // Writing the index of all occurences of "Solar Emission" to the console
            int sunIndex = newText.IndexOf("Solar Emission");

            while (sunIndex != -1)
            {
                Console.WriteLine(sunIndex);
                sunIndex = newText.IndexOf("Solar Emission", sunIndex + 1);
            }

            // 3. Splitting the text based on each sentences

            char[] separators = new char[] { '.' };
            string[] splitText = text.Split(separators);

            string mergedString = splitText[0] + '.' + splitText[splitText.Length - 2] + '.';
            Console.WriteLine(mergedString);

            // 4. Extracting all the reference numbers


            Regex rx = new Regex("[0-9]");
            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

            // 5a. List of all Vowel Characters
            Console.WriteLine();
            Console.WriteLine("The vowel charaters are: ");
            List<string> vowelCharacters = new List<string>();

            Regex vCharRegex = new Regex("[aeiou]");
            MatchCollection vowelMatches = vCharRegex.Matches(text);
            foreach (Match match in vowelMatches)
            {
                vowelCharacters.Add(match.Groups[0].Value);
            }

            foreach(string item in vowelCharacters)
            {
                Console.WriteLine(item);
            }


            // 5b. List of all Consonant Characters
            Console.WriteLine();
            Console.WriteLine("The consonant characters are: ");
            List<string> consonantCharacters = new List<string>();

            Regex cCharRegex = new Regex("[qwrtyupsdfghjklzxcvbnm]");
            MatchCollection consonantMatches = cCharRegex.Matches(text);
            foreach (Match match in consonantMatches)
            {
                consonantCharacters.Add(match.Groups[0].Value);
            }

            foreach (string item in consonantCharacters)
            {
                Console.WriteLine(item);
            }
            //5c. List of all Number Characters
            Console.WriteLine();
            Console.WriteLine("The numbers in the text are: ");
            List<string> numbers = new List<string>();

            Regex numRegex = new Regex("[0-9]");
            MatchCollection numMatches = numRegex.Matches(text);
            foreach (Match match in numMatches)
            {
               numbers.Add(match.Groups[0].Value);
            }

            foreach (string item in numbers)
            {
                Console.WriteLine(item);
            }

            // 5d. List of all Special Characters
            Console.WriteLine();
            Console.WriteLine("The Special Characters in the text are: ");
            List<string> specialCharacters = new List<string>();

            Regex sCharsRegex = new Regex("[\\[\\]\\.,!@#$%^&*|]");
            MatchCollection sCharMatches =sCharsRegex.Matches(text);
            foreach (Match match in sCharMatches)
            {
                specialCharacters.Add(match.Groups[0].Value);
            }

            foreach (string item in specialCharacters)
            {
                Console.WriteLine(item);
            }

        }
    }
}
