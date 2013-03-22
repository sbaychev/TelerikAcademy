﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    class InvalidRangeException<T> : Exception
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public T StartRange { get; private set; }
        public T EndRange { get; private set; }

        // Constructors
        public InvalidRangeException(T startRange, T endRange)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
        public InvalidRangeException(T startRange, T endRange, string message)
            : base(message)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
        public InvalidRangeException(T startRange, T endRange, string message, Exception innerException)
            : base(message, innerException)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }
    }
}