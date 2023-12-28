using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int amtTires)
        {

            if (amtTires == 4)
            {
                //create an instance of car
                return new Car();
            }
            else if (amtTires == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return new Car();
            }
                
                
                



        }
    }
}
