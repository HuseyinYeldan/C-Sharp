using System;

namespace PuanHesaplama
{
    class PuanHesaplama
    {
        static void Main(string[] args)
        {

            Console.Write("Ad ve Soyadınızı Giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.Write("Ders İsmini Giriniz: ");
            string dersismi = Console.ReadLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            
            HataliPuan:
            Console.Write("Ödev Puanınızı Giriniz: ");
            double odevpuan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vize Puanınızı Giriniz: ");
            double vizepuan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Puanınızı Giriniz: ");
            double finalpuan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------");

            //Ödev Puanı = %20
            //Vize Puanı = %30 
            //Final Puanı = %50

            double odevsonuc = (odevpuan * 20) / 100;
            double vizesonuc = (vizepuan * 30) / 100;
            double finalsonuc = (finalpuan * 50) / 100;

            double toplampuan = odevsonuc + vizesonuc + finalsonuc;

            Console.WriteLine("");

            if (toplampuan < 50 && toplampuan > 0)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Sayın " + isim + "toplam puanınız: " + toplampuan);
                Console.WriteLine("Malesef " + dersismi + " dersinden kaldınız.");
                Console.WriteLine("---------------------------");
            }
            else if (toplampuan > 50 && toplampuan < 100)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Sayın " + isim + "toplam puanınız: " + toplampuan);
                Console.WriteLine("Tebrikler " + dersismi + " dersini geçtiniz.");
                Console.WriteLine("---------------------------");
            }
            else if (finalpuan > 100)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Hatalı bir giriş yaptınız! Lütfen tekrar deneyiniz!");
                Console.WriteLine("---------------------------");
                goto HataliPuan;
            }
            else if (odevpuan > 100)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Hatalı bir giriş yaptınız! Lütfen tekrar deneyiniz!");
                Console.WriteLine("---------------------------");
                goto HataliPuan;
            }
            else if (vizepuan > 100)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Hatalı bir giriş yaptınız! Lütfen tekrar deneyiniz!");
                Console.WriteLine("---------------------------");
                goto HataliPuan;
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Hatalı bir giriş yaptınız! Lütfen tekrar deneyiniz!");
                Console.WriteLine("---------------------------");
                goto HataliPuan;
            }


            Console.ReadKey();

        }
    }
}
