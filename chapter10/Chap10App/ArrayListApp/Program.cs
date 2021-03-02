using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);

            Console.WriteLine("50 추가"); 
            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            foreach (var item in array)
            {
                Console.WriteLine($"{item}"); 
            }

            Console.WriteLine("sort이용해서 정렬"); 
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
