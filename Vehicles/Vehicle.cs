namespace Vehicles
{
    public abstract class Vehicle
    {
        public int Seats;
        public int Fuel;
        protected int SpeedKM;
        protected int Wheels;
        protected int Usage; 

        public void Drive()
        {
            Fuel -= Usage; 
        }

    }
}
