using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}"); 
            }

            Console.WriteLine("나머지 일처리 계속,,,,,,");



            int x = 108, y = 0;
            int result = 0;
            try
            {
                result = x / y;                         // 예외처리 --> 분모에 0이 오면 안된다.
                Console.WriteLine($"result : {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}"); 
            }

            Console.WriteLine("또, 나머지 일처리 계속.....");

            string strVal = null;
            

            try
            {
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"6번 부터 5개 문자 : {splitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본 문자열이 비어있음.  {ex.Message}"); 
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine($"원본 문자열을 초기화 하세요. {ex.Message}");
            }
            catch  (Exception ex)
            {
                Console.WriteLine($"기타 예외 발생 {ex.Message}"); 
            }
            Console.WriteLine("일처리 또 있음"); 
        }
    }
}
