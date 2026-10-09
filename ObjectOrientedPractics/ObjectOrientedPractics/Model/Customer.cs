using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
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
        private string _adress;

        /// <summary>
        /// Задает Уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает
        /// </summary>
        public string FulName
        {
            get { return _fullname; }
            set { _fullname = Validator.AssertStringLength(value, 200, nameof(value)); }
        }
        /// <summary>
        /// Возвращает и задает
        /// </summary>
        public string Adress
        {
            get { return _adress; }
            set { _adress = Validator.AssertStringLength(value, 500, nameof(value)); }
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
        /// <param name="adress">Адрес доставки.</param>
        public Customer(string fullname, string adress)
        {
            _allCustomersCount++;
            _id = AllCustomersCount();
            _fullname = fullname;
            Adress = adress;
        }
    }
}
