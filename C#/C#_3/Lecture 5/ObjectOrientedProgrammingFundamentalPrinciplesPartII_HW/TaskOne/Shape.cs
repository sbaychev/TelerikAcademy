using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    ///Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
    abstract class Shape
    {
        protected double width;
        protected double height;

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public abstract double CalculateSurface();
    }
}
