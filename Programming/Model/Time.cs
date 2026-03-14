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
                if (value >= 0 && value < 24)
                    hours = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Часы должны быть в диапазоне от 0 до 24.");
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0 && value < 60)
                    minutes = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Минуты должны быть в диапазоне от 0 до 60.");
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0 && value < 60)
                    seconds = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), "Секунды должны быть в диапазоне от 0 до 60.");
            }
        }


    }
}
