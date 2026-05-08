using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
        private Rectangles[] _rectangles_in_classes;
        private Rectangles _currentRectangle_in_classes;
        private Film[] _films;
        private Film _currentFilm;
        private Rectangles _currentRectangle;
        private List<Rectangles> _rectangles = new List<Rectangles>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private static double panelWidth_in_Rectangles = 555;
        private static double panelHeight_in_Rectangles = 474;

        public void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            IntValueTextBox.Text = ((int)Enum.Parse(typeof(Colors), "Red")).ToString();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
            ///
            ///
            _rectangles_in_classes = Model.Geometry.Rectangles.RandomRectanglesArray(5);
            for (int i = 0; i < _rectangles_in_classes.Length; i++)
            {
                RectanglesListBox_in_Classes.Items.Add(_rectangles_in_classes[i].Name);
            }
            RectanglesListBox_in_Classes.SelectedIndex = 0;

            _films = Film.RandomFilmsArray(5);
            for (int i = 0; i < _films.Length; i++)
            {
                FilmListBox.Items.Add(_films[i].Title);
            }
            FilmListBox.SelectedIndex = 0;

        }
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 600);
            this.MaximumSize = new Size(1000, 600);
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            ParseButton.Click += ParseButton_Click;
            GoButton.Click += GoButton_Click;
            RectanglesListBox_in_Classes.SelectedIndexChanged += RectanglesLlistBox_SelectedIndexChanged;
            LengthTextBox_in_Classes.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox_in_Classes.TextChanged += WidthTextBox_TextChanged;
            RectangleFindButton_in_Classes.Click += FindButton_Click;
            FilmListBox.SelectedIndexChanged += FilmListBox_SelectedIndexChanged;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            YearOfReleaseTextBox.TextChanged += YearOfReleaseTextBox_TextChanged;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            FilmFindButton.Click += FilmFindButton_Click;
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

        // Classes
        private void RatingTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = RatingTextBox.Text;
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException();
                }
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double roundedValue = Math.Round(value, 1);
                roundedValue = Validator.AssertValueInRange(roundedValue, 0, 10, nameof(roundedValue));
                _currentFilm.Rating = roundedValue;
                RatingTextBox.Text = roundedValue.ToString("0.0");
                RatingTextBox.BackColor = Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = Color.LightPink;
            }
        }
        private void YearOfReleaseTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = YearOfReleaseTextBox.Text;
                int year;
                if (!int.TryParse(input, out year))
                {
                    throw new ArgumentException();
                }
                int currentYear = DateTime.Now.Year;
                year = Validator.AssertValueInRange(year, 1900, currentYear, nameof(year));
                _currentFilm.YearOfRelease = year;
                YearOfReleaseTextBox.BackColor = Color.White;
            }
            catch
            {
                YearOfReleaseTextBox.BackColor = Color.LightPink;
            }
        }
        private void DurationTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = DurationTextBox.Text;
                int duration;
                if (!int.TryParse(input, out duration) || duration <= 0)
                {
                    throw new ArgumentException();
                }
                _currentFilm.DurationInMinutes = duration;
                DurationTextBox.BackColor = Color.White;
            }
            catch
            {
                DurationTextBox.BackColor = Color.LightPink;
            }
        }
        private void TitleTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = TitleTextBox.Text;
                if (input.Length > 40 || input.Length < 1)
                {
                    throw new ArgumentException();
                }
                if (input.Length > 0 && !char.IsLetter(input[0]))
                {
                    throw new ArgumentException();
                }
                _currentFilm.Title = input;
                TitleTextBox.BackColor = Color.White;
            }
            catch
            {
                TitleTextBox.BackColor = Color.LightPink;
            }
        }
        private void FilmListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (FilmListBox.SelectedIndex < 0 || FilmListBox.SelectedIndex >= _films.Length)
                return;

            _currentFilm = _films[FilmListBox.SelectedIndex];
            TitleTextBox.Text = _currentFilm.Title.ToString();
            DurationTextBox.Text = _currentFilm.DurationInMinutes.ToString();
            YearOfReleaseTextBox.Text = _currentFilm.YearOfRelease.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString("F1");
        }
        private void FilmFindButton_Click(object? sender, EventArgs e)
        {
            int index = FindFilmWithMaxRating(_films);
            if (index >= 0 && index < _films.Length)
            {
                FilmListBox.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Фильмы отсутствуют.");
            }
        }
        private int FindFilmWithMaxRating(Film[] films)
        {
            if (films == null || films.Length == 0)
                return -1;

            int maxIndex = 0;
            double maxRating = films[0].Rating;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
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

// Enums
        private void GoButton_Click(object? sender, EventArgs e)
        {
            Season season = (Season)SeasonComboBox.SelectedItem;
            if (season == null)
                return;
            switch (season)
            {
                case Season.Autumn:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Winter:
                    MessageBox.Show("Брр! Холодно!");
                    break;
                case Season.Spring:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
            }
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
        void EnumsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            int selectedIndex = EnumsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= enumTypes.Length)
                return;

            Type enumType = enumTypes[selectedIndex];

            var values = Enum.GetValues(enumType);
            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value.ToString());
            }
        }
        void ValuesListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= enumTypes.Length)
                return;

            string selected_item = ValuesListBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected_item))
                return;

            Type enumType = enumTypes[selectedIndex];
            object enumValue = Enum.Parse(enumType, selected_item);
            int numberValue = (int)enumValue;
            IntValueTextBox.Text = numberValue.ToString();
        }

    }
}

/*
Random rand = new Random();
int colorCount = Enum.GetNames(typeof(Colors)).Length;
for (int i = 0; i < 5; i++)
{
    string name = "Rectangle " + (i+1).ToString();
    double length = 1 + rand.NextDouble() * 19;
    double width = 1 + rand.NextDouble() * 19;
    string randomColor = ((Colors)rand.Next(colorCount)).ToString();
    _rectangles[i] = new Rectangles(name, length, width, randomColor);
    RectanglesListBox.Items.Add(name);
}*/
/*try
{
    string input = YTextBox_in_Rectangles.Text;
    if (!double.TryParse(input, out double value) || value < 0 || value > 100)
    {
        throw new ArgumentException();
    }

    _currentRectangle.Center.SetY(value);
    YTextBox_in_Rectangles.BackColor = Color.White;
    UpdateRectangleInListBox();
}
catch
{
    YTextBox_in_Rectangles.BackColor = Color.LightPink;
}*/