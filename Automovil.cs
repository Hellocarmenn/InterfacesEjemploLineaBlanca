using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Automovil : LineaBlanca, IEncender, IApagar
    {
        public Automovil()
        {
            Marca = "Ford";
            Modelo = "1970";
            Console.WriteLine("Marca: {0}  ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Car on");
        }
        public static void DarSalaudoA()
        {
            Console.WriteLine("Hello, welcome to Ford");
        }
        public void Apagar()
        {
            Console.WriteLine("See you soon ....");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
