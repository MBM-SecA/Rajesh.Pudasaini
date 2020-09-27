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
            int[] numbers = {1, 2, 3, 4, 5, 78, 99, 0, 6, 9};

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


            //Projection

            var result = numbers.Select(x => x * 2);
            var result2 = from num in numbers
                            select num * num;
            foreach(var r in result){
                Console.WriteLine(r);
            }

            var result3 = from num in numbers
                            orderby num
                            select num;

            foreach(var r in result3){
                Console.WriteLine(r);
            }
            
            var result4 = from name in names
                            orderby name 
                            select name;

            foreach(var r in result4){
                Console.WriteLine(r);
            }

            var result5 = numbers.OrderBy(x => x).Take(5);
            foreach(var r in result5){
                Console.WriteLine(r);
            }
            
            //Partitioning
            var result6 = numbers.Skip(5).Take(5);

            foreach(var r in result6){
                Console.WriteLine(r);
            }

            //Quantifier
            var result8 = numbers.Any(x => x % 2 ==0 ); //Any returns boolean
            var result9 = numbers.All(x => x % 2 ==0 ); //Any returns boolean
            var result10 = numbers.Contains(0);

            //Repeating
            var result11 = Enumerable.Range(1, 1000);
            var result12 = Enumerable.Repeat("Hello World", 10);

            foreach(var r in result12){
                Console.WriteLine(r);
            }

        }
    }
}
