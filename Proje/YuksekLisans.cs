using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class YuksekLisans : Ogrenci
    {
        public string YuksekLisansTuru { get; set; }

        public override void BilgiAl()
        {
            
            base.BilgiAl();

            Console.Write("Yüksek Lisans Türü: ");
            YuksekLisansTuru = Console.ReadLine();
            Console.WriteLine("Öğrenci başarıyla eklendi.");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster(); 
            Console.Write($", Yüksek Lisans Türü: {YuksekLisansTuru}\n");
        }
    }
}
