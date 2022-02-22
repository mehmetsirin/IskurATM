using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskurATM.Class
{
    class Yönetim
    {
        Yönetimİslemler yönetimİslemler = new Yönetimİslemler();
        public void ParaTransfer(int gonderenID,int aliciID,decimal miktar)
        {
            Kisi gonderen = new Kisi();
            Kisi alici = new Kisi();
            gonderen = gonderen.KisiBul(gonderenID);
            alici = alici.KisiBul(aliciID);
            if (gonderen.bakiye-miktar<0)
            {
                Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır");
            }
            else
            {
                gonderen.bakiye -= miktar;
                alici.bakiye += miktar;
                Console.WriteLine(gonderen.isim+" Kişisinden "+miktar+" miktar para "+alici.isim+" kişisine transfer edilmiştir.");
                yönetimİslemler.BilancoEkle(gonderenID,gonderen.bakiye,"TL");
            }
        }

        /*
         para çekme,para yatırma ile bakiye hesaplanacak.
         para birimi önemli
         ana para hesaplanacak.
         */

    }
}
