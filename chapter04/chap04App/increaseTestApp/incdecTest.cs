using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increaseTestApp
{
    class incdecTest
    {
        static void Main(string[] args)
        {
            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}입니다.");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}입니다.");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}입니다.");

            Console.WriteLine($"현재 숫자는 {result++}입니다.");  // 현재라인을 실행시키고 다음줄부터 1이 증가됨 (후치)
            Console.WriteLine($"현재 숫자는 {++result}입니다.");  // 1을 증가시키고 현재라인 실행 (전치)
            
        }
    }
}
