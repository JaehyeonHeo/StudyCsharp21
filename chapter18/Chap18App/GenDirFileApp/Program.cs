using System;
using System.IO;

namespace GenDirFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDir = "D:\\DEV\\GitRepository\\StydyCsharp21\\SampleDir"; // 폴더/파일 생성 테스트 폴더 
            string strTargetDir = "SubFolder";  // 생성할 폴더명 
            string strTargetFile = "readme.txt";  // 생성할 파일명

            string targetPath = strDir + "\\" +strTargetDir;     // 실수하기 쉬운 부분 

            if (Directory.Exists(targetPath))
            {
                Console.WriteLine("이미 폴더가 존재합니다");
            }
            else
            {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("폴더를 만들었습니다."); 
            }

            targetPath += $"\\{strTargetFile}";

            if (File.Exists(targetPath))
            {
                Console.WriteLine("파일이 존재합니다");
            }
            else
            {
                File.Create(targetPath).Close();
                Console.WriteLine("파일을 만들었습니다");
            }

        }
    }
}
