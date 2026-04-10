using Programming.Model;
using Programming.Model.Enums;
using System.Collections;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
        private Rectangles[] _rectangles;
        private Rectangles _currentRectangle;
        private Film[] _films;
        private Film _currentFilm;

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
            _rectangles = Rectangles.RandomRectanglesArray(5);
            for(int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add(_rectangles[i].Name);
            }
            RectanglesListBox.SelectedIndex = 0;

            _films = Film.RandomFilmsArray(5);
            for(int i = 0; i < _films.Length; i++)
            {
                FilmListBox.Items.Add(_films[i].Title);
            }
            FilmListBox.SelectedIndex = 0;
            
        }
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            ParseButton.Click += ParseButton_Click;
            GoButton.Click += GoButton_Click;
            RectanglesListBox.SelectedIndexChanged += RectanglesLlistBox_SelectedIndexChanged;
            LenghtTextBox.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            RectangleFindButton.Click += FindButton_Click;
            FilmListBox.SelectedIndexChanged += FilmListBox_SelectedIndexChanged;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            YearOfReleaseTextBox.TextChanged += YearOfReleaseTextBox_TextChanged;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            FilmFindButton.Click += FilmFindButton_Click;
        }

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
            int index = FindRectangleWithMaxWidth(_rectangles);
            if (index >= 0 && index < _rectangles.Length)
            {
                RectanglesListBox.SelectedIndex = index;
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
                string input = WidthTextBox.Text;
                if (!double.TryParse(input, out double value) || value < 1 || value > 20)
                {
                    throw new ArgumentException();
                }

                _currentRectangle.Width = value;
                WidthTextBox.BackColor = Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void LengthTextBox_TextChanged(object? sender, EventArgs e)
        {
            try
            {
                string input = LenghtTextBox.Text;
                if (!double.TryParse(input, out double value) || value < 1 || value > 20)
                {
                    throw new ArgumentException();
                }

                _currentRectangle.Length = value;
                LenghtTextBox.BackColor = Color.White;
            }
            catch
            {
                LenghtTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesLlistBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex < 0 || RectanglesListBox.SelectedIndex >= _rectangles.Length)
                return;

            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Length.ToString("F2");//"F2" - 2 знака после запятой
            WidthTextBox.Text = _currentRectangle.Width.ToString("F2");
            ColorTextBox.Text = _currentRectangle.Colour.ToString();
            CenterCoordinatesTextBoxX.Text = _currentRectangle.Center.X.ToString("F2");
            CenterCoordinatesTextBoxY.Text = _currentRectangle.Center.Y.ToString("F2");
        }

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

            //string selected_item = EnumsListBox.SelectedItem.ToString();
            //Type enumType = Type.GetType(selected_item);
        
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