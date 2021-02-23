using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infiniteLoopApp
{
    class infiniteLoop
    {
        static void Main(string[] args)
        {
            // 무한루프
            int idx = 0;
            while (true)
            {
                Console.WriteLine($"idx = {idx++}");
            }

            // break 
            int i = 0; 
            while(i >= 0)
            {
                if (i == 10)
                    break;
                Console.WriteLine($"{i++}");
                

                 

            }
        }
    }
}
