using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program's aim is to collect your favourite animals and store them in a text file.
            // There is a given text file called '''favourites.txt''', it will contain the animals
            // If ran from the command line without arguments
            // It should print out the usage:
            // ```C# FavouriteAnimals [animal] [animal]```
            // You can add as many command line arguments as many favourite you have.
            // One animal should be stored only at once
            // Each animal should be written in separate lines
            // The program should only save animals, no need to print them

            Favourites favourites = new Favourites();

            if (args.Length == 0)
            {
                favourites.PrintUsage();
            }
            else if (args.Contains("dog"))
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
                    Console.WriteLine("Uh-no, no doggos found");
                }
                Console.ReadLine();
            }
        }
    }
}
