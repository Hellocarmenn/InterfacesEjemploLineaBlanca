using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Smartphone : LineaBlanca, IEncender, IApagar
    {
        public Smartphone()
        {
            Marca = "Apple";
            Modelo = "Iphone pro 13 2022";
            Console.WriteLine("Marca: {0}  ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Turning on Iphone, welcome");
        }
        public static void DarSalaudoPhone()
        {
            Console.WriteLine("Hello welcome to apple");
        }
        public void Apagar()
        {
            Console.WriteLine("See you soon....");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
