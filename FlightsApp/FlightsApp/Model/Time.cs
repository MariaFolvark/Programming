using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsApp.Model
{
    /// <summary>
    /// Хранит время.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int hours; //Часы (от 0 до 24)
        /// <summary>
        /// Минуты.
        /// </summary>
        private int minutes; //Минуты (от 0 до 60)
        /// <summary>
        /// Секунды.
        /// </summary>
        private int seconds; //Секунды (от 0 до 60)

        /// <summary>
        /// Возвращает и задает часы. Значение должно быть в диапазоне от 0 до 24.
        /// </summary>
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = Validator.AssertValueInRange(value, 0, 24, nameof(hours));
            }
        }
        /// <summary>
        /// Возвращает и задает минуты. Значение должно быть в диапазоне от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set
            {
                minutes = Validator.AssertValueInRange(value, 0, 60, nameof(minutes));
            }
        }
        /// <summary>
        /// Возвращает и задает секунды. Значение должно быть в диапазоне от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = Validator.AssertValueInRange(value, 0, 60, nameof(seconds));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time() { }
    }
}
