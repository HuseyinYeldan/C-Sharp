using System;

namespace GeometrikSekilCevreFormulleri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geometrik Şekil Çevre Formüllerine Hoşgeldiniz! Lütfen Seçim Yapınız.");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("");
            Baslangic:
            Console.WriteLine("Kare Formülü için '1' yazınız. ");
            Console.WriteLine("Dikdörtgen Formülü için '2' yazınız. ");
            Console.WriteLine("Çember Formülü için '3' yazınız. ");
            Console.WriteLine("Üçgen Formülü için '4' yazınız. ");
            Console.WriteLine("Düzgün Çokgen Formülü için '5' yazınız. ");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("Lütfen seçim yapınız: ");
            int formul = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("");

            const double pi = 3.14;

            if (formul==1)
            {
                Console.Write("Karenizin bir kenar uzunluğunu giriniz: ");
                double karekenaruzunlugu = Convert.ToDouble(Console.ReadLine());

                double kareformul = karekenaruzunlugu * 4;

                Console.WriteLine("Sonuç: " + kareformul);
            }
            else if (formul == 2)
            {
                Dikdörtgen:
                Console.WriteLine("Dikdörtgeninizin kısa olan kenarının uzunluğunu giriniz: ");
                double dikdortgenkisa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dikdörtgeninizin uzun olan kenarının uzunluğunu giriniz: ");
                double dikdortgenuzun = Convert.ToDouble(Console.ReadLine());

                if (dikdortgenkisa>=dikdortgenuzun)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Dikdörtgenin kısa kenarı uzun kenarından yüksek veya eşit bir değere sahip olamaz.");
                    Console.WriteLine("");
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("");
                    goto Dikdörtgen;
                   
                }

                double dikdortgenformul = (dikdortgenkisa * 2) + (dikdortgenuzun * 2);
                Console.WriteLine("Sonuç: " + dikdortgenformul);
            }
            else if(formul == 3)
            {
                Console.WriteLine("Çemberinizin yarı çapını(r) giriniz: ");
                double cemberyaricap = Convert.ToDouble(Console.ReadLine());

                double cemberformul = 2 * pi * cemberyaricap;

                Console.WriteLine("Sonuç: "+cemberformul);
            }
            else if(formul == 4)
            {
                Console.WriteLine("Üçgeninizin ilk kenarını giriniz: ");
                double ucgen1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üçgeninizin iki kenarını giriniz: ");
                double ucgen2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Üçgeninizin üç kenarını giriniz: ");
                double ucgen3 = Convert.ToDouble(Console.ReadLine());

                double ucgenformul = ucgen1 * ucgen2 * ucgen3;

                Console.WriteLine("Sonuç: "+ucgenformul);
            }
            else if(formul == 5)
            {

                Console.WriteLine("Düzgün çokgeninizin kaç kenarı olduğunu giriniz: ");
                double duzguncokgenkenar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Çokgeninizin bir kenarının uzunluğunu giriniz: ");
                double cokgenuzunlugu = Convert.ToDouble(Console.ReadLine());

                double cokgenformul = duzguncokgenkenar * cokgenuzunlugu;

                Console.WriteLine("Sonuç: "+cokgenformul);
            }
            else
            {
                Console.WriteLine("Hatalı Giriş yaptınız!");
                Console.WriteLine("");
                goto Baslangic;
            }

            Console.ReadKey();


        }
    }
}
