using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Yıldız", "Ender", "Şahika" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[4];
            //isimler[3] = "Halit";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]); burada hata alırız!! Bu yüzden collections'lardan list'i kullanmalıyız.

            //toplu comment satırı için önce ctrl+k sonra ctrl+c' ye bas. Geri almak için önce ctrl+k sonra ctrl+u' ya bas. Comment-Uncomment

            List<string> isimler2 = new List<string> {"Yıldız", "Ender", "Şahika" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Halit");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}
