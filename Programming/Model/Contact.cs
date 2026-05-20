using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о человеке и его контактных данных.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string name = "Undefined";
        /// <summary>
        /// Фамилия.
        /// </summary>
        private string surname = "Undefined";
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string phone_number = "Undefined";

        /// <summary>
        /// Возвращает и задает имя. Должно состоять только из букв.
        /// </summary>
        public string Name {
            get { return name; }
            set
            {
                name = AssertStringContainsOnlyLetters(value, nameof(name));
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию. Должна состоять только из букв.
        /// </summary>
        public string Surname {
            get {  return surname; }
            set
            {
                surname = AssertStringContainsOnlyLetters(value, nameof(surname));
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Длина.</param>
        /// <param name="phone_number">Ширина.</param>
        public Contact(string name, string surname, string phone_number)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phone_number;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangles"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="name">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <returns>Возвращает value, если строка состоит из букв.</returns>

        private string AssertStringContainsOnlyLetters(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Строка не может быть пустой.");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    throw new ArgumentException($"Переменная {name} должна содержать только буквы английского алфавита.");
                }
            }

            return value;
        }

    }    
}

/*
try
{
    this.Name = name;
    this.Surname = surname;
    this.PhoneNumber = phone_number;
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка при создании контакта: {ex.Message}");
}
 */