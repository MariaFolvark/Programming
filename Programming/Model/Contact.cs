using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string name = "Undefined";
        private string surname = "Undefined";
        private string phone_number = "Undefined";

        public string Name {
            get { return name; }
            set
            {
                name = AssertStringContainsOnlyLetters(value, "name");
            }
        }
        public string Surname {
            get {  return surname; }
            set
            {
                surname = AssertStringContainsOnlyLetters(value, "surname");
            }
        }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
        public Contact(string name, string surname, string phone_number)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phone_number;
        }
        public Contact() { }

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