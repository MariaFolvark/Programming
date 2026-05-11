using Programming.Model.Geometry;
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
    public partial class RectanglesControl : UserControl
    {
        private Rectangles[] _rectangles_in_classes;
        private Rectangles _currentRectangle_in_classes;
        public RectanglesControl()
        {
            InitializeComponent();
            RectanglesListBox_in_Classes.SelectedIndexChanged += RectanglesLlistBox_SelectedIndexChanged;
            LengthTextBox_in_Classes.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox_in_Classes.TextChanged += WidthTextBox_TextChanged;
            RectangleFindButton_in_Classes.Click += FindButton_Click;
            this.Load += RectanglesControl_Load;
        }

        private void RectanglesControl_Load(object? sender, EventArgs e)
        {
            _rectangles_in_classes = Model.Geometry.Rectangles.RandomRectanglesArray(5);
            for (int i = 0; i < _rectangles_in_classes.Length; i++)
            {
                RectanglesListBox_in_Classes.Items.Add(_rectangles_in_classes[i].Name);
            }
            RectanglesListBox_in_Classes.SelectedIndex = 0;
        }
        private void FindButton_Click(object? sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles_in_classes);
            if (index >= 0 && index < _rectangles_in_classes.Length)
            {
                RectanglesListBox_in_Classes.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Прямоугольники отсутствуют.");
            }
        }
        private int FindRectangleWithMaxWidth(Rectangles[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
                return -1;

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;
            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        private void WidthTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = WidthTextBox_in_Classes.Text;
                if (!double.TryParse(input, out double value) || value < 1 || value > 20)
                {
                    throw new ArgumentException();
                }
                _currentRectangle_in_classes.Width = value;
                WidthTextBox_in_Classes.BackColor = Color.White;
            }
            catch
            {
                WidthTextBox_in_Classes.BackColor = Color.LightPink;
            }
        }
        private void LengthTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = LengthTextBox_in_Classes.Text;
                if (!double.TryParse(input, out double value) || value < 1 || value > 20)
                {
                    throw new ArgumentException();
                }
                _currentRectangle_in_classes.Length = value;
                LengthTextBox_in_Classes.BackColor = Color.White;
            }
            catch
            {
                LengthTextBox_in_Classes.BackColor = Color.LightPink;
            }
        }
        private void RectanglesLlistBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (RectanglesListBox_in_Classes.SelectedIndex < 0 || RectanglesListBox_in_Classes.SelectedIndex >= _rectangles_in_classes.Length)
                return;

            _currentRectangle_in_classes = _rectangles_in_classes[RectanglesListBox_in_Classes.SelectedIndex];
            RectanglesIdTextBox_in_Classes.Text = _currentRectangle_in_classes.Id.ToString();
            LengthTextBox_in_Classes.Text = _currentRectangle_in_classes.Length.ToString("F2");//"F2" - 2 знака после запятой
            WidthTextBox_in_Classes.Text = _currentRectangle_in_classes.Width.ToString("F2");
            ColorTextBox_in_Classes.Text = _currentRectangle_in_classes.Colour.ToString();
            CenterCoordinatesTextBoxX_in_Classes.Text = _currentRectangle_in_classes.Center.X.ToString("F2");
            CenterCoordinatesTextBoxY_in_Classes.Text = _currentRectangle_in_classes.Center.Y.ToString("F2");
        }
    }
}
