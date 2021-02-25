using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{
    interface ILogger
    {
        void WriteLog(string msg); 
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} log : {msg}"); 
        }
    }

    class ClimateLogger 
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger; 
        }
        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력");
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp)  ) break;

                logger.WriteLog($"현재온도 : {temp}"); 

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger Logger = new ConsoleLogger();
            Logger.WriteLog("로그출력1");  // 직접제어

            ClimateLogger clogger = new ClimateLogger(new ConsoleLogger());
            clogger.Start();                // IoC 제어의 역전(역흐름)
        }
    }
}
