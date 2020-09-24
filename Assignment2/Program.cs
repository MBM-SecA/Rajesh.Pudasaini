//All the assignment1 question

using System;
class Assignment1 {
    static void Main(){
        CreateDirExecute obj1 = new CreateDirExecute();
        bool res = obj1.CreateSubDir();
        if (res){
            Console.WriteLine("Directory and sub-directory created and added program source inside it");
        }
    }
}