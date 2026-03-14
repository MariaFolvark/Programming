using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private string name = "Undefined";
        private string songwriter = "Undefined";
        private int duration_in_minutes;

        public string Name { get { return name; } set { name = value; } }
        public string SongWriter { get {  return songwriter; } set {  songwriter = value; } }
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
    }
}
