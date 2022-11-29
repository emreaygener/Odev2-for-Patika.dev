using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            for(int i=0;i<sayilar.Length;i++)
            {
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            int[] küçükler={sayilar[0],sayilar[1],sayilar[2]};
            int[] büyükler={sayilar[17],sayilar[18],sayilar[19]};
            int ortküçük=(sayilar[0]+sayilar[1]+sayilar[2])/3;
            int ortbüyük=(sayilar[17]+sayilar[18]+sayilar[19])/3;
            Console.WriteLine("ortküçük");
            Console.WriteLine(ortküçük);
            Console.WriteLine("ortbüyük");
            Console.WriteLine(ortbüyük);
            Console.WriteLine("ortküçük+ortbüyük");
            Console.WriteLine(ortküçük+ortbüyük);
        }
    }
}
