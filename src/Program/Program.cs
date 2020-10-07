using System;
using System.Collections;
using RideShare;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */


            Passenger passenger1 = new Passenger("Matias", "Ojeda", 12345678, "C:\\Users\\Administrador\\Documents\\GitHub\\ejercicio-start\\Assets\\stephen copy.jpg"); 
            Driver driver1 = new Driver("Bruno", "Villero", 12345678, "C:\\Users\\Administrador\\Documents\\GitHub\\ejercicio-start\\Assets\\tiro al blanco toy story.jpg");
            UcuRideShare rideshare1 = new UcuRideShare();
            rideshare1.AddPassenger(passenger1);
            rideshare1.AddDriver(driver1);
        }
    }
}
