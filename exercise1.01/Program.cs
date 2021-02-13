using System;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var randomString = Guid.NewGuid().ToString();

            while (true)
            {
                Console.WriteLine($"{DateTime.UtcNow.ToString("o")} {randomString}");
                await Task.Delay(5000);
            }
        }
    }
}
