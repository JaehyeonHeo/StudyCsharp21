using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class charTest
    {
        static void Main(string[] args)
        {
            //문자
            char ch1 = 'T', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");
            //문자열
            string str1 = "\tHello, \nworld!";
            /*Console.WriteLine(str1);*/ 
            Console.WriteLine($"{str1}");

            //boolean
            bool isCorrect = false;
            Console.WriteLine(isCorrect); 

            if (isCorrect) 
            {
                Console.WriteLine("참"); 
            }
            else
            {
                Console.WriteLine("거짓"); 
            }

        }
    }
}
