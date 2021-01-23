using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interface derki : benim operasyonlarımı kullanmalısın.arayüz demek yani aşağıdaki şablonu kullan!.interface de genellikle operasyonlar kullanılır.

        //interfaceleri birbirlerinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        void Hesapla();
        void BiseyYap();
    }
}
