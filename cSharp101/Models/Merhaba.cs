using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101.Models
{
    public class Merhaba
    {
        public void helloWorld()
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("İsim: ");
            string isim= Console.ReadLine();

            Console.WriteLine("Soyisim: ");
            string soyisim= Console.ReadLine();

            Console.WriteLine("Merhaba " + isim + " " + soyisim);

            Console.ReadLine();
        }

    }
}
