using System;
using System.Threading;

namespace tqdm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new tqdm();
            x.set_theme_basic();
            for(int i = 0; i < 100; i++)
            {
                x.progress(i, 100);
                Thread.Sleep(50);
            }
            x.finish();
            Console.ReadLine();
        }
    }
}
