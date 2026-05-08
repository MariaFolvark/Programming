using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
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
                x = Validator.AssertValueInRange(value, 0, 1000, nameof(x));
            }
        }
        public double Y
        {
            get { return y; }
            private set
            {
                y = Validator.AssertValueInRange(value, 0, 1000, nameof(y));
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void SetX(double x)
        {
            X = Validator.AssertValueInRange(x, 0, 1000, nameof(x));
        }
        public void SetY(double y)
        {
            Y = Validator.AssertValueInRange(y, 0, 1000, nameof(y));
        }
    }
}
