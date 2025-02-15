using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Cotxe vehicle1 = new Cotxe("Model S", "Tesla", 2022, 250.0,4);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle2 = new Cotxe("Mustang", "Ford", 1965, 220.0,2);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle3 = new Cotxe("beetle", "Volkswagen", 1938, 220.0,2);
        
        // Mostrar la informació del segon vehicle
        vehicle3.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe vehicle4 = new Cotxe("Touran", "Volkswagen", 2003, 250.0,2);

        // Crear un nou vehiccle per la edició de fitxers de pa pt3
        Cotxe vehicle5 = new Cotxe("clio", "renaoult", 2002, 250.0,2);
        
        // Mostrar la informació del segon vehicle
        vehicle4.MostrarInformacio();
    }
}
