using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightsApp.View
{
    public partial class InputDateTimeForm : Form
    {
        private MainForm mainForm;

        DateTime input_dateTime;
        public DateTime InputDateTime { get { return input_dateTime; } set { input_dateTime = value; } }

        public InputDateTimeForm(MainForm parentForm)
        {
            InitializeComponent();
            DateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            CancelButton.Click += CancelButton_Click;
            OKButton.Click += OKButton_Click;
            this.Load += InputDateTimeForm_Load;
            mainForm = parentForm;
        }

        private void InputDateTimeForm_Load(object? sender, EventArgs e)
        {
            input_dateTime = mainForm.CurrentDateTime;
            DateTimePicker.Value = input_dateTime;
        }

        private void OKButton_Click(object? sender, EventArgs e)
        {
            DateTime input = DateTimePicker.Value;
            try
            {
                if (input < DateTime.Today || input > DateTime.Today.AddDays(2)) { throw new ArgumentException(); }
                input_dateTime = input;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Некорректная дата!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            DateTime input = DateTimePicker.Value;
            try
            {
                if (input < DateTime.Today || input > DateTime.Today.AddDays(2)) { throw new ArgumentException(); }
            }
            catch { DateTimePicker.Value = input_dateTime; }
        }
    }
}
