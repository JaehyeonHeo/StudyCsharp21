using System;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        public virtual void Initialize()
            // vurtual = 자식클래스에서 재정의 선언
        {
            Console.WriteLine("ArmorSuite 초기화"); 
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("리펄서 레이저 장착"); 
            
        }
    }

    class Warmachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();  // 부모가 가지고 있던 행위 
            Console.WriteLine("Double-Barrel 캐논 장착!");  //새로 추가된 행위 
            Console.WriteLine("Micro-Rocket 런처 장착!");   //새로 추가된 행위 
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            Warmachine machine = new Warmachine();
            machine.Initialize();

            Console.WriteLine("아이언맨 생산");
            IronMan ironman = new IronMan();
            ironman.Initialize(); 

        }
    }
}
