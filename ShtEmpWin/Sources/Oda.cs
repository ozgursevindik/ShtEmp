using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ShtEmpWin.Sources
{
    public class Oda
    {
        Timer t = new Timer();
        public int odaNo;
        public int numune_kapasitesi=5;
        public int anlik_numune_adedi;
        public bool oda_musaitlik = true;
        public int numune_bedeli;
        public int temizlik_bedeli;

        public Oda()
        {
            t.Interval = 1000;
            t.Elapsed += T_Elapsed; 
        }
 
        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {            
            Program.dukkan.anlik_insan_adedi--;
            
            oda_musaitlik = true;
            if (numune_kapasitesi==anlik_numune_adedi)
            {
                oda_musaitlik = false;
            } 


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
            this.anlik_numune_adedi++;
            Program.dukkan.Kasa = Program.dukkan.Kasa + numune_bedeli;
            t.Start();
        }

        public void Temizle()
        {
            this.oda_musaitlik = true;
            this.anlik_numune_adedi=0;
            Program.dukkan.Kasa = Program.dukkan.Kasa - temizlik_bedeli;
        }
    }
}
