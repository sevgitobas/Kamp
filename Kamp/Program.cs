using System;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni ürün tanımlama
            Urun urun1 = new Urun();
            urun1.Urun_adi = "Telefon";
            urun1.Urun_fiyati = 1500;

            Urun urun2 = new Urun();
            urun2.Urun_adi = "Tablet";
            urun2.Urun_fiyati = 2650;
            //ürünleri listenin içine atma
            Urun[] urunler = new Urun[] { urun1, urun2 };
            //for döngüsü ile çalıştırma
            for (int i=0; i< urunler.Length; i++) 
            {
                Console.WriteLine(urunler[i].Urun_adi + "'in fiyatı " + urunler[i].Urun_fiyati + " Tl'dir.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("************");
            Console.WriteLine(" ");
            //foreach ile liste elemanları yazdırma
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Urun_adi + "'in fiyatı " + urun.Urun_fiyati + " Tl'dir.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("************");
            Console.WriteLine(" ");
            //while ile liste elemanları yazdırma
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].Urun_adi + "'in fiyatı " + urunler[j].Urun_fiyati + " Tl'dir.");
                j++;
            }
            Console.WriteLine("Hello World!");
        }
    }
    //yeni bir class tanımlama
    class Urun
    {
        public string Urun_adi { get; set; }
        public int Urun_fiyati { get; set; }
    }
}
