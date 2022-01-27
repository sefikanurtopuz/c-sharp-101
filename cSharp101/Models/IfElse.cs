using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp101.Models
{
    public class IfElse
    {
        public void ifelse()
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time < 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }


            string a = time >= 6 && time <= 11 ? "Günaydın!" : time <= 18 ? "İyi günler!" : "İyi geceler!";
            Console.ReadLine();
        }
    }
}
