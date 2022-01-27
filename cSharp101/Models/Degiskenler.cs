using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101.Models
{
    internal class Degiskenler
    {
        //Değişkenler ve Veri Tiplerleri dersi ödevi
        public void Degisken()
        {
            byte a = 1;
            sbyte b = 2;

            short c = 3;
            ushort d = 4;

            Int16 e = 5;
            int f = 6;
            Int32 g = 7;
            Int64 h = 8;

            uint i = 9;
            long j = 10;
            ulong k = 11;

            float l = 12;
            double m = 13;
            decimal n = 14;



            string p = "ab";


            bool r = true;
            bool s = false;

            DateTime dt = DateTime.Now;

            object t = "16";
            object u = "ab";
            object v = 17;
            object y = 18;
            object z = 18.1;


            string abc = string.Empty;
            abc = "deneme";
            string marka = "arçelik";
            string model = "Su ısıtıcısı";

            bool bl = 3 > 5;

            string say1 = "20";
            int say2 = 20;

            string nr = say1 + say2.ToString();
            int son1 = say2 + Convert.ToInt32(say1);

            int son2 = say2 + int.Parse(say1);
        }
    }
}
