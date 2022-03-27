using System;

using System.Threading;

namespace EjemplosInterfaces
{
    class Plancha : LineaBlanca, IEncender, IApagar
    {
        public Plancha()
        {
            Marca = "Oster";
            Modelo = "2000";
            Console.WriteLine("Marca: {0}  ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Turning on iron");
        }
        public static void DarSalaudoPlancha()
        {
            Console.WriteLine("Hello, welcome");
        }
        public void Apagar()
        {
            Console.WriteLine("Turning off....");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
