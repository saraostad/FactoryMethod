using FactoryMethod._1_InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);

    }
}
