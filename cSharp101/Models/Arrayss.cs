using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101.Models
{
    public class Arrayss
    {
        public void arys()
        {
            int[] a = { 7, 4, 5, 89, 34, 67, 45 };
            foreach (var item in a)
                Console.WriteLine(item);
            Console.WriteLine("--------Unsort---------");
            Array.Sort(a);
            foreach (var item in a)
                Console.WriteLine(item);
            Console.WriteLine("---------Sort-------");
            Array.Clear(a, 3, 1);
            foreach (var item in a)
                Console.WriteLine(item);
            Console.WriteLine("---------Clear--------");
            Array.Reverse(a);
            foreach (var item in a)
                Console.WriteLine(item);
            Console.WriteLine("----------Reverse------");
            Console.WriteLine(Array.IndexOf(a, 67));
            Console.WriteLine("-----------IndexOf-------");
            Array.Resize<int>(ref a, 8);
            a[7] = 13;
            foreach (var item in a)
                Console.WriteLine(item);
            Console.WriteLine("-----------Resize-------");
        }
    }
}
