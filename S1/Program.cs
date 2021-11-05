using System;
using System.Collections;

namespace vs2
{
    class Program
    {
        ArrayList Toplam=new ArrayList();
        static void Main(string[] args)
        {
            int sayi;
           
            ArrayList Toplam=new ArrayList();
            
            
            Console.WriteLine("İstediğiniz sayıları giriniz.");
            
            for ( ; ;)
            {
                sayi=Convert.ToInt32(Console.ReadLine());
                if(sayi>0)
                 if(sayi%2==0)
                 {
                  Toplam.Add(sayi);
                 }
   
                if(sayi<0)
                {
                    Console.WriteLine("lütfen pozitif bir sayı giriniz");
                    continue;
              }
              if(sayi==0)
              {
                Console.WriteLine("Çift Sayılar :  ");
                foreach (var eleman in Toplam)
                {
                    Console.WriteLine(eleman);
                }
              }
              
            }
            
        }
    }
}
