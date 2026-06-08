using FlightsApp.Model;
using FlightsApp.Model.Enums;

namespace FlightsApp
{
    public partial class MainForm : Form
    {
        //Type[] enumTypes = { typeof(FlightType), typeof(Russian—ities), typeof(ForeignCities)};

        Flight[] flights;
        Flight current_flight;

        public void MainForm_Load(object? sender, EventArgs e)
        {
            //string[] enums = { "FlightType", "Russian—ities", "ForeignCities" };
            flights = Model.Flight.RandomFlightsArray(5);
            current_flight = flights[0];
            for (int i = 0; i < flights.Length; i++)
            {
                FlightsListBox.Items.Add(flights[i].Name);
            }
            foreach (FlightType ft in Enum.GetValues(typeof(FlightType)))
            {
                FlightTypeComboBox.Items.Add(ft);
            }
            FlightsListBox.SelectedIndex = 0;

        }

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            FlightNameTextBox.TextChanged += FlightNameTextBox_TextChanged;
        }

        private void FlightsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < flights.Length)
            {
                current_flight = flights[selectedIndex];
                UpdateFlightInfo(current_flight);
            }
            else
            {
                current_flight = null;
                ClearFlightInfo();
            }

        }

        private void FlightNameTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            string input = FlightNameTextBox.Text;
            try
            {
                if (input.Length > 1000) { throw new ArgumentException(); }
                foreach (char c in input)
                {
                    if (!(char.IsLetter(c) || c == '-' || c == ' ')) { throw new ArgumentException(); }
                }
                current_flight.Name = input;
                UpdateFlightInListBox();
            }
            catch { FlightNameTextBox.Text = current_flight.Name; }
        }

        private void UpdateFlightInListBox()
        {
            if (current_flight == null) return;

            int selectedIndex = FlightsListBox.SelectedIndex;
            FlightsListBox.Items[selectedIndex] = current_flight.Name;
        }

        private void ClearFlightInfo()
        {
            FlightNameTextBox.Text = string.Empty;
            DepartureTextBox.Text = string.Empty;
            DestinationTextBox.Text = string.Empty;
            DepartureTimeDateTimePicker.Value = DateTime.Now;
            FlightTimeTextBox.Text = string.Empty;
            FlightTypeComboBox.SelectedIndex = -1;
        }
        private void UpdateFlightInfo(Flight flight)
        {
            if (flight == null) return;

            FlightNameTextBox.Text = flight.Name;
            DepartureTextBox.Text = flight.Departure;
            DestinationTextBox.Text = flight.Destination;
            DepartureTimeDateTimePicker.Value = flight.DepartureTime;
            FlightTimeTextBox.Text = flight.FlightTime.ToString();
            FlightTypeComboBox.SelectedItem = flight.FlightType;
        }
    }
}
