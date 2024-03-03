using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class OnLisans : Ogrenci
    {
        public string OnLisansTuru { get; set; }

        public override void BilgiAl()
        {
            base.BilgiAl();

            Console.Write("Önlisans Türü: ");
            OnLisansTuru = Console.ReadLine();

            Console.WriteLine("Öğrenci başarıyla eklendi.");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster(); 
            Console.Write($", Önlisans Türü: {OnLisansTuru}\n");
        }
    }

}
