using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            int UsagPulu = 0;
            float GelirVergisiMeblegi = 0;
            int UsagSayi = 0;
            int AileYardimi = 0;
            float GelirVergisiDerecesi = 0;
            float ElillikVergisiDerecesi = 100;
            int[] manat = { 200, 100, 50, 20, 10, 5, 1 };
            Console.WriteLine("Umumi emek haqqinizi daxil edin");
            float EmekHaqqi = float.Parse(Console.ReadLine());
            float UmumiEmekHaqqi = EmekHaqqi;
            Console.WriteLine("Aile veziyetinizi daxil edin? (Evli),(Subay),(Dul) ");
            string AileVeziyyeti = Console.ReadLine().ToLower();
            if (AileVeziyyeti == "evli" || AileVeziyyeti == "dul")
            {
                Console.WriteLine("Usaqlarin sayini daxil edin?");
                UsagSayi = int.Parse(Console.ReadLine()); https://codeshare.io/new
                if (UsagSayi > 0)
                {
                    UsagPulu = UsagPulu + 30;
                    UmumiEmekHaqqi = UmumiEmekHaqqi + 30;
                }
                if (UsagSayi > 1)
                {
                    UsagPulu = UsagPulu + 25;
                    UmumiEmekHaqqi = UmumiEmekHaqqi + 25;
                }
                if (UsagSayi > 2)
                {
                    UsagPulu = UsagPulu + 20;
                    UmumiEmekHaqqi = UmumiEmekHaqqi + 20;
                }
                if (UsagSayi > 3)
                {
                    int n = UsagSayi - 3;
                    UsagPulu = UsagPulu + (15 * n);
                    UmumiEmekHaqqi = UmumiEmekHaqqi + (15 * n);
                }
            }
            Console.WriteLine("Elilliyiniz varmi? (He) ve ya (Yox) cavabini daxil edin");
            string Elillik = Console.ReadLine().ToLower();
            if (Elillik == "he")
            {
                ElillikVergisiDerecesi = 50;
            }
            if (AileVeziyyeti == "evli")
            {
                AileYardimi = AileYardimi + 50;
                UmumiEmekHaqqi = UmumiEmekHaqqi + AileYardimi;
            }
            if (EmekHaqqi <= 1000)
            {
                GelirVergisiDerecesi = GelirVergisiDerecesi + 15;
                GelirVergisiDerecesi = (GelirVergisiDerecesi * ElillikVergisiDerecesi) / 100;
                GelirVergisiMeblegi = (UmumiEmekHaqqi / 100) * GelirVergisiDerecesi;
            }
            else if (EmekHaqqi <= 2000 && EmekHaqqi > 1000)
            {
                GelirVergisiDerecesi = GelirVergisiDerecesi + 20;
                GelirVergisiDerecesi = (GelirVergisiDerecesi * ElillikVergisiDerecesi) / 100;
                GelirVergisiMeblegi = (UmumiEmekHaqqi / 100) * GelirVergisiDerecesi;
            }
            else if (EmekHaqqi <= 3000 || EmekHaqqi > 2000)
            {
                GelirVergisiDerecesi = GelirVergisiDerecesi + 25;
                GelirVergisiDerecesi = (GelirVergisiDerecesi * ElillikVergisiDerecesi) / 100;
                GelirVergisiMeblegi = (UmumiEmekHaqqi / 100) * GelirVergisiDerecesi;
            }
            else
            {
                GelirVergisiDerecesi = GelirVergisiDerecesi + 30;
                GelirVergisiDerecesi = (GelirVergisiDerecesi * ElillikVergisiDerecesi) / 100;
                GelirVergisiMeblegi = (UmumiEmekHaqqi / 100) * GelirVergisiDerecesi;
            }
            float XalisGelir = UmumiEmekHaqqi - GelirVergisiMeblegi;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Aile Muavineti: {AileYardimi} manat");
            Console.WriteLine($"Usaq pulu: {UsagPulu} manat ");
            Console.WriteLine($"Gelir vergisinin derecesi:{GelirVergisiDerecesi}%");
            Console.WriteLine($"Gelir vergisi meblegi: { GelirVergisiMeblegi.ToString("0.00")}");
            Console.WriteLine($"Umumi emek haqqi:{UmumiEmekHaqqi}");
            Console.WriteLine($"Xalis emek haqqi: {XalisGelir.ToString("0.00")}");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < manat.Length; i++)
            {
                int PulVahidiMiqdari = Convert.ToInt32(Math.Floor(XalisGelir / manat[i]));
                Console.WriteLine($"{manat[i]}. puldan {PulVahidiMiqdari} cixardacag");
                XalisGelir = XalisGelir - (manat[i] * PulVahidiMiqdari);
            }
        }
    }
}