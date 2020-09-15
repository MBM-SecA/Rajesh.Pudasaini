using System;
using System.Collections.Generic;

namespace LearnCollection {

    public class Collection {
        void LearnLists(){

            List<byte> ages = new List<byte> {2, 3};
            ages.Add(1);
            ages.Add(100);
            ages.Add(12);
            Console.WriteLine(ages);

            List<Country> countries = new List<Country>();
            countries.Add(new Country());
        }

        internal void LearnDictionery(){
            Dictionary<string, string> countryCapital = new Dictionary<string, string>(){
                ["USA"] = "New York",
                ["RUSSIA"] = "Mosco"
            };

            //
            var studentDetail = new Dictionary<string, int>(){
                ["Rajesh"] = 13,
            };
            countryCapital.Add("Nepal", "Kathmandu");
            countryCapital.Add("India", "Delhi");
            countryCapital.Add("China", "Bejing");

            foreach(var country in countryCapital){
                Console.WriteLine($"Country: {country.Key}");
                Console.WriteLine($"Capital: {country.Value}");
            }

        }
    }

    public class Country {
        public string Name {get ; set; }
    }
}