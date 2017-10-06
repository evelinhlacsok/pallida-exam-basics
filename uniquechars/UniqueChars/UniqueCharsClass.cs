using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniqueCharsClass
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"

            string input = "succulents";
            Console.WriteLine(UniqueCharacters(input) + "\" , \"");
            Console.ReadLine();
        }

        public static List<char> UniqueCharacters(string input)
        {
            List<char> letters = new List<char>(input);
            foreach (char letter in letters)
            {
                if (!letters.Contains(letter))
                {
                    letters.Add(letter);
                }
            }
            return letters;
        }
    }
}
