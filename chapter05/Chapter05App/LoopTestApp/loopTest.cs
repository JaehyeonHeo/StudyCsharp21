using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class loopTest
    {
        static void Main(string[] args)
        {
            //while 문
            Console.WriteLine("while문 처리");
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine($"숫자는 {a}");
                a--; 
            }
            Console.WriteLine("출력 종료");





            //Do-while 문
            Console.WriteLine("do,while문 처리"); 
            do
            {
                Console.WriteLine($"숫자 {a}");
                a++; 
            } while (a <= 10);
            Console.WriteLine("출력종료 !");






            //for 문
            Console.WriteLine("for문 처리"); 
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("출력종료!");






            //중첩 for문 (구구단)
            Console.WriteLine("구구단 시작!");
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"{i}단 시작"); 
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}"); 
                }
            }

            
        }
    }
}
