using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Point2D
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            private set
            {
                x = Validator.AssertValueInRange(value, 0, 100, nameof(value));
            }
        }

        public double Y
        {
            get { return y; }
            private set
            {
                y = Validator.AssertValueInRange(value, 0, 100, nameof(value));
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
