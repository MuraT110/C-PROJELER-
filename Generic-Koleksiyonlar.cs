using System;
using System.Collections.Generic;

namespace Generic-Koleksiyonlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            // System.Collections.Generic
            // T object türündedir.
            // Generic List bir list sınıfı tanımlarken T olarak tip değişkenini alır. 

            // Generic Liste tanımlama ve eleman ekleme
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            // Count - listede elaman sayısı bulma
            Console.WriteLine("*Listede eleman sayısı*");
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            // Foreach ve List.ForEach - listede elemanlara erişim
            Console.WriteLine("*Foreach ve List.ForEach ile elemanlara erişim*");
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            Console.WriteLine("*Listeden nesneye/veriye göre eleman çıkarma ve indexine göre eleman çıkarma*");
            
            // Remove - listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            // RemoveAt - listeden indexine göre eleman çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Contains - liste içerisinde eleman arama
            Console.WriteLine("*Liste içerisinde eleman arama*");
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu!");

            // BinarySearch - eleman ile index'e erişme
            Console.WriteLine("*Eleman ile index'e erişme*");
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            // Diziyi List'e çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // Clear - listeyi temizleme
            hayvanlarListesi.Clear();

            // Liste içerisinde nesne tutma  
            Console.WriteLine("*Liste içerisinde nesne tutma*");
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 20;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            foreach (Kullanicilar kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: " + kullanici.Yas);
            }

            yeniListe.Clear();
        }    
    }
}