using System;
using Vraag2.Library;

namespace Vraag2.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.LoadMovies(@"C:\temp\movies\");

            bool doorgaan = true;

            while (doorgaan)
            {
                try
                {
                    Console.Write("Zoekterm: ");
                    var zoekTerm = Console.ReadLine();
                    var res = Helper.SearchMovies(zoekTerm);
                    doorgaan = false;
                    Console.WriteLine(string.Join("\n", res));
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }

            }




        }
    }
}
