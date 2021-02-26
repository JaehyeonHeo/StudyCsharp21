using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;

            // for문 사용해서 출력 !!
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}"); 
            }

            // foreach문 사용해서 출력 !!
            /*var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }*/

            Console.WriteLine("오름차순 후"); 
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순 후");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");

            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }



            Console.WriteLine("다른배열"); 
            // 좀 더 간결한 배열 
            int[] array2 = { 80, 74, 81, 90, 34 };

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array2[i]}");
            }
            
        }
    }
}
