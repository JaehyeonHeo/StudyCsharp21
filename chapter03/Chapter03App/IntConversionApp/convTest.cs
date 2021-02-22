using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class convTest
    {
        static void Main(string[] args)
        {
            short shMaxval = short.MaxValue;
            int inCastval = 0;

            inCastval = shMaxval;
            Console.WriteLine($"short값 변환한 int값은 {inCastval}");

            inCastval += 5;
            short shCastval = (short) inCastval;
            Console.WriteLine($"int값을 변환한 short값은 {shCastval}"); //Overflow 

            float flval = 3.141592f; //f or F 써야함 
            inCastval = (int)flval;
            Console.WriteLine($"float값을 변환한 int값은 {inCastval}");
            double dlVal = inCastval;
            Console.WriteLine($"int값을 변환한 double값은 {inCastval}");

            object obj = 20; //Boxing
            int inUnboxingVal = (int) obj; //Unboxing
            Console.WriteLine(inUnboxingVal);

            string strVal = "200";
            int result = int.Parse(strVal) * 3;
            Console.WriteLine($"200 * 3 = {result}"); 

        }
    }
}
