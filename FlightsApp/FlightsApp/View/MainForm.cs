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
            DepartureTextBox.TextChanged += DepartureTextBox_TextChanged;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            DepartureTimeDateTimePicker.ValueChanged += DepartureTimeDateTimePicker_ValueChanged;
            FlightTimeTextBox.TextChanged += FlightTimeTextBox_TextChanged;
            FlightTypeComboBox.SelectedIndexChanged += FlightTypeComboBox_SelectedIndexChanged;
        }

        private void FlightTypeComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            int selectedIndex = FlightTypeComboBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex > FlightTypeComboBox.Items.Count) return;
            string selectedType = FlightTypeComboBox.SelectedItem.ToString();
            if (Enum.TryParse<FlightType>(selectedType, out var flightType))
            {
                current_flight.FlightType = flightType;
                flights[FlightsListBox.SelectedIndex].FlightType = flightType;
            }
        }

        private void FlightTimeTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            string input = FlightTimeTextBox.Text;
            try
            {
                if (!int.TryParse(input, out int value) || value < 0 || value > 1000)
                    { throw new ArgumentException(); }
                current_flight.FlightTime = value;
                flights[FlightsListBox.SelectedIndex].FlightTime = value;
            }
            catch { FlightTimeTextBox.Text = current_flight.FlightTime.ToString(); }
        }

        private void DepartureTimeDateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            DateTime input = DepartureTimeDateTimePicker.Value;
            try
            {
                if(input < DateTime.Today || input > DateTime.Today.AddDays(2)) { throw new ArgumentException(); }
                current_flight.DepartureTime = input;
                flights[FlightsListBox.SelectedIndex].DepartureTime = input;
                /*ClearFlightInfo();                
                Flight.SortFlightsByDepartureTime(flights);                
                UpdateListBox();
                UpdateFlightInfo(current_flight);*/
            }
            catch { DepartureTimeDateTimePicker.Value = current_flight.DepartureTime; }          
        }

        /*private void DepartureTimeDateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            DateTime input = DepartureTimeDateTimePicker.Value;
            try
            {
                if(input < DateTime.Today || input > DateTime.Today.AddDays(2)) { throw new ArgumentException(); }
                current_flight.DepartureTime = input;

                int current_id = current_flight.Id;
                ClearFlightInfo();
                Flight.SortFlightsByDepartureTime(flights);                
                UpdateFlightsInListBox();
                current_flight = Array.Find(flights, f => f.Id == current_id);

                FlightsListBox.SelectedIndex = Array.IndexOf(flights, current_flight);
                UpdateFlightInfo(current_flight);
            }
            catch { DepartureTimeDateTimePicker.Value = current_flight.DepartureTime; }          
        }*/
        /*private void DepartureTimeDateTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;

            DateTime input = DepartureTimeDateTimePicker.Value;

            try
            {
                if (input < DateTime.Today || input > DateTime.Today.AddDays(2))
                    throw new ArgumentException();

                current_flight.DepartureTime = input;

                int current_id = current_flight.Id;

                ClearFlightInfo();
                Flight.SortFlightsByDepartureTime(flights);
                UpdateFlightsInListBox();

                current_flight = Array.Find(flights, f => f != null && f.Id == current_id);

                int index = Array.IndexOf(flights, current_flight);
                if (index >= 0)
                    FlightsListBox.SelectedIndex = index;

                if (current_flight != null)
                    UpdateFlightInfo(current_flight);
            }
            catch
            {
                DepartureTimeDateTimePicker.Value = current_flight.DepartureTime;
            }
        }*/


        private void DestinationTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            string input = DestinationTextBox.Text;
            try
            {
                if (input.Length > 1000) { throw new ArgumentException(); }
                foreach (char c in input)
                {
                    if (!(char.IsLetter(c) || c == '-' || c == ' ')) { throw new ArgumentException(); }
                }
                current_flight.Destination = input;
                flights[FlightsListBox.SelectedIndex].Destination = input;
                current_flight.Name = current_flight.Departure + " - " + current_flight.Destination;
                flights[FlightsListBox.SelectedIndex].Name = current_flight.Name;
                UpdateFlightInListBox();
            }
            catch { DestinationTextBox.Text = current_flight.Destination; }
        }

        private void DepartureTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            string input = DepartureTextBox.Text;
            try
            {
                if (input.Length > 1000) { throw new ArgumentException(); }
                foreach (char c in input)
                {
                    if (!(char.IsLetter(c) || c == '-' || c == ' ')) { throw new ArgumentException(); }
                }
                current_flight.Departure = input;
                flights[FlightsListBox.SelectedIndex].Departure = input;
                current_flight.Name = current_flight.Departure + " - " + current_flight.Destination;
                flights[FlightsListBox.SelectedIndex].Name= current_flight.Name;
                UpdateFlightInListBox();
            }
            catch { DepartureTextBox.Text = current_flight.Departure; }
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
                flights[FlightsListBox.SelectedIndex].Name = current_flight.Name;
                UpdateFlightInListBox();
            }
            catch { FlightNameTextBox.Text = current_flight.Name; }
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

        private void UpdateListBox()
        {
            FlightsListBox.Items.Clear();
            /*for (int i = 0; i < flights.Length; i++)
            {
                FlightsListBox.Items.Add(flights[i].Name);
            }
            FlightsListBox.SelectedIndex = 0;
            current_flight = flights[0];*/

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
        private void UpdateFlightInListBox()
        {
            if (current_flight == null) return;
            FlightsListBox.Items[FlightsListBox.SelectedIndex] = current_flight.Name;
        }
        private void ClearFlightInfo()
        {
            FlightNameTextBox.Text = "";
            DepartureTextBox.Text = "";
            DestinationTextBox.Text = "";
            DepartureTimeDateTimePicker.Value = DateTime.Now;
            FlightTimeTextBox.Text = "";
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
