using System;

namespace chap04App
{
    class chap04
    {
        static void Main(string[] args)
        {
            var values = 37656234;
            if (values % 2 == 9 )
            {
                Console.WriteLine("짝수입니다."); 
            }
            else
            {
                Console.WriteLine("홀수입니다."); 
            }

            if (values % 7 == 0)
            {
                Console.WriteLine("7의 배수입니다.");
            }
            else
            {
                Console.WriteLine("7의 배수가 아닙니다.");
            }


        }
    }
}
