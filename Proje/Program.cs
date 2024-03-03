using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İşlem seçin:");
            while (true)
            {
                Console.WriteLine("1 - Öğrenci Ekle");
                Console.WriteLine("2 - Öğrencileri Göster");
                Console.WriteLine("0 - Çıkış");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Girişi yapılacak öğrenci türünü seçin: 1-Önlisans 2-Lisans 3-Yüksek Lisans");

                        string secim2 = Console.ReadLine();

                        switch (secim2)
                        {
                            case "1":
                                OnLisans onLisans = new OnLisans();
                                onLisans.BilgiAl();
                                break;
                            case "2":
                                Lisans lisans = new Lisans();
                                lisans.BilgiAl();
                                break;
                            case "3":
                                YuksekLisans yuksekLisans = new YuksekLisans();
                                yuksekLisans.BilgiAl();
                                break;
                            default:
                                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Öğrenci Bilgileri:");
                        foreach (var ogrenci in Ogrenci.ogrenciler)
                        {

                            ogrenci.BilgiGoster();
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}

