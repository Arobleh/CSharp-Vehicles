using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {

            DataProcessor Data = new DataProcessor();
            string FileLocation = @"C: \Users\AminR\source\repos\Vehicles\Persons.txt";
            string[] TextFileInputs = Data.GetDataFromTextFile(FileLocation);
            List<Vehicle> VehicleList = new List<Vehicle>();
            bool Driving = true;


            foreach (string TextFileInput in TextFileInputs)
            {
                VehicleFactory vehicles = new VehicleFactory();
                int Seats = Convert.ToInt32(Data.ExtractNumberFromString(TextFileInput));
                VehicleList.Add(vehicles.CreateVehicle(Seats));

            }
           
            while (Driving)
            {
                Data.VehicleFuelUsage(VehicleList);
            }
            Console.ReadKey();




        }
    }
}
