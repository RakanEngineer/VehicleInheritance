using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using static System.Console;
using VehicleInheritance.Domain;


namespace VehicleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] boatVehicleCargo = new Vehicle[30];

            boatVehicleCargo[0] = new Car(
                                    brand: "Tesla",
                                    registrationNumber: "ABC123",
                                    model: "Model 3",
                                    carType: CarType.Sedan);

            boatVehicleCargo[1] = new Truck(
                        brand: "Volvo",
                        registrationNumber: "AAA222",
                        model: "F340",
                        fuelType: FuelType.Diesel,
                        cargoHoldCapacity: 30);

            foreach (Vehicle vehicle in boatVehicleCargo)
            {
                if (vehicle == null) continue;

                WriteLine(vehicle);
            }

            ReadKey(true);
        }
    }
}
