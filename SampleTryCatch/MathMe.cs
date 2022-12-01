using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTryCatch
{
    public class MathMe
    {
        public int Toplam(string deger1, string deger2)
        {

            int sonuc = 0;
            try
            {
                int sayi1 = Convert.ToInt32(deger1);
                int sayi2 = Convert.ToInt32(deger2);

                sonuc = sayi1 + sayi2;

                

            }
            catch (Exception ex)
            {
                throw ex;      
            }

            return sonuc;
        }
    }
}
