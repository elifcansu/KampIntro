using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate-kurumsal
    //miras inheritance
    class TuzelMusteri:Musteri //varlık-entity demek bunlar özellik olur burada hep operasyon olmaz //tuzel musteri bir musteridir demek bu.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
