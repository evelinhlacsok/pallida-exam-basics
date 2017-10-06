using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FavouriteAnimals
{
    class Favourites
    {
        public void PrintUsage()
        {
            Console.WriteLine("```C# FavouriteAnimals [animal] [animal]```");
            Console.ReadLine();
        }

        public void DogCounter()
        {
            string path = @"../../favourites.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                int dogCounter = 0;
                if (content.Contains("dog"))
                {
                    dogCounter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-no, could not read the file");
            }
            Console.ReadLine();
        }

        public void RaccoonCounter()
        {
            string path = @"../../favourites.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                int raccoonCounter = 0;
                if (content.Contains("raccoon"))
                {
                    raccoonCounter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-no, could not read the file");
            }
            Console.ReadLine();
        }
    }
}
