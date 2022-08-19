using AbstractFactory._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Model
{
    public class IranKhodroConcret : IVehicleFactory
    {
        public IDiesel GetDiesel() { return new Arena(); }
        public IMotorCar GetMotorCar() { return new Peugeot206(); }
    }
}
