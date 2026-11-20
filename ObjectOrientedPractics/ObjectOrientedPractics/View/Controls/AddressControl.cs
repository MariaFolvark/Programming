using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Address Address
        {
            get
            {
                if ((string.IsNullOrWhiteSpace(PostIndexTextBox.Text) || PostIndexTextBox.BackColor == Color.Red) ||
                    (string.IsNullOrWhiteSpace(CountryTextBox.Text) || CountryTextBox.BackColor == Color.Red) ||
                    (string.IsNullOrWhiteSpace(CityTextBox.Text) || CityTextBox.BackColor == Color.Red) ||
                    (string.IsNullOrWhiteSpace(StreetTextBox.Text) || StreetTextBox.BackColor == Color.Red) ||
                    (string.IsNullOrWhiteSpace(BuildingTextBox.Text) || BuildingTextBox.BackColor == Color.Red) ||
                    (string.IsNullOrWhiteSpace(ApartmentTextBox.Text) || ApartmentTextBox.BackColor == Color.Red))
                {
                    throw new ArgumentNullException(nameof(Address), $"Значение свойства '{nameof(Address)}' не может быть пустым или некорректным.");
                }
                else { return _address; }
            }
            set { _address = value; }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PostIndexTextBox.Text)) return;
            int cursorPosition = PostIndexTextBox.SelectionStart;
            int.TryParse(PostIndexTextBox.Text, out int res);
            if (res > 99999 & res < 1000000)
            {
                _address.PostIndex = res;
                PostIndexTextBox.Text = _address.PostIndex.ToString();
                PostIndexTextBox.BackColor = Color.White;
            }
            else
            {
                PostIndexTextBox.BackColor = Color.Red;
            }
            PostIndexTextBox.SelectionStart = cursorPosition;
            PostIndexTextBox.SelectionLength = 0;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CountryTextBox.Text)) return;
            string input = CountryTextBox.Text;
            try
            {
                _address.Country = input;
                CountryTextBox.Text = _address.Country;
                CountryTextBox.SelectionStart = CountryTextBox.Text.Length;
                CountryTextBox.SelectionLength = 0;
                CountryTextBox.BackColor = Color.White;
            }
            catch { CountryTextBox.BackColor = Color.Red; }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CityTextBox.Text)) return;
            string input = CityTextBox.Text;
            try
            {
                _address.City = input;
                CityTextBox.Text = _address.City;
                CityTextBox.SelectionStart = CityTextBox.Text.Length;
                CityTextBox.SelectionLength = 0;
                CityTextBox.BackColor = Color.White;
            }
            catch { CityTextBox.BackColor = Color.Red; }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StreetTextBox.Text)) return;
            string input = StreetTextBox.Text;
            try
            {
                _address.Street = input;
                StreetTextBox.Text = _address.Street;
                StreetTextBox.SelectionStart = StreetTextBox.Text.Length;
                StreetTextBox.SelectionLength = 0;
                StreetTextBox.BackColor = Color.White;
            }
            catch { StreetTextBox.BackColor = Color.Red; }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BuildingTextBox.Text)) return;
            string input = BuildingTextBox.Text;
            try
            {
                _address.Building = input;
                BuildingTextBox.Text = _address.Building;
                BuildingTextBox.SelectionStart = BuildingTextBox.Text.Length;
                BuildingTextBox.SelectionLength = 0;
                BuildingTextBox.BackColor = Color.White;
            }
            catch { BuildingTextBox.BackColor = Color.Red; }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ApartmentTextBox.Text)) return;
            string input = ApartmentTextBox.Text;
            try
            {
                _address.Apartment = input;
                ApartmentTextBox.Text = _address.Apartment;
                ApartmentTextBox.SelectionStart = ApartmentTextBox.Text.Length;
                ApartmentTextBox.SelectionLength = 0;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch { ApartmentTextBox.BackColor = Color.Red; }
        }
    }
}
