using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldModule
{
    class Updater
    {
        async public void Start()
        {
            await Task.Run(() => applicationRoutine());
        }

        private async void applicationRoutine()
        {
            while (true)
            {
                Console.WriteLine("sdf");
                await Task.Delay(1000);
            }
        }
    }
}
