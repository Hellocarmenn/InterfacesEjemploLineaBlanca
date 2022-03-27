using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Laptop : LineaBlanca, IEncender, IApagar
    {
        public Laptop()
        {
            Marca = "Apple";
            Modelo = "Macbook air 2022";
            Console.WriteLine("Marca: {0}  ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Turning on Iphone, welcome");
        }
        public static void DarSalaudoLaptop()
        {
            Console.WriteLine("Hello welcome to apple");
        }
        public void Apagar()
        {
            Console.WriteLine("Turning off macbook....");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
