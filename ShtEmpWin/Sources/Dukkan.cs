using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShtEmpWin.Sources
{
    public class Dukkan
    {
        public int oda_sayisi;
        public int anlik_insan_adedi;
        public int Kasa = 0;
        public List<Oda> odalar = new List<Oda>();
        public List<Insan> insanlar = new List<Insan>(); 
        public void OdalariOlustur()
        {

            Oda oda1 = new Oda();
            oda1.odaNo = 1;
            oda1.numune_kapasitesi = 3;
            oda1.numune_bedeli = 10;
            oda1.temizlik_bedeli = 3;
            odalar.Add(oda1);

            Oda oda2 = new Oda();
            oda2.odaNo = 1;
            oda2.numune_kapasitesi = 5;
            oda2.numune_bedeli = 15;
            oda2.temizlik_bedeli = 5;
            odalar.Add(oda2);

            Oda oda3 = new Oda();
            oda3.odaNo = 1;
            oda3.numune_kapasitesi = 8;
            oda3.numune_bedeli = 20;
            oda3.temizlik_bedeli = 6;
            odalar.Add(oda3);


        }

        public void InsanGirdi(Insan insan)
        {
            anlik_insan_adedi++;
            MusaitOdayaGir(insan);
        }

        public void MusaitOdayaGir(Insan insan)
        {
            for (int i = 0; i < oda_sayisi; i++)
            {
                if(odalar[i].oda_musaitlik)
                {
                    odalar[i].OdayaGir(insan);
                    break;
                }
            }
            
        }
    }
}
