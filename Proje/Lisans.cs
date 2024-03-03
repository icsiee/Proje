using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Lisans : Ogrenci
    {
        public string LisansTuru { get; set; }

        public override void BilgiAl()
        {
            

            base.BilgiAl(); 

            Console.Write("Lisans Türü: ");
            LisansTuru = Console.ReadLine();
            Console.WriteLine("Öğrenci başarıyla eklendi.");
        }

        public override void BilgiGoster()
        {
            base.BilgiGoster(); 
            Console.Write($", Lisans Türü: {LisansTuru}\n");
        }
    }

}