using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for (int i = 0; i < 5; i++)    // 예외 발생 지점 : "오류(error)"와는 다르다, 컴파일할때는 모르고 실행하면 알게 된다.
            {
                Console.WriteLine($"{i}번째 값 : {arr[i]}"); 
            }
        }
    }
}
