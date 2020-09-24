using System;


class MeanModeMedian {

        static void MainTest(){
            MeanModeMedian obj1 = new MeanModeMedian();
            obj1.Calculate(1, 2, 3, 4, 5, 6);
        }

        void Calculate(params int[] args){
            double sum = 0.0;
            foreach(int arg in args){
                sum += arg;
            }
            Console.WriteLine(args.Length);
            double mean = sum/args.Length;
            Console.WriteLine($"Mean: {mean}");
            double median = args[args.Length/2];
            Console.WriteLine($"Median: {median}");
        }
}




        // public string Name {
        //     get; set;
        // }

        // public double Depth {
        //     get; set;
        // }
        // //default constructor
        // public Lake(){

        // }

        // //single parameter constructor
        // public Lake(string name){
        //     Name=name;
        // }

        // //double parameter constructor
        // public Lake(string name, double depth){
        //     Name=name;
        //     Depth=depth;
        // }

        // void DisplayResult(){
        //     Console.WriteLine(Name);
        //     Console.WriteLine(Depth);
        // }