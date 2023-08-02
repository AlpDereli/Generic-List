// See https://aka.ms/new-console-template for more information
using System;
namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
sayilar.Add(23);
sayilar.Add(10);
sayilar.Add(4);
sayilar.Add(5);
sayilar.Add(92);
sayilar.Add(34);
List<string> renkListesi = new List<string>();
renkListesi.Add("kirmizi");
renkListesi.Add("mavi");
renkListesi.Add("turuncu");
renkListesi.Add("sari");
renkListesi.Add("yesil");
Console.WriteLine(sayilar.Count);
Console.WriteLine(renkListesi.Count);
foreach(var sayi in sayilar)
{
    Console.WriteLine(sayi);
}
renkListesi.ForEach(renk=>Console.WriteLine(renk));
sayilar.Remove(4);
sayilar.ForEach(sayi=>Console.WriteLine(sayi));


//Liste içerisinde arama
if(sayilar.Contains(10))
{
     Console.WriteLine("10 liste içerisinde bulundu!");
}
else
{
    Console.WriteLine("10 liste içerisinde bulunamadi!");
}

//Elaman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("sari"));

//Diziyi List'e çevirme
string[] hayvanlar={"kedi","köpek","kuş"};
List<string>hayvanlarList=new List<string>(hayvanlar);

//Lİsteyi nasıl temizlerim 
hayvanlarList.Clear();

//liste çevresinde nesne tutmak
List<Kullanicilar>kullaniciListesi=new List<Kullanicilar>();
Kullanicilar kullanici1=new Kullanicilar();
kullanici1.Isim="Alp";
kullanici1.Soyisim="dereli";
kullanici1.Yas="20";
kullaniciListesi.Add(kullanici1);

Kullanicilar kullanici2=new Kullanicilar();
kullanici1.Isim="cem";
kullanici1.Soyisim="dereli";
kullanici1.Yas="20";

Kullanicilar kullanici3=new Kullanicilar();
kullanici1.Isim="yusuf emre";
kullanici1.Soyisim="çoban";
kullanici1.Yas="22";

Kullanicilar kullanici4=new Kullanicilar();
kullanici1.Isim="ali hamza";
kullanici1.Soyisim="çoban";
kullanici1.Yas="21";

Kullanicilar kullanici5=new Kullanicilar();
kullanici1.Isim="altan";
kullanici1.Soyisim="cansu";
kullanici1.Yas="19";
kullaniciListesi.Add(kullanici2);
kullaniciListesi.Add(kullanici3);
kullaniciListesi.Add(kullanici4);
kullaniciListesi.Add(kullanici5);
foreach(var kull in kullaniciListesi)
{
    Console.WriteLine(kull.Isim);
    Console.WriteLine(kull.Soyisim);
    Console.WriteLine(kull.Yas);
}
        }
    }
    public class Kullanicilar
    {
        public string Isim;
        public string Soyisim;
        public string Yas;
    }
}