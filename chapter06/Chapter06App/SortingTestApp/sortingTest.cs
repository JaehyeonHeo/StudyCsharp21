using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class sortingTest
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before swap {x}, {y}"); 

            sortingTest.swap(ref x, ref y);                  // "ref"를 사용하면 값의 "메모리 주소"를 사용한다 

            Console.WriteLine($"After swap {x}, {y}"); 
        }

        private static void swap(ref int p1, ref int p2)
        {
            int temp = p1;      // temp : 47
            p1 = p2;            // p1 = 5, p2 =5 
            p2 = temp;          // p2 = 47
        }

    }
}
