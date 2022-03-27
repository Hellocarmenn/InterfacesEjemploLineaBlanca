using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Television:LineaBlanca,IEncender,IApagar
    {
        public Television()
        {
            Marca = "LG";
            Modelo = "2022";
            Console.WriteLine("Marca: {0}  ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("TV on");
        }
        public static void DarSalaudotv()
        {
            Console.WriteLine("Hello, welcome to LG");
        }
        public void Apagar()
        {
            Console.WriteLine("See you soon....");
            for(int i=0;i<5;i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
