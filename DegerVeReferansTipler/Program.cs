﻿using System;
namespace DegerVeReferansTipler
{
	class Program
	{
		static void Main(string[] args)
		{

			int sayi1 = 10;
			int sayi2 = 30;
			sayi1 = sayi2;
			sayi2 = 65;
			//sayi1?
			Console.WriteLine(	sayi1 );

			int[] sayilar1 = new int[] { 10, 20, 30 };
			int[] sayilar2 = new int[] { 100, 200, 300 };
			sayilar1  = sayilar2;
			sayilar2[0] = 999;
			//sayiar[0]?
			Console.WriteLine(sayilar1[0]);

			//int desimal flood double bool = değer tip, değer tip değere atılır
			//Array class interface = referans tip,referans adrese atılır
			//Stack heap, değer tip steak te gerçekleşir
			//sayilar1 için new denildiğinde yeni bir heap oluşur, steak ten çıkar heap te kaydedilir artık




		}
	}
}