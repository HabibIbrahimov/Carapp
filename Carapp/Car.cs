using System;
using System.Collections.Generic;
using System.Text;

namespace Carapp
{
    class Car
    {
        public int Depopetrol { get; set; }
        public int DepoLimit { get; set; }
        public double Km { get; set; }
        public string DriveMod { get; set; }
        public int Lt { get; set; }
        
        

        public Car( int depopetrol,double km,int lt,string drivemod)
        {
           Depopetrol = depopetrol;
           DepoLimit = 70;
           Km = km;
           Lt = lt;
           DriveMod = drivemod;
        }

        public void Carpetrol()
        {
            if (Depopetrol==Km || Depopetrol>=Km)
            {
                Depopetrol--;
                Console.WriteLine("Gede biler");
            }
            else
            {
                Console.WriteLine("Gede bilmez");
            }
        }
        public void Mod()
        {
            if (DriveMod=="Eco")
            {
                Console.WriteLine("10lt/100km");
            }
            if (DriveMod=="Sport")
            {
                Console.WriteLine("13lt/100km");
            }
        }
        public void Fuel()
        {
            if (Depopetrol<DepoLimit)
            {
                Depopetrol++;
            }
            else
            {
                Console.WriteLine("Verilen yol gedile bilmez");
            }
        }
        
        
        
        
    }
}
