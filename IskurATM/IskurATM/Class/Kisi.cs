using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskurATM.Class
{
    public class Kisi
    {
        public static List<Kisi> kullanicilar = new List<Kisi>();
        private static int newID = 0;
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public decimal bakiye { get; set; }
        

        public Kisi(string isim, string soyad, string tc, decimal bakiye)
        {
            this.ID = CreateNewID();
            this.isim = isim;
            this.soyad = soyad;
            this.tc = tc;
            this.bakiye = bakiye;
            kullanicilar.Add(this);
        }

        public Kisi(string isim, string soyad, string tc)
        {
            this.ID = CreateNewID();
            this.isim = isim;
            this.soyad = soyad;
            this.tc = tc;
            this.bakiye = 1000;
            kullanicilar.Add(this);
        }

        private int CreateNewID()
        { newID++;

            return newID;
        }

        public Kisi KisiBul(int kisiID)
        {   
            foreach(Kisi kisi in kullanicilar)
            {
                if(kisiID == kisi.ID)
                {
                    return kisi;
                }
            }
            return null;
        }

        public bool ParaCek(decimal tutar , int ID)
        {
            Kisi kisi = KisiBul(ID);
            if(kisi != null)
            {
                kisi.bakiye -= tutar;
                return true;
            }
            return false;
        
        }


        
    }
}
