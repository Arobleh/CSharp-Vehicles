using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Vehicles
{
    class DataProcessor
    {
        public string[] GetDataFromTextFile(string FilePath)
        {
            return File.ReadAllLines(FilePath);
        }
        public string ExtractNumberFromString(string TextFileInput)
        {
            string TextFileNumber = Regex.Match(TextFileInput, @"\d+").Value;

            return TextFileNumber;
        }
       public void VehicleFuelUsage(List<Vehicle> vehicleList)
        {
            for (int i = 0; i < vehicleList.Count(); i++)
            {
                if (vehicleList.Count() == 0)
                {
                    continue;
                }

                vehicleList[i].Drive();
                if (vehicleList[i].Fuel <= 0)
                {
                    Console.WriteLine("Vehicle: " + vehicleList[i].GetType().ToString() + ". Out of fuel");
                    vehicleList.RemoveAt(i);
                }
            }
        }
    }
}
