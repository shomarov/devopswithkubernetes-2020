using System;
using System.IO;
using System.Threading.Tasks;

namespace timestampgenerator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                var timeStamp = DateTime.UtcNow.ToString("o");
                await File.WriteAllTextAsync("/app/files/timestamp.txt", timeStamp);
                await Task.Delay(5000);
            }

        }
    }
}
