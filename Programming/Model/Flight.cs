using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        private string departure_point = "Undefined"; //Пункт вылета
        private string destination = "Undefined"; //Пункт назначения
        private int flight_time_minutes; //Время полета в минутах

        public string DeparturePoint { get { return departure_point; } set { destination = value; } }
        public string Destination { get { return destination; } set {  destination = value; } }
        public int FlightTimeMinutes
        {
            get { return flight_time_minutes; }
            set
            {
                flight_time_minutes = Validator.AssertOnPositiveValue(value, nameof(flight_time_minutes));
            }
        }
        public Flight(string departure_point, string destination, int flight_time_minutes)
        {
            this.DeparturePoint = departure_point;
            this.Destination = destination;
            this.FlightTimeMinutes = flight_time_minutes;
        }
        public Flight() { }
    }
}

/*if (value >= 0)
    flight_time_minutes = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Время полёта не может быть отрицательным.");*/
