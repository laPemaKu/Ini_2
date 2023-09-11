using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_ponavljanje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši te niz znakova.");
            string niz = Console.ReadLine().ToString();
            niz = niz.Replace(" ", "_");
            Console.WriteLine(niz);
            Console.ReadKey();
            
        }
    }
}
