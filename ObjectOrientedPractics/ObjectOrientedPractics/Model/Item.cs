using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Счётчик кол-ва товаров в программе.
        /// </summary>
        private static int _allItemsCount = 0;
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;
        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;
        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;


        /// <summary>
        /// Задает Уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }
        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = Validator.AssertStringLength(value, 200, nameof(value)); }
        }
        /// <summary>
        /// Возвращает и задает информацию о товаре.
        /// </summary>
        public string Info
        {
            get { return _info; }
            set { _info = Validator.AssertStringLength(value, 1000, nameof(value)); }
        }
        /// <summary>
        /// Возвращает и задает стоимость.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = Validator.AssertValueInRange(value, 0, 100000, nameof(value)); }
        }

        /// <summary>
        /// Считает кол-во товаров в программе.
        /// </summary>
        /// <returns>Возвращает кол-во товаров в программе.</returns>
        public static int AllItemsCount()
        {
            return _allItemsCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="info">Информация о товаре.</param>
        /// <param name="cost">Стоимость.</param>
        public Item(string name, string info, double cost)
        {
            _allItemsCount++;
            _id = AllItemsCount();
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
