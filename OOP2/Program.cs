﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yıldız";
            musteri1.Soyadi = "Yılmaz";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodalma.io";
            musteri2.VergiNo = "1234567890";

            //SOLID kavramı: Single Responsibility, 
            //               Open/Closed, Liskov Substitution, 
            //               Interface Segregation, Dependency Inversion

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
