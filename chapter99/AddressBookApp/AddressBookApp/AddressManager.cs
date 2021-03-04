﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    // 기능 클래스
    class AddressManager
    {
        public List<AddressInfo> listAddress;  // ==> 주소록을 담을 컬렉션 

        public void PrintMenu()
        {
            // 화면에 메뉴 출력
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체출력");
            Console.WriteLine("6. 프로그램 종료");
            Console.WriteLine("----------------------------------------");
            Console.Write("메뉴를 선택하세요 >>>>");

        }

        public int SelectMenu()
        {
            // 메뉴 번호 입력
            Console.WriteLine("메뉴를 선택하세요 >>>>");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);
            if (!(result > 0 && result < 7))
            {
                result = 0;
            }
            return result;
        }

        public void InputAddress()
        {
            Console.WriteLine("<<주소 입력>>");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("번호 입력 : ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("빈값은 입력할 수 없습니다");
                Console.ReadLine();
            }
            else
            {
                listAddress.Add(new AddressInfo() { Name = name, Phone = phone, Address = address });
            }
        }


        public void SearchAddress()
        {
            Console.WriteLine("<<주소 검색>>");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;  //찾는 이름이 있는지?

            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    break;   // foreach를 빠져나가는 break;
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine();  // 화면 멈춤 
        }

        public void UpdateAddress()
        {
            Console.WriteLine("<<주소 수정>>");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine("");
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("이름 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone))
                    {
                        Console.WriteLine("빈값은 입력할 수 없습니다");
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                    }

                    break;   // foreach를 빠져나가는 break;
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다");
            }
            Console.ReadLine();
        }
        public void DeleteAddress()
        {
            Console.WriteLine("<<주소 삭제>>");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false;
            foreach (var item in listAddress)
            {
                if (item.Name == name)
                {
                    isFind = true;
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("삭제하시겠습니까? [ Y / N --> 입력 ]");
                    string answer = Console.ReadLine();  // y/n
                    if (answer.ToUpper() == "y")
                    {
                        listAddress.RemoveAt(idx);
                        Console.WriteLine("삭제했습니다");
                    }
                    break;   // foreach를 빠져나가는 break;
                }
                idx++;
            }
            if (isFind == false)
            {
                Console.WriteLine("검색결과가 없습니다");
            }
            Console.ReadLine();
        }
        public void PrintAlladdress()
        {
            Console.WriteLine("<<주소 검색>>");
            Console.WriteLine("----------------------------------------");
            int idx = 0;
            if (listAddress.Count == 0)
            {
                Console.WriteLine("주소록에 내용 없음");
            }
            else
            {
                foreach (var item in listAddress)
                {
                    Console.WriteLine($"[{idx}]-------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"번호 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();
                    idx++;
                }
            }

            Console.ReadLine();
        }
    }
}
