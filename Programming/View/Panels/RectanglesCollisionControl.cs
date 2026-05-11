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
    public partial class RectanglesCollisionControl : UserControl
    {
        private Rectangles _currentRectangle;
        private List<Rectangles> _rectangles = new List<Rectangles>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private static double panelWidth_in_Rectangles = 535;
        private static double panelHeight_in_Rectangles = 454;
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            AddButton_in_Rectangles.Click += AddButton_in_Rectangles_Click;
            DeleteButton_in_Rectangles.Click += DeleteButton_in_Rectangles_Click;
            ListBox_in_Rectangles.SelectedIndexChanged += ListBox_in_Rectangles_SelectedIndexChanged;
            WidthTextBox_in_Rectangles.TextChanged += WidthTextBox_in_Rectangles_TextChanged;
            HeightTextBox_in_Rectangles.TextChanged += HeightTextBox_in_Rectangles_TextChanged;
            XTextBox_in_Rectangles.TextChanged += XTextBox_in_Rectangles_TextChanged;
            YTextBox_in_Rectangles.TextChanged += YTextBox_in_Rectangles_TextChanged;
        }
        private void ClearRectangleInfo()
        {
            IdTextBox_in_Rectangles.Text = "";
            XTextBox_in_Rectangles.Text = "";
            YTextBox_in_Rectangles.Text = "";
            WidthTextBox_in_Rectangles.Text = "";
            HeightTextBox_in_Rectangles.Text = "";
        }
        private void UpdateRectangleInfo(Rectangles rectangle)
        {
            if (rectangle == null) return;

            IdTextBox_in_Rectangles.Text = _currentRectangle.Id.ToString();
            XTextBox_in_Rectangles.Text = _currentRectangle.Center.X.ToString("F2");
            YTextBox_in_Rectangles.Text = _currentRectangle.Center.Y.ToString("F2");
            WidthTextBox_in_Rectangles.Text = _currentRectangle.Width.ToString("F2");
            HeightTextBox_in_Rectangles.Text = _currentRectangle.Length.ToString("F2");
        }
        private void UpdatePanel()
        {
            int index = _rectangles.IndexOf(_currentRectangle);
            int canvasHeight = RectanglesPanel.Height;
            int left = (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2);
            int top = (int)(canvasHeight - (_currentRectangle.Center.Y + _currentRectangle.Length / 2));
            _rectanglePanels[index].Location = new Point(left, top);
            _rectanglePanels[index].Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
            FindCollisions();
            _rectanglePanels[ListBox_in_Rectangles.SelectedIndex].BackColor = Color.FromArgb(200, 255, 255, 0);
        }
        private void UpdateRectangleInListBox()
        {
            if (_currentRectangle == null) return;

            int selectedIndex = ListBox_in_Rectangles.SelectedIndex;
            string _rectangle_str = _currentRectangle.Id.ToString() + ": (" +
                                "X= " + _currentRectangle.Center.X.ToString("F2") +
                                "; Y= " + _currentRectangle.Center.Y.ToString("F2") +
                                "; W= " + _currentRectangle.Width.ToString("F2") +
                                "; H= " + _currentRectangle.Length.ToString("F2") + ")";
            ListBox_in_Rectangles.Items[selectedIndex] = _rectangle_str;
        }
        private void XTextBox_in_Rectangles_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = XTextBox_in_Rectangles.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minX = _currentRectangle.Width / 2 + 15;
                double maxX = panelWidth_in_Rectangles - _currentRectangle.Width / 2 - 15;
                if (value < minX)
                {
                    value = minX;
                }
                else if (value > maxX)
                {
                    value = maxX;
                }
                _currentRectangle.Center.SetX(value);
                UpdateRectangleInListBox();
                UpdatePanel();

            }
            catch
            {
                XTextBox_in_Rectangles.Text = _currentRectangle.Center.X.ToString("F2");
            }
        }
        private void YTextBox_in_Rectangles_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = YTextBox_in_Rectangles.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minY = _currentRectangle.Length / 2 + 15;
                double maxY = panelHeight_in_Rectangles - _currentRectangle.Length / 2 - 15;
                if (value < minY)
                {
                    value = minY;
                }
                else if (value > maxY)
                {
                    value = maxY;
                }
                _currentRectangle.Center.SetY(value);
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                YTextBox_in_Rectangles.Text = _currentRectangle.Center.Y.ToString("F2");
            }
        }
        private void WidthTextBox_in_Rectangles_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = WidthTextBox_in_Rectangles.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                _currentRectangle.Width = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                WidthTextBox_in_Rectangles.Text = _currentRectangle.Width.ToString("F2");
            }
        }
        private void HeightTextBox_in_Rectangles_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = HeightTextBox_in_Rectangles.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                _currentRectangle.Length = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                HeightTextBox_in_Rectangles.Text = _currentRectangle.Length.ToString("F2");
            }
        }
        private void ListBox_in_Rectangles_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = ListBox_in_Rectangles.SelectedIndex;

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            FindCollisions();

            if (selectedIndex >= 0 && selectedIndex < _rectangles.Count)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateRectangleInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].BackColor = Color.FromArgb(200, 255, 255, 0);
            }
            else
            {
                _currentRectangle = null;
                ClearRectangleInfo();
            }
        }
        private void DeleteButton_in_Rectangles_Click(object? sender, EventArgs e)
        {
            int selectedIndex = ListBox_in_Rectangles.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _rectangles.Count)
            {
                return;
            }
            RectanglesPanel.Controls.RemoveAt(selectedIndex);
            _rectanglePanels.RemoveAt(selectedIndex);
            _rectangles.RemoveAt(selectedIndex);
            ListBox_in_Rectangles.Items.RemoveAt(selectedIndex);
            FindCollisions();
            // Вариант удаления панели по объекту
            //RectanglesPanel.Controls.Remove(panel);
        }
        private void AddButton_in_Rectangles_Click(object? sender, EventArgs e)
        {
            Rectangles _rectangle = Model.Geometry.Rectangles.RandomRectangle(30, 100, 30, 100, 15, panelWidth_in_Rectangles, 15, panelHeight_in_Rectangles);
            _rectangles.Add(_rectangle);
            string _rectangle_str = _rectangle.Id.ToString() + ": (" +
                "X= " + _rectangle.Center.X.ToString("F2") + "; Y= " + _rectangle.Center.Y.ToString("F2") +
                "; W= " + _rectangle.Width.ToString("F2") + "; H=" + _rectangle.Length.ToString("F2") + ")";
            ListBox_in_Rectangles.Items.Add(_rectangle_str);

            Panel panel = new Panel();
            int canvasHeight = RectanglesPanel.Height;
            int left = (int)(_rectangle.Center.X - _rectangle.Width / 2);
            int top = (int)(canvasHeight - (_rectangle.Center.Y + _rectangle.Length / 2));
            panel.Location = new Point(left, top);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            panel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            FindCollisions();

        }
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127); // зелёный
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

    }
}
