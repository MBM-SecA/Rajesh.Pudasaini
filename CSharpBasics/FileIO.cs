using System;
using System.IO;

public class FileIO {

    public void LearnFileHandling(){

        //file reading in csharp
        //c sharp verbating character = @ (allowed to use the escape sequence)
        string fileContent = File.ReadAllText("/Users/rajeshpudasaini/Desktop/c-sharp/dotnet");
        Console.WriteLine(fileContent);

        //look the file inside the project
        string dataTypeContent = File.ReadAllText("DataType.cs");
        Console.WriteLine(dataTypeContent);

        if (File.Exists("Random.txt")){
            string randomContent = File.ReadAllText("Random.txt");
        } else {
            Console.WriteLine("File Doesn't exists");
        }

        string fileName = "Random.txt";
        //file writing in cSharp
        File.WriteAllText(fileName,"This is just a text file");

    }

    internal void LearnFileInfo(){
        string fileName = "Random.txt";
        FileInfo fileInfo = new FileInfo(fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine($"File Size: {size} bytes");
        Console.WriteLine($"Created Datetime: {createdDate}");
    }

    internal void LearnDirectories(){

        string directoryName = "A/a";
        Directory.CreateDirectory(directoryName);
        Console.WriteLine(Directory.GetLogicalDrives());

    }
}