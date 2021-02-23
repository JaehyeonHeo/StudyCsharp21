using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringConcatApp
{
    class stringConcat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#숫자,문자열 더하기#"); 
            Console.WriteLine(123 + 456);
            // 문자열이 하나라도 있으면 문자열 결합으로 바뀐다. 
            Console.WriteLine("123" + 456);
            Console.WriteLine($"123{456}");
            Console.WriteLine("123" + "456");

            // 관계연산자 
            Console.WriteLine("#관계연산자#");
            int a = 30, b = 30;
            Console.WriteLine(a > b); //False 
            Console.WriteLine(a < b); //False
            Console.WriteLine(a <= b); //True
            Console.WriteLine(a >= b); //True 
            Console.WriteLine(a == b); //True
            Console.WriteLine(a != b); //False 

            //논리연산자 
            Console.WriteLine("#논리연산자#");
            Console.WriteLine(10 > 9 && a > 0); //True (and)
            Console.WriteLine(a > b || b > 0); //True  (or)
            Console.WriteLine(!(a > b)); //True (not)

            //조건(삼항)연산자 (단항if문을 대체)
            int c = 30;      
            string result = c == 30 ? "삼십" : "삼십아님";  //조건 - true - false
            /*if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/
            Console.WriteLine(result);

            //NULL병합 연산자 
            Console.WriteLine("NULL 병합연산자"); 
            int? d = null;
            Console.WriteLine($"{d ?? 0}");  // NULL값은 출력되지 않는다. 


        }
    }
}
