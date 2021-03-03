using System;
using System.Text; 
namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            sb[6] = 'N'; // 문자 끼워넣기 : 권장안함 
            sb.Append("My name is Hugo\n");
            sb.Append("I'm 47years old.\n");
            sb.Insert(6, "New");
            sb.Replace("Hugo", "hg"); 

            Console.WriteLine(sb); 

        }
    }
}
