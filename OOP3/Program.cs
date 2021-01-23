using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde onu imp eden classların ref numarasını tutar.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager(); 
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, databaseLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager(); //IKrediManager tipinde parametre vermiştik.
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); 
            //basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService); //yazılımda sürdürebilirliği sağlar.
            //basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLoggerService()); //kullanıcı gitti tasit kredisine tıkladı o zaman bu kod çalışır. böyle de yazılır.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
