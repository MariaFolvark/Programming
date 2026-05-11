using Programming.Model;
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
    public partial class FilmControl : UserControl
    {
        private Film[] _films;
        private Film _currentFilm;
        public FilmControl()
        {
            InitializeComponent();
            this.Load += FilmControl_Load;
            FilmListBox.SelectedIndexChanged += FilmListBox_SelectedIndexChanged;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            YearOfReleaseTextBox.TextChanged += YearOfReleaseTextBox_TextChanged;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            FilmFindButton.Click += FilmFindButton_Click;
        }

        private void FilmControl_Load(object? sender, EventArgs e)
        {
            _films = Film.RandomFilmsArray(5);
            for (int i = 0; i < _films.Length; i++)
            {
                FilmListBox.Items.Add(_films[i].Title);
            }
            FilmListBox.SelectedIndex = 0;
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

    }
}
