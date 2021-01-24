using System;
using System.Collections.Generic;
using System.Linq;
using Vraag3.LINQ.Domain;

namespace Vraag3.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var personen = new List<Person>
            {
                new Person { ID = 1, FirstName = "Jessika", LastName = "Leppers", Dob = new DateTime(1966, 3, 5), Wage = 3433.33m, Address = new Address { Street = "Rue Leval", Number = "42", Province = Province.Namen } },
                new Person { ID = 2, FirstName = "Julian", LastName = "Ahmed", Dob = new DateTime(1966, 2, 21), Wage = 4262.92m, Address = new Address { Street = "Perksesteenweg", Number = "55", Province = Province.Vlaams_Brabant } },
                new Person { ID = 3, FirstName = "Guinivere", LastName = "Langbroek", Dob = new DateTime(1995, 1, 4), Wage = 2174.91m, Address = new Address { Street = "Molenstraat", Number = "262", Province = Province.Antwerpen } },
                new Person { ID = 4, FirstName = "Dominique", LastName = "Cuypers", Dob = new DateTime(1945, 7, 9), Wage = 6806.66m, Address = new Address { Street = "Groenstraat", Number = "103", Province = Province.Antwerpen } },
                new Person { ID = 5, FirstName = "Frederic", LastName = "Petit", Dob = new DateTime(1965, 5, 28), Wage = 3620.42m, Address = new Address { Street = "Elzenstraat", Number = "15", Province = Province.Antwerpen } },
                new Person { ID = 6, FirstName = "Hayo", LastName = "Vries", Dob = new DateTime(1990, 10, 24), Wage = 2635.5m, Address = new Address { Street = "Stationsstraat", Number = "293", Province = Province.Vlaams_Brabant } }
            };

            var jongste = personen.OrderByDescending(p => p.Dob).First();
            var oudsteDrie = personen.OrderBy(p => p.Dob).Take(3);
            var gem = personen.Where(p => p.Address.Province == Province.Vlaams_Brabant).Average(p => DateTime.Now.Year - p.Dob.Year);
            var ouderDan40 = personen.Count(p => p.Address.Province == Province.Antwerpen && (DateTime.Now.Year - p.Dob.Year) > 40);
            var meerOfMinder = personen.Select(p => $"{p.ToString()}, {p.Wage - 3558}");
            
            Console.WriteLine(jongste);
            Console.WriteLine();

            Console.WriteLine(string.Join("\n", oudsteDrie));
            Console.WriteLine();

            Console.WriteLine(gem);
            Console.WriteLine();

            Console.WriteLine(ouderDan40);
            Console.WriteLine();

            Console.WriteLine(string.Join("\n", meerOfMinder));
            Console.WriteLine();
        }
    }
}
