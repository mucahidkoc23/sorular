using System;
using System.Collections;

namespace vs2
{
    class Program
    {
        ArrayList Toplam=new ArrayList();
        static void Main(string[] args)
        {
            
            int sayi0;
            int sayi1;
            int sayi2;
            ArrayList Toplam=new ArrayList();
           
            
            Console.WriteLine("iki sayıyı giriniz.");
            sayi1=Convert.ToInt32(Console.ReadLine());
            sayi2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("istediğiniz sayıları giriniz.");

            
            for ( ; ;)
            {
                sayi0=Convert.ToInt32(Console.ReadLine());
                if(sayi0>0)
                 if(sayi0==sayi2 || sayi0%sayi2==0)
                 {
                  Toplam.Add(sayi0);
                 }
   
                if(sayi0<0)
                {
                    Console.WriteLine("lütfen pozitif bir sayı giriniz");
                    continue;
              }
              if(sayi0==0)
              {
                Console.WriteLine("Eşleşen Sayılar:");
                foreach (var eleman in Toplam)
                {
                    Console.WriteLine(eleman);
                }
              }
              
            }
            
        }
    }
}
