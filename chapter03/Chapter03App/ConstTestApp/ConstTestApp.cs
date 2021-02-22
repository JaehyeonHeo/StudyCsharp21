using System;

namespace ConstTestApp
{
    class ConstTestApp
    {
        enum Season   //열거형
        {
            봄 = 1000,   // 순서값 지정 
            여름 = 2000,
            가을 = 3000, 
            겨울 = 4000
        }

        static void Main(string[] args)
        {
            Console.WriteLine("상수 테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값은 {PI}");
            //PI = 6.345; 

            Season mySeason = Season.여름;
            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            //Null
            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null; 
            Console.WriteLine($"b는 {b}"); 

            

        }
    }
}
