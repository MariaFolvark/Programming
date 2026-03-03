using Programming.Model.Enums;
using System.Collections;
using System.Windows.Forms;

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
            //ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
            //ValuesListBox.Items.AddRange()
            //textBox1.Text = ((int)Enum.Parse(typeof(Colors), "Red")).ToString();
        }
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;

        }

        void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();

            int selectedIndex = EnumsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= enumTypes.Length)
                return;

            Type enumType = enumTypes[selectedIndex];

            // Получаем значения enum
            var values = Enum.GetValues(enumType);
            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value.ToString());
            }

            //string selected_item = EnumsListBox.SelectedItem.ToString();
            //Type enumType = Type.GetType(selected_item);
        
        }

        void ValuesListBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            string selected_item = EnumsListBox.SelectedItem.ToString();
            Type enumType = Type.GetType(selected_item);
            object enumValue = Enum.Parse(enumType, selected_item); // Преобразовать имя в значение перечисления
            int numberValue = (int)enumValue; // Преобразовать к числовому значению
            textBox1.Text = numberValue.ToString(); // Отобразить в TextBox
        }

    }
}
//EnumsListBox_SelectedIndexChanged, ValuesListBox_SelectedIndexChanged
