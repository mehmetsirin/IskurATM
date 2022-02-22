using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskurATM.Class
{
    class Yönetim
    {
        /*
         para çekme,para yatırma ile bakiye hesaplanacak.
         para birimi önemli
         ana para hesaplanacak.
         */
        Kisi kisi = new Kisi();
        
        public KisiHesap ParaGetir(int id)
        {
            KisiHesap kisiHesap = new KisiHesap();
            foreach (var item in Kisi.kullanicilar)
            {
                if (id==kisi.ID)
                {

                    kisiHesap.miktar = item.bakiye;
                    kisiHesap.paraBirimi = item.paraBirim.ToString();
                    Console.WriteLine("Toplam Bakiyeniz : " + kisi.bakiye);
                    break;           
                }
              
            }
            return kisiHesap;
            
        }
    }
}
