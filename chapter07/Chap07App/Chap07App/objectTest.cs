using System;

namespace Chap07App
{
    class objectTest
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("객체 사용");
            //고양이 객체의 실체(instance) 생성
            *//* Cat cat1 = new Cat();      
             cat1.Name = "야옹이";
             cat1.Color = "흰색";*//*
            Cat cat1 = new Cat("야옹이", "흰색"); 
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로키티";
            kitty.Color = "흰색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "검고 네로";
            nero.Color = "검은색";
            nero.Meow(); */

            Cat yomi = new Cat();
            yomi.Name = "YOMI";
            yomi.Color = "BLACK"; 
            yomi.Gender = "MALE"; 
            yomi.Meow();
        }
    }

    class Cat
    {
        //개체속성
        public Cat(string Name)     //사용자 정의 생성자 --> 기본생성자 만들어줘야한다 
        {
            this.Name = Name;    
        }
        
        public Cat(string Name, string Color) 
        {
            this.Name = Name;        // this 사용 ==> 중복된 생성자 이름을 지칭하기 위해서 사용 
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender)
        {
            this.Name = Name;
            this.Color = Color;
            this.Gender = Gender;
        }

        public Cat()
        {
        }

        public string Name;
        public string Color;
        public string Gender; 

        //행위속성 
        public void Meow()
        {
            Console.WriteLine($"{this.Name} (색상 {this.Color}) / (성별 : {this.Gender}) : 야옹 !"); 
        }
    }
}
