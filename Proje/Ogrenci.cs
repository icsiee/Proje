using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private string ogrenciNumarasi; 

        public string OgrenciNumarasi
        {
            get
            {
                if (ogrenciNumarasi.Length <= 3)
                    return ogrenciNumarasi;
                else
                {
                    string gizlenmisKisim = new string('*', ogrenciNumarasi.Length - 3);
                    return ogrenciNumarasi.Substring(ogrenciNumarasi.Length - 3) + gizlenmisKisim;
                }
            }
            set { ogrenciNumarasi = value; }
        }

        public int Yas { get; set; }
        public List<int> Notlar { get; set; }

        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public virtual void BilgiAl()
        {
            Console.Write("Öğrenci Adı: ");
            Ad = Console.ReadLine();

            Console.Write("Öğrenci Soyadı: ");
            Soyad = Console.ReadLine();

            Console.Write("Öğrenci Numarası: ");
            OgrenciNumarasi = Console.ReadLine();

            Notlar = new List<int>(); 
            Console.Write("Not 1: ");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Notlar.Add(not1);

            Console.Write("Not 2: ");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Notlar.Add(not2);

            Console.Write("Not 3: ");
            int not3 = Convert.ToInt32(Console.ReadLine());
            Notlar.Add(not3);

            ogrenciler.Add(this); 

            
        }

        public virtual void BilgiGoster()
        {
            
            Console.Write($"Ad: {Ad}, Soyad: {Soyad}, Öğrenci Numarası: {OgrenciNumarasi}, Notlar: {string.Join(", ", Notlar)}");
        }
    }

}