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
            ILoggerService smsLoggerService = new SMSLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new FilerLoggerService());
            basvuruManager.BasvuruYap(new TasitKrediManager(), new SMSLoggerService());

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), smsLoggerService);

            Console.WriteLine("");
            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
