using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap15App
{
    class Profile
    {
        public string Name { get; set; }
        public short Height { get; set; }
    }

    class Product
    {
        public string Title { get; set;  }
        public string Star { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 }; // 10개 배열

            //LinQ를 안쓰는 방법
            /*
             * List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    result.Add(item);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}");
            }
            result.sort();*/


            // LinQ 사용
            var result = from item in numbers
                         where item % 2 == 0
                         orderby item 
                         select item;

            foreach (var item in result)
            {
                Console.WriteLine($"짝수 : {item}"); 
            }

            // 프로필 추가
            List<Profile> profiles = new List<Profile>
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };

            List<Product> products = new List<Product>
            {
                new Product() {Title = "비트", Star = "정우성"},
                new Product() {Title = "CF다수", Star = "김태희"},
                new Product() {Title = "아이리스", Star = "김태희"},
                new Product() {Title = "모래시계", Star = "고현정"},
                new Product() {Title = "솔로예찬", Star = "이문세"}
            }; 

            // LinQ를 이용해서 프로필 출력
            var resProfiles = from item in profiles
                              where item.Height < 175
                              orderby item.Height descending   /* ascending (오름차순), descending(내림차순)*/
                              select item;

            foreach (var item in resProfiles)
            {
                Console.WriteLine($" {item.Name}, {item.Height}cm "); 
            }

            // LinQ를 이용해서 프로필 출력
            var resProfiles2 = from item in profiles
                              where item.Height < 175
                              orderby item.Height ascending   
                              select item.Name;
            foreach (var item in resProfiles2)
            {
                Console.WriteLine($"{item}"); 
            }

            // group by 
            var resProfiles3 = from item in profiles
                               orderby item.Height
                               group item by item.Height < 175 into g
                               select new { 
                                    GroupKey = g.Key, Items = g 
                               };

            foreach (var group in resProfiles3)
            {
                Console.WriteLine($"175cm 미만 그룹 : {group.GroupKey}");

                foreach (var item in group.Items)
                {
                    Console.WriteLine($"    {item.Name}, {item.Height}CM");
                }
            }

            // inner join
            var joinProfiles = from p in profiles
                               join d in products
                               on p.Name equals d.Star
                               select new
                               {
                                   Name = p.Name,
                                   Work = d.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("내부조인 결과");

            foreach (var item in joinProfiles)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}CM"); 
            }

            // outer join 
            var joinProfiles2 = from p in profiles
                               join d in products
                               on p.Name equals d.Star into ps
                               from d2 in ps.DefaultIfEmpty(new Product() { Title = "작품없음"})
                               select new
                               {
                                   Name = p.Name,
                                   Work = d2.Title,
                                   Height = p.Height
                               };
            Console.WriteLine("외부조인 결과");

            foreach (var item in joinProfiles2)
            {
                Console.WriteLine($"이름 : {item.Name}, 작품 : {item.Work}, 키 : {item.Height}CM");
            }

        }
    }
}
