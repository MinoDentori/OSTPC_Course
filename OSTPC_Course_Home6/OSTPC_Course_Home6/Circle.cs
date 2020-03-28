using System;
using System.Collections.Generic;
using System.Text;

namespace OSTPC_Course_Home6
{
    class Circle : Shape
    {
        private double radius;

        public Circle(): base() {
            radius = GetRadius();
        }
        public Circle(Location location, double radius) : base(location) {
            this.radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            PrintArea(area);
            return area;
        }
        public override double Perimetr() 
        {
            double perimetr = 2 * Math.PI * radius;
            PrintPerimetr(perimetr);
            return perimetr;
        }
        private void PrintArea(double area) {
            Console.WriteLine($"Area of circle with radius {radius}: {area}");
        }
        private void PrintPerimetr(double perimetr)
        {
            Console.WriteLine($"Perimetr of circle with radius {radius}: {perimetr}");
        }


        private double  GetRadius()
        {
            double radius = 0;
            Console.WriteLine("Input radius of circle");
            Console.WriteLine("Radius: ");
            radius = GetSizeOfLine();
            return radius;
        }
        private double GetSizeOfLine()
        {
            try
            {
                double parametrValue = 0;
                parametrValue = double.Parse(Console.ReadLine());
                if (parametrValue <= 0)
                {
                    Console.WriteLine("Line must be greater than 0. Try again");
                    return GetSizeOfLine();
                }
                return parametrValue;

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try again.");
                return GetSizeOfLine();
            }
        }
    }
}
