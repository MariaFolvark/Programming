using Programming.Model;
using Programming.Model.Enums;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
        private Rectangles[] _rectangles;
        private Rectangles _currentRectangle;

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
            _rectangles = new Rectangles[5];

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
            }
            RectanglesListBox.SelectedIndex = 0;
            
        }
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            ParseButton.Click += ParseButton_Click;
            GoButton.Click += GoButton_Click;
            RectanglesListBox.SelectedIndexChanged += RectanglesLlistBox_SelectedIndexChanged;

        }

        private void RectanglesLlistBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex < 0 || RectanglesListBox.SelectedIndex >= _rectangles.Length)
                return;

            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Length.ToString("F2");//"F2" - 2 знака после запятой
            WidthTextBox.Text = _currentRectangle.Width.ToString("F2");
            ColorTextBox.Text = _currentRectangle.Colour.ToString();
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

        void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
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