using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Async
    {
        static void Main() 
        {
            var asyncDemo = new AsyncDemo();
            asyncDemo.PerformAsyncStuff();

            while (true)
            {
                Console.WriteLine("Deadly infinite loop! xD");
            }
        }
    }

    public class AsyncDemo 
    {
        public async Task PerformAsyncStuff() 
        {
            await Task.Run(() =>
            {
                OpenTxtFile();
            });
        }

        private static async Task OpenTxtFile()
        {
            string line;
            string filePath = Tutorials.Properties.Settings.Default.FilePath;

            StreamReader file = new StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            file.Close();
        }
    }
}
