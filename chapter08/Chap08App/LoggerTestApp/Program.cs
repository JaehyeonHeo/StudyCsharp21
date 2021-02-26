using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTestApp
{
    interface ILogger
    {
        void Writelog(string message); 
    }

    class ConsoleLogger : ILogger
    {
        
        public void Writelog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}"); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("consoleLogger 테스트");
            ConsoleLogger logger = new ConsoleLogger();
            logger.Writelog("로그 메시지"); 

        }
    }
}
