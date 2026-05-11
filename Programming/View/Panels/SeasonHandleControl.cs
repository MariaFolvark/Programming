using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            this.Load += SeasonHandleControl_Load;
            GoButton.Click += GoButton_Click;
        }

        private void SeasonHandleControl_Load(object? sender, EventArgs e)
        {
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object? sender, EventArgs e)
        {
            Season season = (Season)SeasonComboBox.SelectedItem;
            if (season == null)
                return;
            switch (season)
            {
                case Season.Autumn:
                    //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    MessageBox.Show("Скоро зима!");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Winter:
                    MessageBox.Show("Брр! Холодно!");
                    break;
                case Season.Spring:
                    //this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    MessageBox.Show("Скоро лето!");
                    break;
            }
        }
    }
}
