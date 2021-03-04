using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{
    // 매인 
    class MainApp
    {
        static void Main(string[] args)
        {
            try // try-catch로 예외처리 
            {
                AddressManager manager = new AddressManager();
                manager.listAddress = new List<AddressInfo>();

                DataFileManger fileManger = new DataFileManger();
                fileManger.ReadData(manager.listAddress);


                while (true)
                {
                    Console.Clear();

                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        case 1:  // 주소입력
                            Console.Clear();
                            manager.InputAddress();
                            break;

                        case 2:  // 주소검색
                            Console.Clear();
                            manager.SearchAddress();
                            break;

                        case 3:  //주소수정
                            Console.Clear();
                            manager.UpdateAddress();
                            break;

                        case 4:  //주소삭제
                            Console.Clear();
                            manager.DeleteAddress();
                            break;

                        case 5:  //주소 전체 출력
                            Console.Clear();
                            manager.PrintAlladdress();
                            break;
                        case 6:  // 프로그램 종료

                            fileManger.WriteData(manager.listAddress);

                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}"); 
                throw;
            }
            
        }




    }
}
