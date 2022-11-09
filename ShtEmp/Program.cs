using ShtEmp.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 

namespace ShtEmp
{
    class Program
    {

        static Dukkan dukkan = new Dukkan();
        static void Main(string[] args)
        {

            string sonuc = YeniKomutAl();
            while (sonuc != "exit")
            {
                switch (sonuc)
                {
                    case "basla":
                        Basla(); 
                        break;

                    case "durum":
                        Durum(); 
                        break;
                    case "deneme":
                        Deneme(); 
                        break;
                    case "musteri":
                        MusteriOlustur();
                        break;
                    case "clear":
                        sonuc = YeniKomutAl();                        
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
                Console.WriteLine(sonuc);
                sonuc = YeniKomutAl();

            }

        }

        private static void MusteriOlustur()
        {
            Insan insan = new Insan();
            insan.tip = Enums.enumInsanTipi.Cocuk;
            dukkan.InsanGirdi(insan);
        }
        private static void Durum()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Anlik İnsan Adedi:" + dukkan.anlik_insan_adedi);
            foreach (var oda in dukkan.odalar)
            {
                sb.AppendLine(oda.OdaBilgisiVer());
            }

            Console.WriteLine(sb.ToString()) ;
            Console.Read();
        }

        static string YeniKomutAl()
        {
            Console.Clear();
            Console.WriteLine("Welcome 2 Sht Emp");
            Console.WriteLine("---------------------");
            Console.WriteLine("Komut Giriniz:");
            string s = Console.ReadLine();
            return s;
        }

        static void Basla()
        {
            dukkan.oda_sayisi = 3;
            dukkan.OdalariOlustur();
            Console.WriteLine("Oyun Başladı");
        }

        static void Deneme()
        {
             
        }
    }
}
