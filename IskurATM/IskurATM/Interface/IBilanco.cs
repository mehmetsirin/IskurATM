using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskurATM.Interface
{
   public interface IBilanco
    {
        public int gunSonuOzet(int ID,string isim,string soyad,string tc,decimal bakiye);
    
        public int aySonuRapor();
        


    }
}
