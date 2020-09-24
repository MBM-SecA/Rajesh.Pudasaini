using System;
using System.Collections.Generic;

public class Country {
    public string Name {get; set;}

    public string Continent {get; set;}

    public double Area {get;set;}

    public long Population {get; set;}

    public DateTime IndependenceDay {get; set;}

    public Country(string name, string continent, double area, long population, DateTime independenceDay = default){
        Name=name;
        Continent=continent;
        Area=area;
        Population=population;
        IndependenceDay=independenceDay;
    }

    public static List<Country> GetCountries() {
            Country c1 = new Country(){
                    Name = "Nepal",
                    Continent = "Asia",
                    Area = 147141.0,
                    Population = 300000,
                };
            
            Country c2 = new Country("China", "Asia", "1234563237.78", "3000000");
            Country c3 = new Country("India", "Asia", "123456327.78", "4000000");
            Country c4 = new Country("Sri Lanka", "Asia", "1234563327.78", "5000000");
            Country c5 = new Country("France", "Europe", "12343232567.78", "6000000");
            Country c6 = new Country("USA", "North America", "12343232567.78", "6000000");

            List<Country> countries = new List<Country>{c1, c2, c3, c4, c5};
            return countries;
    }
}