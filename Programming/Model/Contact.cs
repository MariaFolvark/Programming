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

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get {  return surname; } set {  surname = value; } }
        public string PhoneNumber { get { return phone_number; } set { phone_number = value; } }
    }
}
