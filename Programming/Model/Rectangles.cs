using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangles
    {
        private string name = "Undefined";
        private double length; //Длина
        private double width; //Ширина
        private string colour = "Undefined"; //Цвет

        public string Name { get { return name; } set { name = value; } }
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
        public Rectangles(string name, double length, double width, string colour)
        {
            this.name = name;
            this.Length = length;
            this.Width = width;
            this.Colour = colour;
        }
        public Rectangles() { }

    }



}
