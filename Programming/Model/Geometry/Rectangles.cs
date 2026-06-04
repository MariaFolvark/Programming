using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    internal class Rectangles
    {
        /// <summary>
        /// Счётчик количества прямоугольников в программе.
        /// </summary>
        private static int _allRectanglesCount = 0;
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название.
        /// </summary>
        private string name = "Undefined";
        /// <summary>
        /// Длина.
        /// </summary>
        private double length; //Длина
        /// <summary>
        /// Ширина.
        /// </summary>
        private double width; //Ширина
        /// <summary>
        /// Цвет.
        /// </summary>
        private string colour = "Undefined"; //Цвет
        /// <summary>
        /// Координаты центра прямоугольника.
        /// </summary>
        private Point2D center;

        /// <summary>
        /// Задает Уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Возвращает и задает длину. Значение должно быть положительным.
        /// </summary>
        public double Length
        {
            get { return length; }
            set
            {
                length = Validator.AssertOnPositiveValue(value, nameof(length));
            }
        }
        /// <summary>
        /// Возвращает и задает ширину. Значение должно быть положительным.
        /// </summary>
        public double Width
        {
            get { return width; }
            set
            {
                width = Validator.AssertOnPositiveValue(value, nameof(width));
            }
        }
        /// <summary>
        /// Возвращает и задает цвет.
        /// </summary>
        public string Colour { get { return colour; } set { colour = value; } }
        /// <summary>
        /// Возвращает и задает координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangles"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="length">Длина.</param>
        /// <param name="width">Ширина.</param>
        /// <param name="colour">Цвет.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        /// <param name="_id">Уникальный идентификатор.</param>
        public Rectangles(string name, double length, double width, string colour, Point2D center)
        {
            Name = name;
            Length = length;
            Width = width;
            Colour = colour;
            Center = center;
            _allRectanglesCount += 1;
            _id = AllRectanglesCount();
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangles"/>.
        /// </summary>
        public Rectangles()
        {
            _allRectanglesCount += 1;
            _id = AllRectanglesCount();
        }

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями длины, ширины и координат.
        /// </summary>
        /// <param name="minWidth">Минимальное значение ширины.</param>
        /// <param name="maxWidth">Максимальное значение ширины.</param>
        /// <param name="minLength">Минимальное значение длины.</param>
        /// <param name="maxLength">Максимальное значение длины.</param>
        /// <param name="minX">Минимальное значение координаты х.</param>
        /// <param name="maxX">Максимальное значение координаты х.</param>
        /// <param name="minY">Минимальное значение координаты у.</param>
        /// <param name="maxY">Максимальное значение координаты у.</param>
        /// <returns>Возвращает прямоугольник.</returns>
        public static Rectangles RandomRectangle(double minWidth, double maxWidth, double minLength, double maxLength, double minX, double maxX, double minY, double maxY)
        {
            Random rand = new Random();
            int colorCount = Enum.GetNames(typeof(Colors)).Length;

            double width = minWidth + rand.NextDouble() * (maxWidth - minWidth);
            double length = minLength + rand.NextDouble() * (maxLength - minLength);
            string randomColor = ((Colors)rand.Next(colorCount)).ToString();

            minX += width / 2;
            maxX -= width / 2;
            minY += length / 2;
            maxY -= length / 2;

            Point2D center = new Point2D(
                minX + rand.NextDouble() * (maxX - minX),
                minY + rand.NextDouble() * (maxY - minY)
            );

            Rectangles rectangle = new Rectangles("", length, width, randomColor, center);
            return rectangle;
        }

        /// <summary>
        /// Создаёт массив прямоугольников со случайными значениями длины, ширины и координат.
        /// </summary>
        /// <param name="cnt">Длина массива.</param>
        /// <returns>Возвращает массив прямоугольников.</returns>
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

        /// <summary>
        /// Считает количество прямоугольников в программе.
        /// </summary>
        /// <returns>Возвращает количество прямоугольников в программе.</returns>
        public static int AllRectanglesCount()
        {
            return _allRectanglesCount;
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
