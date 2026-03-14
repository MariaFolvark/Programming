using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        private string title = "Undefined"; //Название
        private int duration_in_minutes; //Продолжительность в минутах
        private int year_of_release; //Год выпуска (от 1900 до текущего года)
        private string genre = "Undefined"; //Жанр
        private double rating; //Рейтинг (от 0 до 10)

        public string Title { get { return title; } set { title = value; } }
        public int DurationInMinutes
        {
            get { return duration_in_minutes; }
            set
            {
                if (value >= 0)
                    duration_in_minutes = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Продолжительность фильма не может быть отрицательной.");
            }
        }
        public int YearOfRelease
        {
            get { return year_of_release; }
            set
            {
                int current_year = DateTime.Now.Year;
                if (value >= 1900 && value <= current_year)
                    year_of_release = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), $"Год выпуска должен быть между 1900 и {current_year}.");
            }
        }
        public string Genre { get { return genre; } set { genre = value; } }
        public double Rating
        {
            get { return rating; }
            set
            {
                if (value >= 0 && value <= 10)
                    rating = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Рейтинг должен быть между 0 и 10.");
            }
        }

        public Film(string title, int duration_in_minutes, int year_of_release, string genre, double rating)
        {
            this.Title = title;
            this.DurationInMinutes = duration_in_minutes;
            this.YearOfRelease = year_of_release;
            this.Genre = genre;
            this.Rating = rating;
        }
        public Film() { }

    }
}
