//All the assignment1 question

using System;
class Assignment1 {
    static void Main(){
        Console.WriteLine("\n\n\n\n#######-------Executing Assignment 1-------#######");
        //executing ques1
        CheckSum obj1 = new CheckSum();
        obj1.Execute();

        //executing ques2
        TeamPoint obj2 = new TeamPoint();
        obj2.Execute();

        //executing ques3
        GetFirstLetterWord obj3 = new GetFirstLetterWord();
        obj3.Execute();
        // CreateDirExecute obj1 = new CreateDirExecute();
        // bool res = obj1.CreateSubDir();
        // if (res){
        //     Console.WriteLine("Directory and sub-directory created and added program source inside it");
        // }
    }
}