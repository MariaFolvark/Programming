using Programming.Model.Enums;
using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
        public void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            textBox1.Text = ((int)Enum.Parse(typeof(Colors), "Red")).ToString();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonComboBox.SelectedIndex = 0;
        }
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            ParseButton.Click += ParseButton_Click;
            GoButton.Click += GoButton_Click;

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
            string input = textBox2.Text.Trim();

            try
            {
                Weekday day;
                if (Enum.TryParse<Weekday>(input, true, out day) && Enum.IsDefined(typeof(Weekday), day))//true - игнор регистр букв
                {
                    label2.Text = $"Это день недели ({day} = {(int)day})";

                }
                else
                {
                    label2.Text = "Нет такого дня недели";
                }
            }
            catch (Exception ex)
            {
                label2.Text = "Нет такого дня недели";
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
            textBox1.Text = numberValue.ToString();

        }


    }
}