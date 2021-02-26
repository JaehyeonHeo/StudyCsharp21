using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal //포유류
    {
        public string Name { get; set; }    //Property(프로퍼티) 사용

        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을(를) 키우다"); 
        }
    }

    class Dog : Mammal  //강아지
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name} : 멍멍!!"); 
        }
    }

    class Cat : Mammal  //고양이
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name} : 야옹!!"); 
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog ppoppi = new Dog();
            ppoppi.Name = "강아지";
            ppoppi.Nurse();
            ppoppi.Bark();

            Cat chichi = new Cat();
            chichi.Name = "고양이";
            chichi.Nurse();
            chichi.Meow();


            if (ppoppi is Mammal)   // ppoppi는 Mammal 인가?
            {
                Mammal mammal1 = ppoppi ;  // 참조 형식은 as를 써서 형변환해야한다
                mammal1.Nurse(); 
               // mammal1.Bark();   --> 에러; 안된다 (부모형식으로 형변환했기 때문에 이제 자식클래스에 있는 메소드 사용불가)
            }

            
        }
    }
}
