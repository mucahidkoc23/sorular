using System;
using System.Collections;

namespace vs2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            string cümle;
            
            Console.WriteLine("cümlenizi yazınız");
            cümle=Console.ReadLine();
            
            Console.WriteLine("Cümledeki kelime sayısı {0},Harf sayısı {1}",cümle.Split(' ').Length,cümle.Length-(Convert.ToInt32(cümle.Split(' ').Length)-1));
            
        }
    }
}
