using System;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            if (args.Length > 0){
                
            }
            int counter = 1;
            while (true)
            {
                Console.WriteLine(counter);
                counter += 1;
                await Task.Delay(1000);
            }
        }
    }
}
