using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {

        static void Main1()
        {

            Stopwatch stopWatch = new Stopwatch();

            //Async await in C-Sharp

            //Making Breakfast

            //Make Tea
            // - Turn on Burner (2s)
            // - Place Kettle on Burner (2s)
            // - Pour Water (5s)
            // - Let it boil (5min)
            // - Grind Masalas (1 min)
            // - Put Sugar and Masalas (5s)
            // - Pour Milk (5s)
            // - Let it boil (3min)
            //
            // - Turn on Burner
            // - Put pan on and oil it (3s)
            // - Crack eggs and whisk it 
            // - Fry

            //Sequential Version - Expected Execution Time: 68 sec

            stopWatch.Start();
            TurnOnBurner();
            PlaceOnBurner("Kettle");
            Add("Water");
            Boil("Water");
            GrindTeaMasala();
            PutSugarAndMasala();
            Add("Milk");
            Boil("Milk");

            TurnOnBurner();
            PlaceOnBurner("Pan");
            AddOil();
            WhiskEggs();
            Fry();
            Serve();
            Console.WriteLine($"Time Taken: {stopWatch.ElapsedMilliseconds} ms");


        }

        static async Task Main(){
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            await TurnOnBurner();
            await PlaceOnBurner("Kettle");
            await Add("Water");
            await Boil("Water");
            await GrindTeaMasala();
            await PutSugarAndMasala();
            await Add("Milk");
            await Boil("Milk");

            await TurnOnBurner();
            await PlaceOnBurner("Pan");
            await AddOil();
            await WhiskEggs();
            await Fry();
            await Serve();
            Console.WriteLine($"Time Taken: {stopWatch.ElapsedMilliseconds} ms");;
        }

        private static Task Serve()
        {
            Console.WriteLine($"Serving BreakFast");
            Task.Delay(5000);
            return Task.CompletedTask;
        }

        private static Task Fry()
        {
            Console.WriteLine("Egg Frying");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task WhiskEggs()
        {
            Console.WriteLine("Cracking and Whisk Eggs");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task AddOil()
        {
            Console.WriteLine($"Adding Oil");
            Task.Delay(1000);
            return Task.CompletedTask;

        }

        private static Task CrackEggWhisk()
        {
            Console.WriteLine("Cracking Eggs and Whisking");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task Add(string item)
        {
            Console.WriteLine($"Pouring {item}");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task PutSugarAndMasala()
        {
            Console.WriteLine("Adding Sugar and Tea Masala");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        private static Task GrindTeaMasala()
        {
            Console.WriteLine("Grinding Sugar and Tea Masala");
            Task.Delay(5000);
            return Task.CompletedTask;

        }

        private static Task Boil(string item)
        {
            Console.WriteLine($"Boiling: {item}");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static Task PlaceOnBurner(string item)
        {
            Console.WriteLine($"Placing {item} on Burner");
            Task.Delay(3000);
            return Task.CompletedTask;

        }

        private static Task TurnOnBurner(){
            Console.WriteLine("Turning on Burner");
            Task.Delay(2000);
            return Task.CompletedTask;

        }

        static void ParallelProgramming(){

            Stopwatch stopWatch = new Stopwatch();

            int[] numbers = {20, 10, 12, 13, 14, 16, 18, 23, 21};
            Factorial(1);
            Factorial(2);
            Factorial(3);

            stopWatch.Start();
            //sequential way
            Console.WriteLine("Sequential Program Execution");
            foreach(int num in numbers){
                var res = Factorial(num);
                Console.WriteLine($"{num}! = {res}");
            }
            Console.WriteLine($"Time Taken: {stopWatch.ElapsedMilliseconds} ms");

            stopWatch.Restart();
            //parallel way
            Console.WriteLine("Parallel Program Execution");
            Parallel.ForEach(numbers, num => {
                var res = Factorial(num);
                Console.WriteLine($"{num}! = {res}");
            });
            Console.WriteLine($"Time Taken: {stopWatch.ElapsedMilliseconds} ms");

        }

        static long Factorial(long number)
        {
            Task.Delay(2);
            if (number == 1 || number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

    }


}
