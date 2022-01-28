using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101.Models
{
    public class WhileForeach
    {
        public void whileforeach()
        {
            Console.WriteLine("Sayı giriniz :");
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            int c = 0;
            while (b <= a)
            {
                c += b;
                b++;
            }
            Console.WriteLine(c / a);
            Console.WriteLine("--------------------------");
            char e = 'a';
            while (e < 'z')
            {
                Console.WriteLine(e);
                e++;

            }
            Console.WriteLine("--------------------------");
            string[] ogrenciler = { "Ali", "Ahmet", "Ayşe", "Aylin" };

            foreach (var i in ogrenciler)
            {
                Console.WriteLine(i);
            }

        }
    }
}
