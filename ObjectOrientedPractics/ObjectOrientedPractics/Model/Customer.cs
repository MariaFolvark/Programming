using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Данные о покупателе.
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Счётчик кол-ва покупателей в программе.
        /// </summary>
        private static int _allCustomersCount = 0;
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string FullName
        {
            get { return _fullname; }
            set { _fullname = Validator.AssertStringLength(value, 200, nameof(value)); }
        }
        /// <summary>
        /// Возвращает и задает адрес.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Считает кол-во покупателей в программе.
        /// </summary>
        /// <returns>Возвращает кол-во покупателей в программе</returns>
        public static int AllCustomersCount()
        {
            return _allCustomersCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullname, Address address)
        {
            _allCustomersCount++;
            _id = AllCustomersCount();
            _fullname = fullname;
            Address = address;
        }

        public static Customer RandomCustomer()
        {
            Random rand = new Random();
            int CustomerNamesCount = Enum.GetNames(typeof(CustomerNames)).Length;
            string customerName = ((CustomerNames)rand.Next(CustomerNamesCount)).ToString();
            string current = (AllCustomersCount() + 1).ToString();
            Address address = new Address(111111, "Country " + current, "City " + current,
                "Street " + current, current, current);
            return new Customer(customerName, address);
        }
    }
}
