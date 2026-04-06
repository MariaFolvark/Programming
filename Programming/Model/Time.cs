using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int hours; //Часы (от 0 до 24)
        private int minutes; //Минуты (от 0 до 60)
        private int seconds; //Секунды (от 0 до 60)
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = Validator.AssertValueInRange(value, 0, 24, nameof(hours));
            }
        }
        public int Minutes
        {
            get { return minutes; }
            set
            {
                minutes = Validator.AssertValueInRange(value, 0, 60, nameof(minutes));
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = Validator.AssertValueInRange(value, 0, 60, nameof(seconds));
            }
        }

        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public Time() { }
    }
}

/*if (value >= 0 && value < 24)
    hours = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Часы должны быть в диапазоне от 0 до 24.");*/
/*if (value >= 0 && value < 60)
    minutes = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Минуты должны быть в диапазоне от 0 до 60.");*/
/*if (value >= 0 && value < 60)
    seconds = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Секунды должны быть в диапазоне от 0 до 60.");*/
