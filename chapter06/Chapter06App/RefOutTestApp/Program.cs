using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            Divide(a, b, out val, out rem);       // out을 사용 (ref를 사용해도 된다)

            Console.WriteLine($"{a} , {b} : a/b = {val}, a%b = {rem}");
        }

        static void Divide(int a, int b, out int quotient, out int remainder)  // out을 사용 (ref를 사용해도 된다)
        {
            quotient = a / b;
            remainder = a % b;

            return; 
        }
    }
}
