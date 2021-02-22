using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarTestApp
{
    class varTest
    {
        static void Main(string[] args)
        {
         /*var : 코딩을 하다가 데이터 형식을 지정하는데 시간이 많이 들어서 만들어진 형식 
          * (컴파일러가 알아서 바꿔준다) 단, 변환하거나 메서드 사용시 어떤 형식일지 생각하고 있어야함*/
            var i = 100;
            Console.WriteLine($"정수값은 {i}입니다."); 

        }
    }
}
