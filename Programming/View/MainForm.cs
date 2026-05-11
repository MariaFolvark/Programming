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

        public void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };

        }
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 600);
            this.MaximumSize = new Size(1400, 800);                     
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