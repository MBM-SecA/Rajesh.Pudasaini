using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query
            //LINQ to objects
            int[] numbers = {1, 2, 3, 4, 5, 78, 99};

            //fetch numbers which are greater than 50
            var numbersGreaterThan50 = numbers.Where(x => x > 50);

            //using query syntax - query expression
            var numbersGreaterThan50Another = from num in numbers
                                        where num > 50 && num < 70
                                        select num;

            //names having length greater than 3 and startswith R
            string[] names = {"bishnu", "rajesh", "ramesh", "shyam", "hari", "a", "Raygon", "Ramsy"};
            var lengthGreaterThanThreeAndStartWithR = names.Where(x => x.Length > 3 && x.ToLower().StartsWith('r'));
            foreach(string name in lengthGreaterThanThreeAndStartWithR){
                Console.WriteLine($"Result1: {name}");
            } 
            var lengthGreaterThanThreeAndStartWithRAnother = from name in names 
                                                            where name.Length > 3
                                                            && name.ToLower().StartsWith('r')
                                                            select name;

            foreach(string name in lengthGreaterThanThreeAndStartWithRAnother){
                Console.WriteLine($"Result2: {name}");
            } 
            var countries = Country.GetCountries();
            var asianCountries = from country in countries
                                    where country.Continent == "Asia"
                                    select country;



            //list of european countries with population less than 100k
            Console.WriteLine("European countries with population less than 100k");
            //1. query expression
            var europeCountriesWithPopulation100k1 = from country in countries
                                                    where country.Continent == "Europe" && country.Population < 100000
                                                    select country;

            //2.linq expression
            var europeCountriesWithPopulation100k2 = countries.Where(country => country.Continent == "Europe" && country.Population < 100000);
            Console.WriteLine("Result from Query Expression");
            foreach(var country in europeCountriesWithPopulation100k1){
                Console.WriteLine(country.Name);
            }

            Console.WriteLine("Result from LINQ Expression");
            foreach(var country in europeCountriesWithPopulation100k2){
                Console.WriteLine(country.Name);
            }

            //List of asian countries which are not ever invaded

            Console.WriteLine("List of Asian Countries which are not ever invaded");

            Console.WriteLine("Result from Query Expression");
            var freeAsianCountries = countries.Where(country => country.Continent == "Asia" && country.IndependenceDay == default);
            foreach(var country in freeAsianCountries){
                Console.WriteLine(country.Name);
            }

            Console.WriteLine("Result from LINQ Expression");

            var freeAsianCountries2 = from country in countries
                                        where country.Continent == "Asia" && country.IndependenceDay == default
                                        select country;


            foreach(var country in freeAsianCountries2){
                Console.WriteLine(country.Name);
            }


        }
    }
}
