using System;

namespace MyProgram
{
    public class Rectangle
    {
        #region Properties
        private double Width { get; set; }

        private double Length { get; set; }
        #endregion

        #region Constructors
        public Rectangle()
        {
            Width = 0;
            Length = 0;
        }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        #endregion

        public double Area()
        {
            return (Width * Length);
        }

        public double Perimeter()
        {
            return ((Width * 2) + (Length * 2));
        }
    }
}
