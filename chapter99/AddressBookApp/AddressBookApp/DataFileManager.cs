using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AddressBookApp
{
    class DataFileManger
    {
        // 텍스트 파일에서 저장된 주소록을 불러온다(로드)
        //D:\DEV\GitRepository\StudyCsharp21\chapter99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1  ==> 현재 실행파일 주소
        const string dataFileName = "address.dat";

        public void ReadData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 생성
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp잘라서 manager.listAddress 할당 
                string[] splits = temp.Split("|");
                param.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();
        }
        public void WriteData(List<AddressInfo> param)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 생성
            /* 담겨있는 주소록 데이터를 파일에 저장한다. ==> 실행파일과 같은 폴더에 있어야함 */
            StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (param.Count > 0)
            {
                foreach (var item in param)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close();
        }
    }
}
