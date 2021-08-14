using System;

namespace OOP3
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Gönderildi");
        }
    }
}
