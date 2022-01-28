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

            WhileForeach wf = new WhileForeach();
            wf.whileforeach();

            Console.ReadLine();
        }
    }
}
