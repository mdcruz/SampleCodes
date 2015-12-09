using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Async
    {
        static void Main() 
        {
        
        }
    }

    class AsyncDemo 
    {
        public async Task PerformAsyncStuff() 
        {
            await Task.Run(() =>
            {
                OpenTxtFile();
            });
        }

        private async Task OpenTxtFile()
        {
            throw new NotImplementedException();
        }
    }
}
