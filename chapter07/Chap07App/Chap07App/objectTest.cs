using System;

namespace Chap07App
{
    class objectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체 사용");
            //고양이 객체의 실체(instance) 생성
            /* Cat cat1 = new Cat();      
             cat1.Name = "야옹이";
             cat1.Color = "흰색";*/
            Cat cat1 = new Cat("야옹이", "흰색"); 
            cat1.Meow();

            Cat kitty = new Cat();
            kitty.Name = "헬로키티";
            kitty.Color = "흰색";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "검고 네로";
            nero.Color = "검은색";
            nero.Meow(); 
        }
    }

    class Cat
    {
        //개체속성
        public Cat()   //사용자 정의 생성자
        {

        }
        
        public Cat(string _name, string _color)
        {
            Name = _name;
            Color = _color;
        }

        public Cat(string _name, string _color, string _gender)
        {
            Name = _name;
            Color = _color;
            Gender = _gender;
        }

        public string Name;
        public string Color;
        public string Gender; 

        //행위속성 
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹"); 
        }
    }
}
