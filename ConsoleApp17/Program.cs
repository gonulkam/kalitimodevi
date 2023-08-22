using System;

class AnaUygulama
{
    static void Main(string[] args)
    {
        // Araba ve Kamyon sınıflarından nesneler oluşturuluyor
        Araba otomobil = new Araba();
        otomobil.Marka = "Toyota";
        otomobil.Model = "Corolla";
        otomobil.Yil = 2022;

        // Araba bilgileri ekrana yazdırılıyor, Hizlan metodu çağrılıyor
        Console.WriteLine("Araba: " + otomobil.Marka + " " + otomobil.Model + ", Üretim Yılı: " + otomobil.Yil);
        otomobil.Hizlan();
        otomobil.Yavasla();

        Kamyon kamyonet = new Kamyon();
        kamyonet.Marka = "Volvo";
        kamyonet.Model = "FH16";
        kamyonet.Yil = 2021;

        // Kamyon bilgileri ekrana yazdırılıyor, YukTasi metodu çağrılıyor
        Console.WriteLine("Kamyon: " + kamyonet.Marka + " " + kamyonet.Model + ", Üretim Yılı: " + kamyonet.Yil);
        kamyonet.YukTasi();
    }
}

class Arac
{
    // Marka, Model ve Yil özellikleri tanımlanıyor (get ve set metotları ile)
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
}

class Araba : Arac
{
    // Araba sınıfına ait özel metot, Araba hızlanıyor mesajı ekrana yazdırılıyor
    public void Hizlan()
    {
        Console.WriteLine("Araba hızlanıyor.");
    }
    public void Yavasla()
    {
        Console.WriteLine("Araba yavaslıyor");
    }
}

class Kamyon : Arac
{
    // Kamyon sınıfına ait özel metot, Kamyon yük taşıyor mesajı ekrana yazdırılıyor
    public void YukTasi()
    {
        Console.WriteLine("Kamyon yük taşıyor.");
    }
}
