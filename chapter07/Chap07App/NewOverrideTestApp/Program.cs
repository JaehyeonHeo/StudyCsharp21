using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다."); 
        }

        public virtual void Move()   // virtual 사용
        {
            Console.WriteLine($"(부모작업) {this.Name}이(가) 이동한다."); 
        }
    }
    class Dog : Mammal
    {
       
       /* public void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 네발로 달린다."); 
        }*/
        public override void Move()
        {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }
    }

    class Human : Mammal
    {
        public new void Move() // new를 사용하면 부모의 메서드 숨긴다.(자식의 메서드만 사용) 
        {
            Console.WriteLine($"{this.Name}이(가) 두발로 이동한다."); 
        }
    }

    class Whale : Mammal
    {
        public override void Move()  // override를 사용하면 부모의 메서드를 재정의 한다. 
        {
            base.Move(); 
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog ppoppi = new Dog();
            ppoppi.Name = "뽀삐"; 
            ppoppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식이"; 
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "고래"; 
            whale.Move(); 

        }
    }
}
