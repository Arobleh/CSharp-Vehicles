namespace Vehicles
{
    class Bus : Vehicle
    {
        public Bus(int Speed)
        {
            this.Seats = 10;
            this.Wheels = 4;
            this.Fuel = 200;
            this.SpeedKM = Speed;
            this.Usage = 6;
            int Doors = 6;

        }
    }
}
