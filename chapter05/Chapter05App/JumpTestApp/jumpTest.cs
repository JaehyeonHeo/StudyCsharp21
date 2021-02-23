using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpTestApp
{
    class jumpTest
    {
        static void Main(string[] args)
        {
            //점프문 break
            for (int i = 0; i < 10; i++)
            {
                if (i == 3) break;
                Console.WriteLine(i);
            }


        }
    }
}
