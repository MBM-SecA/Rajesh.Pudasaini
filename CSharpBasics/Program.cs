using LearnCollection;
using System.IO;
using System.Linq; //Language integrated query
using System;
class Program {
    static void Main(){
        // Collection collection1 = new Collection();
        // collection1.LearnDictionery();

        FileIO file1 = new FileIO();
        file1.LearnFileHandling();
        file1.LearnFileInfo();
        file1.LearnDirectories();

        var countries = File.ReadAllText("Countries.txt");
        string[] countriesList = countries.Split("\n");

        //language integrated query
        var countriesStartWithN = countriesList.Where(x => x.StartsWith("N")).Select(x => x);
        foreach(var country in countriesStartWithN){
            Console.WriteLine(country);
        }
    }
}