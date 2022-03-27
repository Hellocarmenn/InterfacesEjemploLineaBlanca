using System;
using System.Threading;

namespace EjemplosInterfaces
{
    class Refrigerador:LineaBlanca,IEncender,IApagar
    {
        public Refrigerador()
        {
            Marca = "Mabe";
            Modelo = "2021";
            Console.WriteLine("Marca: {0} ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);
            MostrarEnDisplay();
        }

        public void MostrarEnDisplay()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Refrigerador conectado a la corriente, encendido");
        }
        public static void DarSaludoR()
        {
            Console.WriteLine("Hello, welcome to mabe");
        }
        public void Apagar()
        {
            Console.WriteLine("Turning off refrigerator...");
            for(int i=0;i<5;i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
