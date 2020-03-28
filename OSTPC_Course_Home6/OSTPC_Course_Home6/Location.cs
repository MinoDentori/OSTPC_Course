using System;
using System.Collections.Generic;
using System.Text;

namespace OSTPC_Course_Home6
{
   public class Location
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Location()
        {
            var tuple = GetCurrentLocation();
            X = tuple.Item1;
            Y = tuple.Item2;
        }
        public Location(double x, double y) {
            X = x;
            Y = y;
        }

        private  (double,double) GetCurrentLocation()
        {
            double locationX = 0;
            double locationY = 0;
            Console.WriteLine("Input current location of new shape");
            Console.WriteLine("X: ");
            locationX = GetLocationParametr();
            Console.WriteLine("Y: ");
            locationY = GetLocationParametr();
            return (locationX, locationX);
        }

        private  double GetLocationParametr()
        {
            try
            {
                double parametrValue = 0;
                parametrValue = double.Parse(Console.ReadLine());
                return parametrValue;

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again.");
                return GetLocationParametr();
            }
        }
    }
}
