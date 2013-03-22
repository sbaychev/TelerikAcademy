﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    class Circle : Shape
    {
        //Define class Circle and suitable constructor 
        //so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
        public Circle(double radius) 
            : base(radius, radius)  { }

        public override double CalculateSurface()
        {
            return Math.PI * this.height * this.width;
        }
    }
}