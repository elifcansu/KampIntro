using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection oluyor bu yazdığımız.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) //BURAYA NE GÖNDERİRSEM ONUN KREDİSİ HESAPLANIR.
        {
            //Başvuran bilgilerini değerlendirme gibi gibi işler yapılır burada
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //tüm başvuruaları konut kredisine bağımlı yaparsın böyle yaparsan doğru değil.
            krediManager.Hesapla();
            foreach (var loggers in loggerServices)
            {
                loggers.Log();
            }//HANGİ LOGLAYICI SEÇİLMİŞSE ONU LOGLA DİYORUZ.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler) //her bir kredinin hesaplamasını yap
            {
                kredi.Hesapla();
            }
        }
    }
}
