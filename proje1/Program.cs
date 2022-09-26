using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("girilecek harf sayisi: ");
        int harfSayisi = Convert.ToInt16(Console.ReadLine());
        Console.Write("girilecek rakam sayisi: ");
        int rakamSayisi = Convert.ToInt16(Console.ReadLine());

        string[] harfler = new string[harfSayisi];
        int[] rakamlar = new int[rakamSayisi];

        string harf;
        int rakam;
        Console.Write("----------------------\n");
        Console.WriteLine();
        Console.WriteLine("girilen degerler: ");
        for (int i = 0; i < harfSayisi; i++)
        {
            Console.Write(i + 1 + ". harfi gir: ");
            harf = Console.ReadLine();
            if (harf.Length != 1)
            {
                Console.Write("Tek karakter giriniz!!!\n");
                continue;

            } else
            {
                harfler[i] = harf;
            }
        }
        Console.Write("----------------------\n");
        for (int j = 0; j < rakamSayisi; j++)
        {
            Console.Write(j + 1 + ". rakami gir: ");
            rakam = Convert.ToInt32(Console.ReadLine());
            if (rakam < 10)
            {
                rakamlar[j] = rakam;
                
            }
            else
            {
                Console.Write("9'dan buyuk sayı girilmez!!!\n");
                continue;
            }
        }
        Console.Write("----------------------\n");
        //HashSet
        SortedSet<string> hSetHarf = new SortedSet<string>(harfler);
        SortedSet<int> hSetRakam = new SortedSet<int>(rakamlar);

        Console.Write("Duzenli Hal: \n");
        foreach (var n in hSetHarf)
        {
            Console.Write(n);
        }
        foreach (var n in hSetRakam)
        {
            Console.Write(n);
        }
    }
}

