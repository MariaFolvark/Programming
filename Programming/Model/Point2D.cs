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
                x = Validator.AssertValueInRange(value, 0, 100, nameof(x));
            }
        }
        public double Y
        {
            get { return y; }
            private set
            {
                y = Validator.AssertValueInRange(value, 0, 100, nameof(y));
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void SetX(double x)
        {
            this.X = Validator.AssertValueInRange(x, 0, 100, nameof(x));
        }
        public void SetY(double y)
        {
            this.Y = Validator.AssertValueInRange(y, 0, 100, nameof(y));
        }
    }
}
