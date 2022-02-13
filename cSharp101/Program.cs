using cSharp101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Patika.dev
            // C# 101

            //Main Methodu - Namespace kavramı - System Using Direktifleri - Run dersi ödevi
            //Merhaba merhaba = new Merhaba();
            //merhaba.helloWorld();

            //Try Catch Finally ve Mantıksal Hatalar dersi ödevi
            //TryCacth tc = new TryCacth();
            //tc.trycacth();

            //If-ElseIf-Ternary-If dersi ödevi
            //IfElse ie = new IfElse();
            //ie.ifelse();

            // Switch-Case dersi ödevi
            //SwitchCase sc = new SwitchCase();
            //sc.switchcase();

            //For Loop ve Break Continue Ifadeleri dersi ödevi
            //ForLoop fl = new ForLoop();
            //fl.forloop();

            //While Foreach desi ödevi
            //WhileForeach wf = new WhileForeach();
            //wf.whileforeach();

            //Tanımlama, Erişim ve Döngülerle Dizi Kullanımı dersi ödevi
            //Diziler d = new Diziler();
            //d.diziler();

            //Array Sınıfı Methodları dersi ödevi
            //Arrayss a = new Arrayss();
            //a.arys();

            //Metotlar dersi ödevi
            //int a = 3;
            //int b = 2;
            //int sonuc = a+b;
            //Console.WriteLine(sonuc);

            //Metotlar ornek = new Metotlar();
            //ornek.EkranaYazdir(Convert.ToString(sonuc));

            //int sonuc2 = ornek.ArttirVeTopla(a, b);
            //ornek.EkranaYazdir(Convert.ToString(sonuc2));
            //ornek.EkranaYazdir(Convert.ToString(a + b));


            //Metot Overloading dersi ödevi
            string sayi = "9999";
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            MetotOverloading instance = new MetotOverloading();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            //Metot Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Şefika Nur", "Topuz");
            Console.ReadLine();
        }
    }
}
