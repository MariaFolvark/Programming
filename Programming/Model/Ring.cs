using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        private Point2D center;
        private double outer_radius;
        private double inner_radius;

        public Point2D Center { get { return center; } set { center = value; } }
        public double OuterRadius { get { return outer_radius; }
            set
            {
                outer_radius = Validator.AssertValueInRange(value, InnerRadius, 100, nameof(outer_radius));
            }
        }
        public double InnerRadius
        {
            get { return inner_radius; }
            set
            {
                inner_radius = Validator.AssertValueInRange(value, 0.01, OuterRadius, nameof(inner_radius));
            }
        }

        public Ring(Point2D center, double outer_radius, double inner_radius)
        {
            Center = center;
            OuterRadius = outer_radius;
            InnerRadius = inner_radius;
        }

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }
    }
}
