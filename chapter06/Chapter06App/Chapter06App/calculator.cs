using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06App
{
    class calculator
    {
        static void Main(string[] args)
        {

            int x = calculator.plus(3, 4);
            int y = calculator.plus(5, 6);
            int z = calculator.plus(7, 8);

            int rusult = x + y + z;
            Console.WriteLine($"결과는 {rusult}"); 
        }

        private static int plus(int p1, int p2)
        {
            /*throw new NotImplementedException();*/
            //Console.WriteLine("input : {0}, {1}", p1, p2);
            Console.WriteLine($"input : {p1}, {p2}");          //이 방법이 더 편함 
            int result = p1 + p2;
            Console.WriteLine($"output : {result}"); 
            return result;  //return은 호출한 곳으로 돌아가게 하는 함수이다 

        }
    }
}
