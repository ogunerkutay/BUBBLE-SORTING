using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUBBLE_SORTING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Değişkenler
            int[] sayilarDizisi = new int[100];
            int degistirenDegisken = 0;

            //Rastgele Elemanlı Dizi Oluşturma
            Random rastgele = new Random();
            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                sayilarDizisi[i] = rastgele.Next(0,10000);
            }

            //Her elamanı ayrı ayrı iterasyonla sıralama N elemanlı bir dizide N² işlem gerektiriyor (Bubble sorting)
            for (int j = 0; j < sayilarDizisi.Length; j++)
            {
                //bir elemanı iterasyonla sıralama N işlem
                for (int i = 0; i < sayilarDizisi.Length-1; i++)
                {
                    if (sayilarDizisi[i] > sayilarDizisi[i + 1])
                    {
                        degistirenDegisken = sayilarDizisi[i + 1];
                        sayilarDizisi[i + 1] = sayilarDizisi[i];
                        sayilarDizisi[i] = degistirenDegisken;
                    }

                }
            }

            //Sıralanan diziyi ekrana yazdırma
            for (int i = 0; i < sayilarDizisi.Length; i++)
            {
                Console.WriteLine(sayilarDizisi[i]);
            }

        
        
        }
    }
}
