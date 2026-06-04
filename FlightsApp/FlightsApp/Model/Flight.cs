using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightsApp.Model
{
    /// <summary>
    /// Хранит данные дисциплины.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Счётчик количества рейсов в программе.
        /// </summary>
        private static int _allFlightsCount = 0;
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название.
        /// </summary>
        private string name = "Undefined";
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        private string departure = "Undefined";
        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string destination = "Undefined";
        /// <summary>
        /// Время прибытия.
        /// </summary>
        private Time departure_time = new Time();
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private Time flight_time = new Time();
        /// <summary>
        /// Тип рейса: внутренний/международный.
        /// </summary>
        private string flight_type = "Undefined";

        /// <summary>
        /// Задает Уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Возвращает и задает пункт вылета.
        /// </summary>
        public string Departure { get { return departure; } set { destination = value; } }
        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get { return destination; } set { destination = value; } }
        /// <summary>
        /// Возвращает и задает время прибытия.
        /// </summary>
        public Time DepartureTime { get { return departure_time; } set {  departure_time = value; } }
        /// <summary>
        /// Возвращает и задает время полёта. Значение должно быть положительным.
        /// </summary>
        public Time FlightTime
        { get { return flight_time; } set { flight_time = value; } }
        /// <summary>
        /// Возвращает и задает тип полёта: внутренний или международный.
        /// </summary>
        public string FlightType { get { return flight_type; } set { flight_type=value; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Название рейса.</param>
        /// <param name="departure">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="departure_time">Время прибытия.</param>
        /// <param name="flight_time">Время полёта.></param>
        /// <param name="fligth_type">Тип рейса.</param>

        public Flight(string name, string departure, string destination, 
            Time departure_time, Time flight_time, string fligth_type)
        {
            Name = name;
            Departure = departure;
            Destination = destination;
            DepartureTime = departure_time;
            FlightTime = flight_time;
            FlightType = fligth_type;
            _allFlightsCount += 1;
            _id = AllFlightsCount();
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
            _allFlightsCount += 1;
            _id = AllFlightsCount();
        }

        /// <summary>
        /// Считает количество прямоугольников в программе.
        /// </summary>
        /// <returns>Возвращает количество прямоугольников в программе.</returns>
        public static int AllFlightsCount()
        {
            return _allFlightsCount;
        }

    }
}
