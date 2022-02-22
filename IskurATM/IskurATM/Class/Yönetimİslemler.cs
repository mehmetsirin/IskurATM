using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskurATM.Class
{
    class Yönetimİslemler
    {
        public static List<Yönetimİslemler> bilanco = new List<Yönetimİslemler>();
        public int kisiId { get; set; }
        public decimal Bakiye { get; set; }
        public string Parabirimi { get; set; }
        public DateTime Zaman { get; set; }
        public bool BilancoEkle(int kisiID,decimal bakiye, string ParaBirimi)
        {
            Yönetimİslemler data = new Yönetimİslemler();
            data.Bakiye = bakiye;
            data.kisiId = kisiID;
            data.Parabirimi = ParaBirimi;
            bilanco.Add(data);
            return true;
        }

    }
}
