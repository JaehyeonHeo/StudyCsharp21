using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
   /* class Ridable
    {
        public virtual void Ride()  // 부모:virtual, 자식:override
        {
            Console.WriteLine("탈것!"); 
        }
    } */

    interface ICar 
    {
        void Run();

        void Ride(); 
        
    }

    interface IPlane 
    {
        void Fly();

        void Ride(); 
        
    }

    class DroneCar : IPlane, ICar     // 다중상속의 문제점 해결 !!
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!"); 
        }

        public void Ride()                             // Ride가 Iplane, Icar 두 곳에 다 있어도 하나만 구현 ! 
        {                                              //(인터페이스에는 인스턴스가 없기 때문에 상속받은 클래스에서 구현
            Run();
            Fly(); 
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();

        }
    }
}
