using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class profileTest
    {
        static void Main(string[] args)
        {
            printProfile("성명건", "010-6683-7732");

            printProfile(null, "010-1111-2222");

            // printProfile(phone: "010-9999-9999", name: "홍길동");
            // printProfile(name : "홍길순", phone : "010-8888-8888");
            printProfile("최백호"); 
        }

        private static void printProfile(string name, string phone = "010-7979-7979")
        {
            // 프로필 출력
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"이름을 정확히 입력하세요!");
                return;   // 호출한 곳으로 돌아간다
            }
            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return; 

        }
    }
}
