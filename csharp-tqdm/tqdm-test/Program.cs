using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tqdm_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new tqdm();
            
            for(int i = 0; i < 100000000; i++)
            {
                x.progress(i, 100000000);
            }
            x.finish();
            Console.ReadLine();
        }
    }
}
