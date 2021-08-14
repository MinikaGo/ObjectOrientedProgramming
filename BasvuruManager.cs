using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection (soyut halleri var, somut hallerini enjekte ediyoruz.)
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgileri değerlendirme
            //
            //Kredi türü seç
            //Kredi türü hesapla
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
