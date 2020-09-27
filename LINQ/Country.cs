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

    public Country()
    {
    }

    public static List<Country> GetCountries() {
            Country c1 = new Country(){
                    Name = "Nepal",
                    Continent = "Asia",
                    Area = 147141.0,
                    Population = 300000,
                };
            
            Country c2 = new Country("China", "Asia", 1234563237.78, 3000000, DateTime.Parse("1997/08/21"));
            Country c3 = new Country("India", "Asia", 123456327.78, 4000000, new DateTime(1947, 08, 15));
            Country c4 = new Country("Sri Lanka", "Asia", 1234563327.78, 5000000);
            Country c5 = new Country("France", "Europe", 12343232567.78, 6000000);
            Country c6 = new Country("USA", "North America", 12343232567.78, 6000000);
            Country c7 = new Country("Pakistan", "Asia", 1234563237.78, 3000000, new DateTime(1947, 08, 14));
            Country c8 = new Country("Russia", "Asia", 123456327.78, 4000000);
            Country c9 = new Country("Bhutan", "Asia", 1234563327.78, 5000000, new DateTime(1948, 02, 04));
            Country c10 = new Country("Italy", "Europe", 12343232567.78, 10000000);
            Country c11 = new Country("Canada", "North America", 456789.78, 16000000);
            Country c12 = new Country("Mexico", "North America", 1234563237.78, 3000000);
            Country c13 = new Country("Japan", "Asia", 123456327.78, 4000000);
            Country c14 = new Country("Congo", "African", 1234563327.78, 5000000);
            Country c15 = new Country("Australia", "Australia", 8600000.78, 39000000);
            Country c16 = new Country("Korea", "Asia", 12343232567.78, 6000000);
            Country c17 = new Country("Argentina", "South America", 1234563237.78, 3000000);
            Country c18 = new Country("Brazil", "South America", 123456327.78, 4000000);
            Country c19 = new Country("Uruguay", "South America", 1234563327.78, 5000000);
            Country c20 = new Country("Thailand", "Asia", 12343232567.78, 6000000);
            Country c21 = new Country("Ghana", "Africa", 12343232567.78, 6000000);
            Country c22 = new Country("Vatican City", "Europe", 49.0, 825);

            List<Country> countries = new List<Country>{c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22};
            return countries;
    }
}