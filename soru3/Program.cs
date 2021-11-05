using System;
using System.Collections;

namespace vs2
{
    class Program
    {
        ArrayList Toplam=new ArrayList();
        static void Main(string[] args)
        {
            
            string kelime;
            
            ArrayList Toplam=new ArrayList();
           
            Console.WriteLine("kelimeleri giriniz.");
            
            for ( ; ;)
            {
             kelime=Console.ReadLine();
             
             if(kelime=="cikis")
              {
                Toplam.Sort();
                Console.WriteLine("Kelimeler:");
                
                foreach (var eleman in Toplam)
                {
                    Console.WriteLine(eleman);

                }
           
              }
                Toplam.Add(kelime);
              
            }
            
        }
    }
}
