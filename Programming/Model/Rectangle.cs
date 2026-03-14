using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double length; //Длина
        private double width; //Ширина
        private string colour = "Undefined"; //Цвет

        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Длина прямоугольника не может быть отрицательной");
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Ширина прямоугольника не может быть отрицательной");
            }
        }
        public string Colour { get { return colour; } set { colour = value; } }
    }
}
