using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Items> _items = new List<Items>();
        private Items _currentItem;
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Items item = Items.RandomItem();
            _items.Add(item);
            int addedIndex = ItemsListBox.Items.Add(item.Name);
            ItemsListBox.SelectedIndex = addedIndex;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _items.Count)
            {
                _currentItem = _items[selectedIndex];
                UpdateItemInfo();
            }
            else
            {
                _currentItem = null;
                ClearItemInfo();
            }

        }

        private void UpdateListBox()
        {
            if (_items.Count == 0)
            {
                ClearItemInfo();
                ItemsListBox.Items.Clear();
                return;
            }
            int ind = ItemsListBox.SelectedIndex;
            ItemsListBox.Items.Clear();
            for (int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(item: (_items[i]));
            }
            ItemsListBox.SelectedIndex = ind;
        }
        private void UpdateItemsInListBox()
        {
            int index = ItemsListBox.SelectedIndex;
            if (_currentItem == null || index < 0) { return; }
            _items[index] = _currentItem;
            ItemsListBox.Items[index] = _currentItem;
        }
        private void ClearItemInfo()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
        }
        private void UpdateItemInfo()
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            int selected_ind = ItemsListBox.SelectedIndex;
            IdTextBox.Text = _items[selected_ind].Id.ToString();
            NameTextBox.Text = _items[selected_ind].Name;
            CostTextBox.Text = _items[selected_ind].Cost.ToString();
            DescriptionTextBox.Text = _items[selected_ind].Info;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex < 0) { return; }
            _items.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);
            if (ItemsListBox.Items.Count > 0)
            {
                ItemsListBox.SelectedIndex = Math.Min(selectedIndex, ItemsListBox.Items.Count - 1);
            }               
        }
    }
}
