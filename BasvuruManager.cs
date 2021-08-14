using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection (soyut halleri var, somut hallerini enjekte ediyoruz.)
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            //
            //Kredi türü seç
            //Kredi türü hesapla
            krediManager.Hesapla();
            loggerService.Log();

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
