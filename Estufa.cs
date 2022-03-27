using System;
using System.Threading;
namespace EjemplosInterfaces
{
    class Estufa:LineaBlanca,IEncender
    {
        //Constructor
        public Estufa()
        {
            Marca = " Whirlpool";
            Modelo = "2000";

            Console.WriteLine("Marca: {0} ", Marca);
            Console.WriteLine("Modelo: {0} ", Modelo);            
        }

        void IEncender.MostrarEnDisplay()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Lighting burners");            
        }
        public static void DarSaludoE()
        {
            Console.WriteLine("Hello welcome to whirlpool");
        }
        public void Apagar()
        {
            Console.WriteLine("Turning off stove...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
