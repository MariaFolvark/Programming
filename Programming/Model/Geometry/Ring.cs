using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о кольце.
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Координаты центра кольцаа.
        /// </summary>
        private Point2D center;
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double outer_radius;
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double inner_radius;

        /// <summary>
        /// Возвращает и задает координаты центра кольца.
        /// </summary>
        public Point2D Center { get { return center; } set { center = value; } }
        /// <summary>
        /// Возвращает и задает внешний радиус.
        /// </summary>
        public double OuterRadius
        {
            get { return outer_radius; }
            set
            {
                outer_radius = Validator.AssertValueInRange(value, InnerRadius, 100, nameof(outer_radius));
            }
        }
        /// <summary>
        /// Возвращает и задает внутренний радиус.
        /// </summary>
        public double InnerRadius
        {
            get { return inner_radius; }
            set
            {
                inner_radius = Validator.AssertValueInRange(value, 0.01, OuterRadius, nameof(inner_radius));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="center">Координаты центра кольца.</param>
        /// <param name="outer_radius">Внешний радиус.</param>
        /// <param name="inner_radius">Внутренний радиус.</param>
        public Ring(Point2D center, double outer_radius, double inner_radius)
        {
            Center = center;
            OuterRadius = outer_radius;
            InnerRadius = inner_radius;
        }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }
    }
}
