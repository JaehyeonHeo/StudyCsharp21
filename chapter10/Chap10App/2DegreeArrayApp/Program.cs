using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2차원 배열

            int[,] arr = new int[2, 3];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            // 위와 동일 (간결하게 쓰는 방법)  ==>   int[,] arr = { {1,2,3},  {4,5,6} };
            

            // 출력
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i} ,{j}] : {arr[i, j]}"); 
                }
                Console.WriteLine(""); 
            }
        }
    }
}
