using System.ComponentModel.DataAnnotations;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many tires on this vehicle?");

            var amtTires = int.Parse(Console.ReadLine());
            
            var vehicle = VehicleFactory.GetVehicle(amtTires);

            vehicle.Drive();
        }
    }
}
