using System;
using System.Collections.Generic;
using System.Text;

namespace OSTPC_Course_Home6
{
   public abstract class Shape
    {
        public Location Location { get; set; }

        public Shape(){
            Location = new Location();
        }
        public Shape(Location location) {
            Location = location;
        }
        public abstract double Area();
        public abstract double Perimetr();
 

    }
}
