using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int v1 = 30, v2 = 40;
            int result = v1 + v2;
            Console.WriteLine("결과 : " + result);*/
            //sbyte 형
            sbyte sbMinval = sbyte.MinValue; 
            sbyte sbMaxval = sbyte.MaxValue;
            Console.WriteLine($"sbyte 최소, 최대값은 {sbMinval}, {sbMaxval} 입니다.");
            //byte 형
            byte Minval = byte.MinValue;
            byte Maxval = byte.MaxValue;
            Console.WriteLine($"byte 최소, 최대값은 {Minval}, {Maxval} 입니다.");
            //short 형
            short shMinval = short.MinValue;
            short shMaxval = short.MaxValue;
            Console.WriteLine($"short의 최소, 최대값은 {shMinval}, {shMaxval} 입니다.");
            //ushort 형
            ushort ushMinval = ushort.MinValue;
            ushort ushMaxval = ushort.MaxValue;
            Console.WriteLine($"ushort의 최소, 최대값은 {ushMinval}, {ushMaxval} 입니다.");
            //int 형
            int iMinval = int.MinValue;
            int iMaxval = int.MaxValue;
            Console.WriteLine($"int의 최소, 최대값은 {iMinval}, {iMaxval} 입니다.");
            //uint 형
            uint uiMinval = uint.MinValue;
            uint uiMaxval = uint.MaxValue;
            Console.WriteLine($"uint의 최소, 최대값은 {uiMinval}, {uiMaxval} 입니다.");
            //long 형
            long loMinval = long.MinValue;
            long loMaxval = long.MaxValue;
            Console.WriteLine($"long의 최소, 최대값은 {loMinval}, {loMaxval} 입니다.");
            //ulong 형
            ulong uloMinval = ulong.MinValue;
            ulong uloMaxval = ulong.MaxValue;
            Console.WriteLine($"ulong의 최소, 최대값은 {uloMinval}, {uloMaxval} 입니다.");

            //float 형
            float fMinval = float.MinValue, fMaxval = float.MaxValue;
            Console.WriteLine($"float 최소, 최대값은 {fMinval}, {fMaxval} 입니다.");
            //double 형 
            double dMinval = double.MinValue, dMaxval = double.MaxValue;
            Console.WriteLine($"double의 최소, 최대값은 {dMinval}, {dMaxval} 입니다.");
            //decimal 형 
            decimal deMinval = decimal.MinValue, deMaxval = decimal.MaxValue;
            Console.WriteLine($"decimal의 최소, 최대값은 {deMinval}, {deMaxval} 입니다.");


        }
    }
}
