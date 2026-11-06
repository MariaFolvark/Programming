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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = Customer.RandomCustomer();
            _customers.Add(customer);
            int addedIndex = CustomersListBox.Items.Add(customer.FullName);
            CustomersListBox.SelectedIndex = addedIndex;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _customers.Count)
            {
                _currentCustomer = _customers[selectedIndex];
                UpdateCustomerInfo();
            }
            else
            {
                _currentCustomer = null;
                ClearCustomerInfo();
            }
        }

        private void ClearCustomerInfo()
        {
            IdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        private void UpdateCustomerInfo()
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            int selected_ind = CustomersListBox.SelectedIndex;
            IdTextBox.Text = _customers[selected_ind].Id.ToString();
            FullNameTextBox.Text = _customers[selected_ind].FullName;
            AddressTextBox.Text = _customers[selected_ind].Address;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex < 0) { return; }
            _customers.RemoveAt(selectedIndex);
            CustomersListBox.Items.RemoveAt(selectedIndex);
            if (CustomersListBox.Items.Count > 0)
            {
                CustomersListBox.SelectedIndex = Math.Min(selectedIndex, CustomersListBox.Items.Count - 1);
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameTextBox.Text)) return;
            if (_currentCustomer == null) return;
            string input = FullNameTextBox.Text;
            try
            {
                _currentCustomer.FullName = input;
                _customers[CustomersListBox.SelectedIndex].FullName = input;
                FullNameTextBox.Text = _customers[CustomersListBox.SelectedIndex].FullName;
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                FullNameTextBox.SelectionLength = 0;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = input;
            }
            catch { FullNameTextBox.Text = _currentCustomer.FullName; }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text)) return;
            if (_currentCustomer == null) return;
            string input = AddressTextBox.Text;
            try
            {
                _currentCustomer.Address = input;
                _customers[CustomersListBox.SelectedIndex].Address = input;
                AddressTextBox.Text = _customers[CustomersListBox.SelectedIndex].Address;
                AddressTextBox.SelectionStart = AddressTextBox.Text.Length;
                AddressTextBox.SelectionLength = 0;
            }
            catch { AddressTextBox.Text = _currentCustomer.Address; }
        }
    }
}
