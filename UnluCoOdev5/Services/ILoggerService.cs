using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnluCoWeek5.Services
{
    public interface ILoggerService
    {

        public void Write(string message);
        
    }
    public class ConsoleLogger : ILoggerService
    {
        public void Write(string message)
        {
            Console.WriteLine("[ConsoleLogger]  - " + message);
        }
    }
}
