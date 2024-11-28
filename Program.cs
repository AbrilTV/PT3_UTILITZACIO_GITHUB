using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
        // Crear un objecte Vehicle
        Vehicle vehicle1 = new Vehicle("Model S", "Tesla", 2022, 250.0);

        // Mostrar la informació del vehicle
        vehicle1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle2 = new Vehicle("Mustang", "Ford", 1965, 220.0);
        
        // Mostrar la informació del segon vehicle
        vehicle2.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle3 = new Vehicle("beetle", "Volkswagen", 1938, 220.0);
        
        // Mostrar la informació del segon vehicle
        vehicle3.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Vehicle vehicle4 = new Vehicle("Touran", "Volkswagen", 2003, 250.0);
        
        // Mostrar la informació del segon vehicle
        vehicle4.MostrarInformacio();
    }
}
