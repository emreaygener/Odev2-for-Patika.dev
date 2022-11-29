using System;
using System.Collections;
using System.Collections.Generic;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input=0;
            ArrayList liste = new ArrayList();
            ArrayList asallar = new ArrayList();
            ArrayList asalDegiller = new ArrayList();
            Console.WriteLine("Please enter 20 integers.");
            for (int i=0;i<20;i++)
            {
                try
                {
                    input= int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input type, enter integer:");input=int.Parse(Console.ReadLine());
                }
                if(input<0)
                {
                    Console.WriteLine("wrongInputType! Please enter a positive integer: ");
                    input= int.Parse(Console.ReadLine());
                }
                liste.Add(input); //input olmalı !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
            }
            foreach (int item in liste)
            {
                int n=0;
                for(int i=2;i<item;i++)
                {
                    if (item%i==0)    
                        n++;
                }
                if(n==0)
                    asallar.Add(item);
                else    
                    asalDegiller.Add(item);
            }
            asallar.Sort();
            Console.WriteLine("Asal Sayılar");
            foreach (var item in asallar)
            {
                Console.Write(item+" ");
            }
            asalDegiller.Sort();
            Console.WriteLine(" ");
            Console.WriteLine("Asal Olmayan Sayılar");
            foreach (var item in asalDegiller)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Kaç asal var");
            Console.WriteLine(asallar.Count);
            Console.WriteLine("Kaç asal olmayan var");
            Console.WriteLine(asalDegiller.Count);
        }
    }
}
