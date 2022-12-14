using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ShtEmp.Sources
{
    public class Oda
    {
        Timer t = new Timer();
        public int odaNo;
        public int numune_kapasitesi;
        public int anlik_numune_adedi;
        public bool oda_musaitlik = true;

        public Oda()
        {
            t.Interval = 10000;
            t.Elapsed += T_Elapsed; 
        }
 
        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            oda_musaitlik = true;
            t.Stop();
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
            t.Start();
        }
    }
}
