using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassApp
{
    partial class myclassss
    {
        public void method1() { Console.WriteLine("Method1"); }
        public void method2() { Console.WriteLine("Method2"); }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            myclassss Method1 = new myclassss();
            Method1.method1();
            Method1.method2(); Method1.method3(); Method1.method4();
            myclassss Method2 = new myclassss();
            Method2.method2();
        }

    }
}
