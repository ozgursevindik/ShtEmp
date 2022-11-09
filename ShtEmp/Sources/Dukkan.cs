using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShtEmp.Sources
{
    public class Dukkan
    {
        public int oda_sayisi;
        public int anlik_insan_adedi;
        public List<Oda> odalar = new List<Oda>();
        public List<Insan> insanlar = new List<Insan>(); 
        public void OdalariOlustur()
        {
             
            for (int i = 0; i < oda_sayisi; i++)
            {
                Oda oda = new Oda();
                oda.odaNo = i + 1;
                odalar.Add(oda);
            }

        }

        public void InsanGirdi(Insan insan)
        {
            anlik_insan_adedi++;
            MusaitOdayaGir(insan);
        }

        public void MusaitOdayaGir(Insan insan)
        {
            odalar[1].OdayaGir(insan);
        }
    }
}
