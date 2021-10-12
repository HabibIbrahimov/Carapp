using System;

namespace Carapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Fuelcar = new Car(40,10,30,"sport");
            Fuelcar.Carpetrol();
            Fuelcar.Mod();
            Fuelcar.Fuel();
            Console.WriteLine("Yaxsi yol");

        }
    }
}
