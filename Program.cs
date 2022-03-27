using System;

namespace EjemplosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Forma Explícita de una interfaz
            */
            Estufa.DarSaludoE();
            Estufa miEstufa = new Estufa(); //Instancia de la clase
           IEncender iencender = miEstufa; // Conectar  la estufa  con un tubo flexible a una fuente de gas
            iencender.MostrarEnDisplay(); //Abrir la llave del gas
            miEstufa.Apagar();
          

            Refrigerador.DarSaludoR();// metodo estatico no neceserio para que el refrigerador encienda 
            Refrigerador refrigerador = new Refrigerador();
            refrigerador.Apagar();
           


            Television.DarSalaudotv();
            Television miTelevision = new Television();
            miTelevision.Apagar();
          

     
            Automovil.DarSalaudoA();
            Automovil miAutomovil = new Automovil();
            miAutomovil.Apagar();
          

            Smartphone.DarSalaudoPhone();
            Smartphone miSmartphone = new Smartphone();
            miSmartphone.Apagar();

            Laptop.DarSalaudoLaptop();
            Laptop miLaptop = new Laptop();
            miSmartphone.Apagar();

            Plancha.DarSalaudoPlancha();
            Plancha miPlancha = new Plancha();
            miPlancha.Apagar();


            Console.ReadLine();


        }
    }
}
