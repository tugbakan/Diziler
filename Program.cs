﻿//Dizi Tanımlama 

using System.IO.MemoryMappedFiles;

string[] renkler= new string[5];

string[] hayvanlar={"kedi","köpek","kuş","maymun"};

int[] dizi;
dizi= new int[5];

//Dizilere Değer Atama ve Erişim
renkler[0] = "mavi";

dizi[3]=10;

Console.WriteLine (hayvanlar[1]);
Console.WriteLine (renkler[0]);
Console.WriteLine (dizi[3]);

//Döngülerle Dizi Kullanımı
//Klavyeden girilen n tane sayının ortalamasını alan program

Console.Write("Lütfen dizinin eleman sayısını giriniz:");
int diziUzunlugu= int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz.", i+1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;

foreach (var sayi in sayiDizisi)
        toplam += sayi;

Console.Write("Ortalama=" + toplam/diziUzunlugu);