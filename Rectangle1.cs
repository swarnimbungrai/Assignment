using System;

namespace AssignmentW4
{
    public class Rectangle
    {
        private float length;
        private float width;


        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        // Method to calculate the area of the rectangle
        public float CalculateArea()
        {
            return length * width;
        }
    }
}
