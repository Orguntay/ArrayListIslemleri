using System;
using System.Collections;
using System.Threading;

namespace ArrayListIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devamMi = true;
            ArrayList degerler = new ArrayList();
            do
            {
                Console.Clear();
                for (int i = 0; i < degerler.Count; i++)
                {
                    Console.WriteLine("{0}. Değer : {1}", i + 1, degerler[i]);
                }
                Console.WriteLine();
                Console.WriteLine("1 Değer ekle");
                Console.WriteLine("2 Değer düzenle");
                Console.WriteLine("3 Değer sil");
                Console.WriteLine("4 Değer listele");
                Console.WriteLine("5 Değer ara");
                Console.WriteLine("6 Değer çıkış");
                Console.Write("Seçiminiz : ");
                int secim = int.Parse(Console.ReadLine());


                switch (secim)
                {
                    case 1: // Ekle 
                        Console.Write("Eklenecek Değeri giriniz : ");
                        degerler.Add(Console.ReadLine());
                        break;
                    case 2: // Düzenle
                        Console.Write("Düzenlenecek Değeri giriniz : ");
                        int degerIndex = degerler.IndexOf(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Yeni Değeri giriniz : ");
                        degerler[degerIndex] = Console.ReadLine();
                        break;
                    case 3: // Sil
                        Console.Write("Silinecek Değeri giriniz : ");
                        degerler.Remove(Console.ReadLine());
                        break;
                    case 4: // Listele
                        Console.WriteLine("Değerler Listesi");
                        for (int i = 0; i < degerler.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer : {1}", i + 1, degerler[i]);
                        }
                        Thread.Sleep(2000);
                        break;
                    case 5: // Ara
                        Console.Write("Aranacak Değeri giriniz : ");
                        bool varMi = degerler.Contains(Console.ReadLine());
                        Console.WriteLine("Aranan değer {0} ", varMi ? "var." : "yok.");
                        Thread.Sleep(2000);
                        break;
                    case 6: // Çıkış
                        Console.Write("Çıkış Yapılıyor... ");
                        devamMi = false;
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Seçim 1-6 aralığında olmalı...");
                        Thread.Sleep(2000);
                        break;
                }

            } while (devamMi);
        }
    }
}
