using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные песни.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string name = "Undefined";
        /// <summary>
        /// Автор.
        /// </summary>
        private string songwriter = "Undefined";
        /// <summary>
        /// Продолжительность в минутах.
        /// </summary>
        private int duration_in_minutes;

        /// <summary>
        /// Возвращает и задает пункт название.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Возвращает и задает автора.
        /// </summary>
        public string SongWriter { get {  return songwriter; } set {  songwriter = value; } }
        /// <summary>
        /// Возвращает и задает пункт продолжительность в минутах. Значение должно быть положительным.
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
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="songwriter">Автор.</param>
        /// <param name="duration_in_minutes">Продолжительность в минутах.</param>
        public Song(string name, string songwriter, int duration_in_minutes)
        {
            this.Name = name;
            this.SongWriter = songwriter;
            this.DurationInMinutes = duration_in_minutes;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song() { }
    }
}

/*if (value >= 0)
    duration_in_minutes = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Продолжительность фильма не может быть отрицательной.");*/
