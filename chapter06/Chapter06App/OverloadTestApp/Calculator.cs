using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기 !");

            int x = Calculator.plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.plus(3.14, 5.6)}");

            Console.WriteLine($"3.14 + 5 = {Calculator.plus(3.14, "5")}");

            int z = Calculator.sum(3, 4, 5);
            Console.WriteLine($"{z}");

            int total = 0;
            total = sum(1, 2, 4, 5);
            Console.WriteLine($"합계는 {total}");

            Console.WriteLine($"10까지의 합은 : {sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}"); 

        }

        
        private static int sum(params int[] args)
        {
            int result = 0; 

            foreach (var arg in args)
            {
                result += arg; 
            }
            return result; 
        }

        

        private static int plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result; 
        }
    }
}
