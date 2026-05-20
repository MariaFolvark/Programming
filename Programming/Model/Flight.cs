using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные дисциплины.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        private string departure_point = "Undefined";
        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string destination = "Undefined";
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int flight_time_minutes;

        /// <summary>
        /// Возвращает и задает пункт вылета.
        /// </summary>
        public string DeparturePoint { get { return departure_point; } set { destination = value; } }
        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get { return destination; } set {  destination = value; } }
        /// <summary>
        /// Возвращает и задает Время полета в минутах. Значение должно быть положительным.
        /// </summary>
        public int FlightTimeMinutes
        {
            get { return flight_time_minutes; }
            set
            {
                flight_time_minutes = Validator.AssertOnPositiveValue(value, nameof(flight_time_minutes));
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure_point">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="flight_time_minutes">Время полёта в минутах.</param>
        public Flight(string departure_point, string destination, int flight_time_minutes)
        {
            this.DeparturePoint = departure_point;
            this.Destination = destination;
            this.FlightTimeMinutes = flight_time_minutes;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight() { }
    }
}

/*if (value >= 0)
    flight_time_minutes = value;
else
    throw new ArgumentOutOfRangeException(nameof(value), "Время полёта не может быть отрицательным.");*/
