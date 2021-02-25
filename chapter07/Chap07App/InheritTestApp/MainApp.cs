using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class parent
    {
        protected string Name;    // protected를 사용하면 상속받은 클래스에서만 사용가능하다 
        
        public parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자 ");  
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행"); 
        }
    }

    class child : parent
    {
        public child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.child() 생성자"); 
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행"); 
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            parent p = new parent("부모");
            p.ParentMethod();  //부모클래스 메서드 실행
            
            child c = new child("자식");
            c.ParentMethod();  //부모의 메서드 실행
            c.ChildMethod();   //자식클래스 메서드 실행 
        }
    }
}
