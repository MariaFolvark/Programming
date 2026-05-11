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
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
            ParseButton.Click += ParseButton_Click;
        }
        private void ParseButton_Click(object? sender, EventArgs e)
        {
            string input = WeekdayTextBox.Text.Trim();
            try
            {
                Weekday day;
                if (Enum.TryParse<Weekday>(input, true, out day) && Enum.IsDefined(typeof(Weekday), day))//true - игнор регистр букв
                {
                    WeekDayLlabel2.Text = $"Это день недели ({day} = {(int)day})";

                }
                else
                {
                    WeekDayLlabel2.Text = "Нет такого дня недели";
                }
            }
            catch (Exception ex)
            {
                WeekDayLlabel2.Text = "Нет такого дня недели";
            }
        }
    }
}
