using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        public int temp ;   //물온도     
        /* internal(빈도 낮음)  
         * public, protected, private (빈도 높음)*/

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60) 
            {
                Console.WriteLine("물온도 이상, 다시 셋팅바립니다. 59도로 맞춥니다");
                this.temp = 59; 
                return; 
            }
            else
            {
                this.temp = 59; 
            }
            this.temp = temp; 
        }
        public int GetTemp()
        {
            return this.temp; 
        }
        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다"); 
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다"); 
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp(); 
                Console.WriteLine($"현재 온도는 {currTemp}℃ 입니다.");
            kitturami.SetTemp(40); 
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler(); 
            }
        }
    }
}
