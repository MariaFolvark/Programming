using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные всех товаров и покупателей.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Товары.
        /// </summary>
        private List <Items> _items;
        /// <summary>
        /// Покупатели.
        /// </summary>
        private List <Customer> _customers;
        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public List<Items> Items
        {
            get { return _items; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _items = value;
            }
        }
        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _customers = value;
            }
        }
        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        public Store()
        {
            _items = new List<Items>();
            _customers = new List<Customer>();
        }
    }
}
