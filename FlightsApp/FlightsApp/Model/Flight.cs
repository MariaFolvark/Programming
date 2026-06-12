using FlightsApp.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlightsApp.Model
{
    /// <summary>
    /// Хранит данные о рейсе.
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
        /// Время вылета.
        /// </summary>
        private DateTime departure_time = new DateTime();
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int flight_time = 0;
        /// <summary>
        /// Тип рейса: внутренний/международный.
        /// </summary>
        private FlightType flight_type;

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
        public string Departure { get { return departure; } set { departure = value; } }
        /// <summary>
        /// Возвращает и задает пункт назначения.
        /// </summary>
        public string Destination { get { return destination; } set { destination = value; } }
        /// <summary>
        /// Возвращает и задает время вылета.
        /// </summary>
        public DateTime DepartureTime { get { return departure_time; } set { departure_time = value; } }
        /// <summary>
        /// Возвращает и задает время полёта. Значение должно быть положительным.
        /// </summary>
        public int FlightTime
        {
            get { return flight_time; }
            set { flight_time = Validator.AssertValueInRange(value, 0, 1000, nameof(value)); }
        }
        /// <summary>
        /// Возвращает и задает тип полёта: внутренний или международный.
        /// </summary>
        public FlightType FlightType { get { return flight_type; } set { flight_type = value; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="name">Название рейса.</param>
        /// <param name="departure">Пункт вылета.</param>
        /// <param name="destination">Пункт назначения.</param>
        /// <param name="departure_time">Время прибытия.</param>
        /// <param name="flight_time">Время полёта.></param>
        /// <param name="fligth_type">Тип рейса.</param>

        public Flight(string name, string departure, string destination,
            DateTime departure_time, int flight_time, FlightType fligth_type)
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
        /// Считает количество рейсов в программе.
        /// </summary>
        /// <returns>Возвращает количество рейсов в программе.</returns>
        public static int AllFlightsCount()
        {
            return _allFlightsCount;
        }

        public static Flight RandomFlight(FlightType flightType)
        {
            Random rand = new Random();
            
            int RussianCitiesCount = Enum.GetNames(typeof(RussianСities)).Length;
            string departure = ((RussianСities)rand.Next(RussianCitiesCount)).ToString();
            string destination;

            if (flightType == FlightType.DomesticFlight)
            {
                do
                {
                    destination = ((RussianСities)rand.Next(RussianCitiesCount)).ToString();
                } while (departure == destination);
            }
            else
            {
                int ForeignCitiesCount = Enum.GetNames(typeof(ForeignCities)).Length;
                do
                {
                    destination = ((ForeignCities)rand.Next(ForeignCitiesCount)).ToString();
                } while (departure == destination);
            }
            
            DateTime departure_time = DateTime.Today.AddDays(rand.Next(0, 2)).AddHours(rand.Next(24)).AddMinutes(rand.Next(60));           
            string name = departure + " - " + destination;
            int flight_time = rand.Next(1, 1001);

            Flight flight = new Flight(name, departure, destination, departure_time, flight_time, flightType);
            return flight;
        }

        public static List<Flight> RandomFlightsList(int cnt)
        {
            List<Flight> flights = new List<Flight>(cnt);
            Random rand = new Random();
            for (int i = 0; i < cnt; i++)
            {
                var flightType = (FlightType)rand.Next(Enum.GetNames(typeof(FlightType)).Length);
                flights.Add(Flight.RandomFlight(flightType));
            }
            SortFlightsByDepartureTime(flights);
            return flights;
        }

        public static void SortFlightsByDepartureTime(List<Flight> flights)
        {
            flights.Sort((f1, f2) => DateTime.Compare(f1.DepartureTime, f2.DepartureTime));
        }

    }
}
