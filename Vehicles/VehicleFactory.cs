namespace Vehicles
{
    class VehicleFactory
    {
        public Vehicle CreateVehicle(int Seats) {
            Vehicle result = null;
            if (Seats < 5)
            {
                result = new Motorcycle(250);
            }
            else if (Seats > 5)
            {
                result = new Bus(100);
            }
            else
            {
                result = new Car(200);
            }
            
            return result;
        }
    }
}
