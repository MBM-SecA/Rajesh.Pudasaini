using System;
using System.Collections.Generic;
using System.Linq;
public class ComplexType {
    public static void LearnLinq(){
            var countries = Country.GetCountries();
            //list of european countries with population less than 100k
            // Console.WriteLine("European countries with population less than 100k");
            //1. query expression
            var europeCountriesWithPopulation100k1 = from country in countries
                                                    where country.Continent == "Europe" && country.Population < 100000
                                                    select country;

            //2.linq expression
            var europeCountriesWithPopulation100k2 = countries.Where(country => country.Continent == "Europe" && country.Population < 100000);
            // Console.WriteLine("Result from Query Expression");
            // foreach(var country in europeCountriesWithPopulation100k1){
            //     Console.WriteLine(country.Name);
            // }

            // Console.WriteLine("Result from LINQ Expression");
            // foreach(var country in europeCountriesWithPopulation100k2){
            //     Console.WriteLine(country.Name);
            // }

            //List of asian countries which are not ever invaded

            // Console.WriteLine("List of Asian Countries which are not ever invaded");

            // Console.WriteLine("Result from Query Expression");
            var freeAsianCountries = countries.Where(country => country.Continent == "Asia" && country.IndependenceDay == default);
            // foreach(var country in freeAsianCountries){
            //     Console.WriteLine(country.Name);
            // }

            // Console.WriteLine("Result from LINQ Expression");

            var freeAsianCountries2 = from country in countries
                                        where country.Continent == "Asia" && country.IndependenceDay == default
                                        select country;


            // foreach(var country in freeAsianCountries2){
            //     Console.WriteLine(country.Name);
            // }

            //HW - Is there any african country in your country collection
            var anyAfricanCountry = countries.Any(x => x.Continent == "Africa");
            if (anyAfricanCountry){
                Console.WriteLine("Yes, there is African Country");
            } else {
                Console.WriteLine("We don't have African countries in out country collection");
            }

            //HW - print first 2 largest asian country names.
            var largestAsianCountry = countries.Where(x => x.Continent == "Asia").OrderBy(x => -x.Population).Take(2).Select(x => x.Name);
            Console.WriteLine("Largest Asian country Based on Area!!!");
            foreach(var country in largestAsianCountry){
                Console.WriteLine(country);
            }
    }
}