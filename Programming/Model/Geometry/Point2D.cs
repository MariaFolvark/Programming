using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит координаты точки.
    /// </summary>
    internal class Point2D
    {
        /// <summary>
        /// Хранит координату х.
        /// </summary>
        private double x;
        /// <summary>
        /// Хранит координату у.
        /// </summary>
        private double y;

        /// <summary>
        /// Возвращает и задает координату х. Должна быть в диапазоне от 0 до 1000.
        /// </summary>
        public double X
        {
            get { return x; }
            private set
            {
                x = Validator.AssertValueInRange(value, 0, 1000, nameof(x));
            }
        }
        /// <summary>
        /// Возвращает и задает координату у. Должна быть в диапазоне от 0 до 1000.
        /// </summary>
        public double Y
        {
            get { return y; }
            private set
            {
                y = Validator.AssertValueInRange(value, 0, 1000, nameof(y));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата х. Должна быть в диапазоне от 0 до 1000.</param>
        /// <param name="y">Координата у. Должна быть в диапазоне от 0 до 1000.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Задаёт координату х.
        /// </summary>
        /// <param name="x">Координата х.</param>
        public void SetX(double x)
        {
            X = Validator.AssertValueInRange(x, 0, 1000, nameof(x));
        }

        /// <summary>
        /// Задаёт координату у.
        /// </summary>
        /// <param name="y">Координата у.</param>
        public void SetY(double y)
        {
            Y = Validator.AssertValueInRange(y, 0, 1000, nameof(y));
        }
    }
}
