    using System;

namespace OSTPC_Course_Home6
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatingPairsOfShapes();
        }

        public static Rectangle CreateRectangle() {
            Rectangle currentRectangle = new Rectangle();
            return currentRectangle;
        }
        public static Circle CreateCircle() {
            Circle currentCircle = new Circle();
            return currentCircle;
        }
        public static void CreatingPairsOfShapes() {
            string controllWord = "Yes";
            while (controllWord=="Yes") {
                Console.WriteLine("Hi, I want to create some shapes.");
                Console.WriteLine("Let's create a rentangle");
                Rectangle mainRenctengle = CreateRectangle();
                Console.WriteLine("Renctngle created ");
                mainRenctengle.Area();
                mainRenctengle.Perimetr();
                Console.WriteLine("Let's create a circle");
                Circle mainCircle = CreateCircle();
                Console.WriteLine("Circle created ");
                mainCircle.Area();
                mainCircle.Perimetr();
                Console.WriteLine("If you want to create another pair of shapes print 'Yes' else print 'No'");
               controllWord =  Console.ReadLine();
            }
        }
    }
}
