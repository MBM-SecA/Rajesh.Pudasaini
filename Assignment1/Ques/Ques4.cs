//Create a folder name "ABC" and create 10 sub folder where each folder should contain C# with a program to print Hello World.
using System;
using System.IO;

public class CreateDirExecute {

    string dirName = "ABC";
    
    internal bool CreateDir(){
        Directory.CreateDirectory(dirName);
        return true;
    }

    internal bool CreateSubDir(){
        bool res = CreateDir();
        if (res){
        for (int i=1; i<=10; i++){
            Directory.CreateDirectory($"{dirName}/abc{i}");
            string programSource = "using System;namespace Assignment_Q { class PrintHelloWorld {void Display(){ Console.WriteLine(\"Hello world\");}}}";
            // string programCode = string.Format(programSource, i, i);
            // using (StreamWriter outputFile = new StreamWriter($"{dirName}/abc{i}/program.cs", true))
            // {
            //     outputFile.WriteLine("Fourth Line");
            // }
            File.WriteAllText($"{dirName}/abc{i}/program.cs", programSource);
        }
        }
        return true;
    }
}