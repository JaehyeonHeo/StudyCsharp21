using System;

namespace Chap18App
{
    class StringApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            // 기본 선언 
            string message1 = null;
            Console.WriteLine($"null 문자열 : {message1}.");
            string message2 = "";  // == String.Empty; 
            Console.WriteLine($"빈값 문자열 : {message2}.");
            string oldPath = "C:\\Program Files\\Bandizip";   // 폴더, 파일 경로 
            string newPath = @"C:\Program Files\Bandizip";    // 폴더, 파일 경로 역슬레시 하나만 쓰는 방법 

            String greeting = "Hello world!";
            var temp1 = "Local Variable string"; // 지역변수에만 

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string hello = new string(letters);
            Console.WriteLine($"{hello}");

            string s1 = "hello";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "hello";
            string s4 = s3;
            s3 += "world";
            Console.WriteLine($"{s4}");

            // 한줄 내림 
            string row = "Row1 \r\nRow2 \r\nRow3";
            Console.WriteLine(row);

            Console.WriteLine("-------------------"); 

            string row2 = "Row11 \nRow22 \nRow33";
            Console.WriteLine(row2);

            Console.WriteLine("-------------------"); 
            
            Console.WriteLine("Row111" + Environment.NewLine + "Row222" + Environment.NewLine + "Row333");

            string oldline = "Test " +
                "Test2 " +
                "Test3 ";
            string multiline = @"New test 
                   These are multiline
                   end. ";

            Console.WriteLine(oldline);
            Console.WriteLine(); 
            Console.WriteLine(multiline);


            var book = (lastName: "박", firstName: "상현", title: "이것이 C#이다.", company: "한빛미디어",
                releaseDate: "2018-07-01", price: "30000", page: 812);
            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM월 dd일")} 출간, ");  
            Console.WriteLine($"페이지수 {book.page}, 금액: {book.price:#,###}원");

            Console.WriteLine("문자열 조작(함수사용)");
            string s5 = " Visual C# Express "; // 총 19자리
            Console.WriteLine(s5);            
            Console.WriteLine(s5.Trim()); // 공백 없애기 
            var s6 = s5.Trim();   //공백 없앰 

            Console.WriteLine(s6.Substring(7));   // 문자열 자르기 (문자열시작자리, 표시하는글자갯수)
            Console.WriteLine(s6.Substring(7, 2));

            Console.WriteLine(s6.Replace("C#", "Basic"));  // C#을 Basic으로 바꿈 
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "basic"));

            Console.WriteLine(s6.IndexOf("C"));  // C의 인덱스 ==> 7
            Console.WriteLine(s6.Length);        // 17  (문자갯수)
            Console.WriteLine(s6.ToLower());     // 모두 소문자 
            Console.WriteLine(s6.ToUpper());     // 모두 대문자 

            // null 문자열 빈문자열 
            Console.WriteLine("null 빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty;

            Console.WriteLine(str + nullstr);
            Console.WriteLine(nullstr == emptystr); // False : null과 empty는 다르다 
            
            try
            {
                Console.WriteLine(nullstr.Equals(emptystr));  // 예외발생 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}"); 
            }

            Console.WriteLine(emptystr.Length);
            //Console.WriteLine(nullstr.Length);   ==>   예외 발생 


        }
    }
}
