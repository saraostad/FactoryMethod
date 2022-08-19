using AbstractFactory._1_Interface;
using AbstractFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new IranKhodroConcret();
            Console.WriteLine("***" + factory.GetType().Name + "***");
            IDiesel diesel = factory.GetDiesel();
            Console.WriteLine(diesel.GetName());
            IMotorCar motorCar = factory.GetMotorCar();
            Console.WriteLine(motorCar.GetName());

            factory = new SaipaConcret();
            Console.WriteLine("***" + factory.GetType().Name + "***");
            diesel = factory.GetDiesel();
            Console.WriteLine(diesel.GetName());
            motorCar = factory.GetMotorCar();
            Console.WriteLine(motorCar.GetName());
            Console.ReadKey();
        }
    }
}
