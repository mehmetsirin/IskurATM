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

        public void bilancoZaman(int userID, DateTime date)
        {
            foreach (var item in Yönetimİslemler.bilanco)
            {
                if (item.kisiId == userID && item.Zaman == date)
                {
                    Console.WriteLine(item.Bakiye + item.Zaman.ToString());
                }
            }

        }

    }
}
