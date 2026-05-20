using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные фильма.
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Содержит список названий фильмов.
        /// </summary>
        private static string[] movieNames = {
            "Побег из Шоушенка",
            "Крестный отец",
            "Темный рыцарь",
            "Кумир",
            "Форрест Гамп",
            "Начало",
            "Интерстеллар",
            "Бойцовский клуб",
            "Матрица",
            "Леон"
        };
        /// <summary>
        /// Название.
        /// </summary>
        private string title = "Undefined";
        /// <summary>
        /// Продолжительность в минутах.
        /// </summary>
        private int duration_in_minutes;
        /// <summary>
        /// Год выпуска (от 1900 до текущего года).
        /// </summary>
        private int year_of_release;
        /// <summary>
        /// Жанр.
        /// </summary>
        private string genre = "Undefined";
        /// <summary>
        /// Рейтинг (от 0 до 10).
        /// </summary>
        private double rating;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Title { get { return title; } set { title = value; } }
        /// <summary>
        /// Возвращает и задает продолжительность в минутах. Значение должно быть положительным.
        /// </summary>
        public int DurationInMinutes
        {
            get { return duration_in_minutes; }
            set
            {
                duration_in_minutes = Validator.AssertOnPositiveValue(value, nameof(duration_in_minutes));
            }
        }
        /// <summary>
        /// Возвращает и задает год выпуска. Значение должно быть в диапазоне от 1900 до текущего года.
        /// </summary>
        public int YearOfRelease
        {
            get { return year_of_release; }
            set
            {
                int current_year = DateTime.Now.Year;
                year_of_release = Validator.AssertValueInRange(value, 1900, current_year, nameof(year_of_release));
            }
        }
        /// <summary>
        /// Возвращает и задает жанр.
        /// </summary>
        public string Genre { get { return genre; } set { genre = value; } }
        /// <summary>
        /// Возвращает и задает рейтинг. Значение должно быть в диапазоне от 0 до 10.
        /// </summary>
        public double Rating
        {
            get { return rating; }
            set
            {
                rating = Validator.AssertValueInRange(value, 0, 10, nameof(rating));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="title">Название.</param>
        /// <param name="duration_in_minutes">Продолжительность в минутах.</param>
        /// <param name="year_of_release">Год выпуска.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг.</param>
        public Film(string title, int duration_in_minutes, int year_of_release, string genre, double rating)
        {
            this.Title = title;
            this.DurationInMinutes = duration_in_minutes;
            this.YearOfRelease = year_of_release;
            this.Genre = genre;
            this.Rating = rating;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/>.
        /// </summary>
        public Film() { }

        /// <summary>
        /// Создаёт массив фильмов со случайными продолжительностью, годом выпуска и рейтингом.
        /// </summary>
        /// <param name="length">Длина массива.</param>
        /// <returns></returns>
        public static Film[] RandomFilmsArray(int length)
        {
            Film[] movies = new Film[length];
            Random rand = new Random();
            int genreCount = Enum.GetNames(typeof(Genre)).Length;
            for (int i = 0; i < length; i++)
            {
                //string title = movieNames[rand.Next(movieNames.Length)];
                string title = "Film " + (i + 1).ToString();
                int duration = rand.Next(4, 300);
                int year = rand.Next(1900, DateTime.Now.Year + 1);
                string genre = ((Genre)rand.Next(genreCount)).ToString();
                double rating = Math.Round(rand.NextDouble() * 10, 1); // 0.0 - 10.0
                movies[i] = new Film(title, duration, year, genre, rating);
            }
            return movies;
        }
    }
}

/*Random rand = new Random();
int colorCount = Enum.GetNames(typeof(Colors)).Length;
for (int i = 0; i < 5; i++)
{
    string name = "Rectangle " + (i+1).ToString();
    double length = 1 + rand.NextDouble() * 19;
    double width = 1 + rand.NextDouble() * 19;
    string randomColor = ((Colors)rand.Next(colorCount)).ToString();
    _rectangles[i] = new Rectangles(name, length, width, randomColor);
    RectanglesListBox.Items.Add(name);
}*/

/*if (value >= 0)
    duration_in_minutes = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Продолжительность фильма не может быть отрицательной.");*/
/*if (value >= 1900 && value <= current_year)
    year_of_release = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), $"Год выпуска должен быть между 1900 и {current_year}.");*/
/*if (value >= 0 && value <= 10)
    rating = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Рейтинг должен быть между 0 и 10.");*/
