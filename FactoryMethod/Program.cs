// See https://aka.ms/new-console-template for more information
using FactoryMethod._1_InterFace;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        //client
        private static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            IFactory unknow = factory.GetVehicle("unknow");
            unknow.Drive(20);

            Console.ReadKey();

        }
    }

    
}


