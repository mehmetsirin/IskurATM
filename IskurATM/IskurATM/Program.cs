using IskurATM.Class;
using System;

namespace IskurATM
{
    public class Program
    {


        public static string TC { get; set; }
        public static string sifre { get; set; }

        static void Main(string[] args)
        {
            //Console.WriteLine();
            //adi = Console.ReadLine();
            int sayac = 0;
            while (sayac < 3)
            {

                if (sayac >= 3)
                {
                    Console.WriteLine("3 kez üst üste yanlış giriş yaptınız. Hesabınız bloke edildi.");
                }
                else
                {
                    Console.WriteLine(" kullanici tc ve sifresini giriniz : ");
                    TC = Console.ReadLine();
                    sifre = Console.ReadLine();
                    var control = Login(TC, sifre);
                    if (control == false)
                    {
                        sayac++;
                        if (sayac != 3)
                            Console.WriteLine("Yanlış giriş yaptınız. " + (3 - sayac) + " hakkınız kaldı.");
                    }
                    else
                    {
                        Console.WriteLine("giriş başarılı..");
                    }

                }

            }

            if (sayac >= 3)
            {
                Console.WriteLine("kartınız bloke edildi");
            }
            else
            {
                Console.WriteLine("çıkış işlemi başarılı..");
            }

            Console.ReadLine();

        }


        public static bool Login(string tc, string sifre)
        {

          
            return false;
        }

    }

}
