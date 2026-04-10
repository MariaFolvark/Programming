using Programming.Model.Enums;
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
        private Point2D center;

        public string Name { get { return name; } set { name = value; } }
        public double Length
        {
            get { return length; }
            set
            {
                length = Validator.AssertOnPositiveValue(value, "length");
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                width = Validator.AssertOnPositiveValue(value, "width");
            }
        }
        public string Colour { get { return colour; } set { colour = value; } }
        public Point2D Center { get; set; }
        public Rectangles(string name, double length, double width, string colour, Point2D center)
        {
            this.Name = name;
            this.Length = length;
            this.Width = width;
            this.Colour = colour;
            this.Center = center;
        }
        public Rectangles() { }
        public static Rectangles[] RandomRectanglesArray(int cnt)
        {
            Rectangles[] rectangles = new Rectangles[cnt];
            Random rand = new Random();
            int colorCount = Enum.GetNames(typeof(Colors)).Length;
            for (int i = 0; i < cnt; i++)
            {
                string name = "Rectangle " + (i + 1).ToString();
                double length = 1 + rand.NextDouble() * 19;
                double width = 1 + rand.NextDouble() * 19;
                string randomColor = ((Colors)rand.Next(colorCount)).ToString();
                Point2D center = new Point2D(rand.NextDouble() * 100, rand.NextDouble() * 100);
                rectangles[i] = new Rectangles(name, length, width, randomColor, center);
            }
            return rectangles;
        }


    }
}

/*if (value >= 0)
    length = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Длина прямоугольника не может быть отрицательной");*/
/*if (value >= 0)
    width = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Ширина прямоугольника не может быть отрицательной");*/
