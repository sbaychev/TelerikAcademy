using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    ///Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
    class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)    { }
        public override double CalculateSurface()
        {
            return (this.height * this.width) / 2;
        }
    }
}