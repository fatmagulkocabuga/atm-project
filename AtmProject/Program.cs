using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmProject
{
    class Program
    {

        static void Main(string[] args)
        {
            int bakiye = 800;

            Console.WriteLine("atm'ye hoşgeldiniz");

            Console.WriteLine("lütfen bir işlem seçiniz");

            Console.WriteLine("1-Bakiye görüntüle");
            Console.WriteLine("2-Para çek");
            Console.WriteLine("3-Para yatır");
            Console.WriteLine("4-çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {




                case "1":
                    Console.WriteLine("bakiyeniz : " + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("çekmek istediğiniz tutarı giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                    Console.ReadLine();

                    if (cekilecekTutar > bakiye)
                    {

                        Console.WriteLine("bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();

                    }
                    else
                    {
                        var kalanTutar = (bakiye - cekilecekTutar);
                        Console.WriteLine("kalan tutarınız :" + kalanTutar);
                        Console.ReadLine();


                    }

                    break;

                case "3":

                    Console.WriteLine("yatırmak istediğiniz tutarı giriniz");
                    int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("yeni bakiye :" + (bakiye + yatirilacakTutar));
                    Console.ReadLine();
                    break;

                case "4":

                    break;


                default:
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                    break;



            }







        }
    }
}
