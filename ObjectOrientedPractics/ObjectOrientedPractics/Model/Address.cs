using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Адрес, состоящий из отдельных частей.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс — целое шестизначное число.
        /// </summary>
        private int _postIndex;

        /// <summary>
        /// Страна/регион, строка, не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт), строка, не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица, строка, не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома, строка, не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения, не более 10 символов.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс.
        /// </summary>
        public int PostIndex
        {
            get { return _postIndex; }
            set { _postIndex = (int)Validator.AssertValueInRange(value, 100000, 999999, nameof(value)); }
        }

        /// <summary>
        /// Возвращает и задает страну или регион.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set { _country = Validator.AssertStringLength(value, 50, nameof(value)); }
        }

        /// <summary>
        /// Возвращает и задает город или населённый пункт.
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = Validator.AssertStringLength(value, 50, nameof(value)); }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set { _street = Validator.AssertStringLength(value, 100, nameof(value)); }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set { _building = Validator.AssertStringLength(value, 10, nameof(value)); }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры или помещения.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set { _apartment = Validator.AssertStringLength(value, 10, nameof(value)); }
        }

        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        public Address()
        {
            PostIndex = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        /// <param name="postIndex">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город или населённый пункт.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры или помещения.</param>
        public Address(int postIndex, string country, string city, string street, string building, string apartment)
        {
            PostIndex = postIndex;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
