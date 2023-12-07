using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentW4
{
    public class Circle: Shape
    {
        private float radius;
        public Circle(float radius)
        {
            this.radius = radius;
        }

        // Override the CalculateArea method to calculate the area of the circle
        public override float CalculateArea()
        {
            return (float)(Math.PI * radius * radius); // Area = π * r^2
        }
    }
}
