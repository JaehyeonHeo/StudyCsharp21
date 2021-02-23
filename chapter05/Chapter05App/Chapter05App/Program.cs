using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)  //무한 반복문
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine();    //콘솔에서 입력 값을 변수할당 

                if (line == "quit") break;           //quit 입력시 프로그램 종료 

                int number = 0; //int.Parse(line);
                int.TryParse(line, out number);      //TryParse는 에러가 없음 
                //Console.WriteLine(number); 
                if (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("0보다 큰 짝수"); 
                    }
                    else
                    {
                        Console.WriteLine("0보다 큰 홀수"); 
                    }
                }
                else
                {
                    Console.WriteLine("0보다 작은 수"); 
                }
            }

            Console.WriteLine("계산 종료!");  
        }
    }
}
