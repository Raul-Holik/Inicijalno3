using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno3
{
    internal class Program
    {
        class Vozilo
        {
            bool jeLiLeti, jeLiPlovi;

            public bool JeLiLeti { get => jeLiLeti; set => jeLiLeti = value; }
            public bool JeLiPlovi { get => jeLiPlovi; set => jeLiPlovi = value; }
            public void KudaVozi()
            {
                Console.WriteLine("Jeli leti: " + JeLiLeti + "\n" + "Jeli plovi: " + JeLiPlovi);
            }
        }
        class Brod : Vozilo
        {
            public Brod()
            {
                JeLiPlovi = true;
            }
        }
        class Zrakoplov : Vozilo
        {
            public Zrakoplov()
            {
                JeLiLeti = true;
            }
        }
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();

            Console.WriteLine("Brod");
            brod.KudaVozi();
            Console.WriteLine("Zrakoplov");
            zrakoplov.KudaVozi();

            Console.ReadKey();
        }
    }
}
