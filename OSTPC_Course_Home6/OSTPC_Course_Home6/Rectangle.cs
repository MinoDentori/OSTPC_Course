using System;
using System.Collections.Generic;
using System.Text;

namespace OSTPC_Course_Home6
{
  public  class Rectangle : Shape
    {
        private double side1;
        private double side2;
        public Rectangle() : base(){
            var tuple = GetRectangleSides();
            side1 = tuple.Item1;
            side2 = tuple.Item2;

        }
        public Rectangle(Location location, double side1, double side2) : base(location) {
            this.side1 = side1;
            this.side2 = side2;
        }


        public override double Area()
        {
            double area = side1 * side2;
            PrintArea(area);
            return area;
        }
        public override double Perimetr()
        {
            double perimetr = 2*(side1 + side2);
            PrintPerimetr(perimetr);
            return perimetr;
        }
        private void PrintArea(double area)
        {
            Console.WriteLine($"Area of rectangle with sides {side1} and {side2}: {area}");
        }
        private void PrintPerimetr(double perimetr)
        {
            Console.WriteLine($"Perimetr of rectangle with sides {side1} and {side2}: {perimetr}");
        }

        private (double,double) GetRectangleSides()
        {
            double rectangleSide1 = 0;
            double rectangleSide2 = 0;
            Console.WriteLine("Input first side and second side of new rectangle");
            Console.WriteLine("First side: ");
            rectangleSide1 = GetSizeOfLine();
            Console.WriteLine("Second side: ");
            rectangleSide2 = GetSizeOfLine();
            return (rectangleSide1,rectangleSide2);
        }
        private  double GetSizeOfLine()
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
