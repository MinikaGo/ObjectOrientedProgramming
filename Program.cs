using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            //ILoggerService databaseLoggerService = new DatabaseLoggerService();
            

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SMSLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers1 = new List<ILoggerService> {databaseLoggerService, smsLoggerService };
            List<ILoggerService> loggers2 = new List<ILoggerService> {fileLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, 
            //    new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() });
            //basvuruManager.BasvuruYap(ihtiyacKrediManager,
            //    new List<ILoggerService> { new DatabaseLoggerService(), new SMSLoggerService() });
            //basvuruManager.BasvuruYap(new TasitKrediManager(),
            //    new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });
            Console.WriteLine("1");
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),
                new List<ILoggerService> { new DatabaseLoggerService(), new SMSLoggerService() });
            Console.WriteLine("2");
            basvuruManager.BasvuruYap(konutKrediManager, loggers1);
            Console.WriteLine("3");
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers2);

            Console.WriteLine("4");
            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
