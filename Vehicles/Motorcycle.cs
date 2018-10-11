namespace Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(int Speed)
        {
            this.Seats = 2;
            this.Wheels = 2;
            this.Fuel = 150;
            this.SpeedKM = Speed;
            this.Usage = 2;

        }
    }
}
