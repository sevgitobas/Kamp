using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate ya da legal entity
    //inheritance - burada tüzel müşterinin aynı zamanda müşteri olduğunu yazdık.
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
