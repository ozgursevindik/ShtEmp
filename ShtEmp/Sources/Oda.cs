using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShtEmp.Sources
{
    public class Oda
    {
        public int odaNo;
        public int numune_kapasitesi;
        public int anlik_numune_adedi;
        public bool oda_musaitlik = true;

        public Oda()
        {
             
        }

        public string OdaBilgisiVer()
        {
            string sonuc = "Oda No: " + this.odaNo +
                " Num Kapasitesi: " + this.numune_kapasitesi +
                " Anlık Numune: " + this.anlik_numune_adedi +
                " Müsaitlik: " + this.oda_musaitlik;
            return sonuc;
        }
        public void OdayaGir(Insan insan)
        {
            this.oda_musaitlik = false;
        }
    }
}
