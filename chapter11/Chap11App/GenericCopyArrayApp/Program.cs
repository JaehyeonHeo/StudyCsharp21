using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };  // 5개 int 배열
            int[] target = new int[source.Length];  // 5개 int 배열 초기화

            CoppyArray(source, target);     // int 배열 복사 
            Console.WriteLine("배열복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];

            CoppyArray(source2, target2);
            Console.WriteLine("string 복사");
            foreach (string item in source2)
            {
                Console.WriteLine(item);
            }


        }
        // 일반화 클래스 : <T> 또는 <P> 사용하면 메서드 한개로 모든 타입 반환가능 
        private static void CoppyArray<T>(T[] source, T[] target) 
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
