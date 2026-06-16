using FlightsApp.Model;
using FlightsApp.Model.Enums;

namespace FlightsApp
{
    public partial class MainForm : Form
    {
        //Type[] enumTypes = { typeof(FlightType), typeof(Russian—ities), typeof(ForeignCities)};
        private Flight current_flight;
        private List<Flight> flights;
        public DateTime CurrentDateTime { get { return current_flight.DepartureTime; } }

        public void MainForm_Load(object? sender, EventArgs e)
        {
            //string[] enums = { "FlightType", "Russian—ities", "ForeignCities" };
            /*LoadFlightsFromFile();
            List<Flight> randomflights = Flight.RandomFlightsList(5);
            for (int i = 0; i < randomflights.Count; i++)
            {
                flights.Add(randomflights[i]);
            }
            flights = Flight.RandomFlightsList(5);*/

            LoadFlightsFromFile();
            if (flights == null || flights.Count == 0)
            {
                flights = Flight.RandomFlightsList(5);
            }
            
            current_flight = flights[0];
            for (int i = 0; i < flights.Count; i++)
            {
                FlightsListBox.Items.Add(Item(flights[i]));
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
            //LoadFlightsFromFile();
            this.FormClosing += MainForm_FormClosing;
            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            FlightNameTextBox.TextChanged += FlightNameTextBox_TextChanged;
            DepartureTextBox.TextChanged += DepartureTextBox_TextChanged;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            FlightTimeTextBox.TextChanged += FlightTimeTextBox_TextChanged;
            FlightTypeComboBox.SelectedIndexChanged += FlightTypeComboBox_SelectedIndexChanged;
            EditDateButton.Click += EditDateButton_Click;
            AddButton.Click += AddButton_Click;
            DeleteButton.Click += DeleteButton_Click;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFlightsToFile();
        }
        private void LoadFlightsFromFile()
        {
            if (File.Exists("flights.xml"))
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Flight>));
                using (var reader = new StreamReader("flights.xml"))
                {
                    flights = (List<Flight>)serializer.Deserialize(reader);
                }
            }
            else
            {
                flights = new List<Flight>();
            }
        }
        private void SaveFlightsToFile()
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Flight>));
            using (var writer = new StreamWriter("flights.xml"))
            {
                serializer.Serialize(writer, flights);
            }
        }
        private string Item(Flight flight)
        {
            if (flight == null) { return ""; }
            string name = flight.Name.PadRight(35);
            string item = $"{name}\t{flight.DepartureTime:HH:mm dd.MM}";
            return item;
        }

        private void DeleteButton_Click(object? sender, EventArgs e)
        {
            if (current_flight == null) return;
            int selectedInd = FlightsListBox.SelectedIndex;
            int newInd;
            switch (selectedInd)
            {
                case -1: return;
                case 0:
                    newInd = 0;
                    break;
                default:
                    newInd = selectedInd - 1;
                    break;
            }
            flights.RemoveAt(selectedInd);
            ClearFlightInfo();
            FlightsListBox.SelectedIndex = newInd;
            UpdateListBox();
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            Flight new_flight = new Flight();
            new_flight.DepartureTime = DateTime.Now;
            flights.Add(new_flight);
            FlightsListBox.Items.Add(Item(new_flight));
            FlightsListBox.SelectedIndex = flights.Count()-1;
        }
        private void EditDateButton_Click(object? sender, EventArgs e)
        {
            using (var inputForm = new View.InputDateTimeForm(this))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime input = inputForm.InputDateTime;
                    current_flight.DepartureTime = input;
                    flights[FlightsListBox.SelectedIndex].DepartureTime = input;
                    ClearFlightInfo();
                    Flight.SortFlightsByDepartureTime(flights);
                    UpdateListBox();
                    UpdateFlightInfo();
                }
            }
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
        private void DestinationTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepartureTextBox.Text)) return;
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
                DestinationTextBox.SelectionStart = DestinationTextBox.Text.Length;
                DestinationTextBox.SelectionLength = 0;
            }
            catch { DestinationTextBox.Text = current_flight.Destination; }
        }
        private void DepartureTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DepartureTextBox.Text)) return;
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
                flights[FlightsListBox.SelectedIndex].Name = current_flight.Name;
                UpdateFlightInListBox();
                DepartureTextBox.SelectionStart = DepartureTextBox.Text.Length;
                DepartureTextBox.SelectionLength = 0;
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
                FlightNameTextBox.SelectionStart = FlightNameTextBox.Text.Length;
                FlightNameTextBox.SelectionLength = 0;
            }
            catch { FlightNameTextBox.Text = current_flight.Name; }
        }

        private void FlightsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            int selectedIndex = FlightsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < flights.Count)
            {
                current_flight = flights[selectedIndex];
                UpdateFlightInfo();
            }
            else
            {
                current_flight = null;
                ClearFlightInfo();
            }
        }
        private void UpdateListBox()
        {
            if (flights.Count == 0)
            {
                ClearFlightInfo();
                FlightsListBox.Items.Clear();
                return;
            }
            int ind = FlightsListBox.SelectedIndex;
            FlightsListBox.Items.Clear();       
            for (int i = 0; i < flights.Count; i++)
            {
                FlightsListBox.Items.Add(Item(flights[i]));
            }
            FlightsListBox.SelectedIndex = ind;
        }
        private void UpdateFlightInListBox()
        {
            if (current_flight == null) return;
            FlightsListBox.Items[FlightsListBox.SelectedIndex] = Item(current_flight);
        }
        private void ClearFlightInfo()
        {
            FlightNameTextBox.Text = "";
            DepartureTextBox.Text = "";
            DestinationTextBox.Text = "";
            //DepartureTimeDateTimePicker.Value = DateTime.Now;
            FlightTimeTextBox.Text = "";
            //FlightTypeComboBox.SelectedIndex = -1;
        }
        private void UpdateFlightInfo()
        {           
            if (FlightsListBox.SelectedIndex == -1) return;
            int selected_ind = FlightsListBox.SelectedIndex;
            FlightNameTextBox.Text = flights[selected_ind].Name;
            DepartureTextBox.Text = flights[selected_ind].Departure;
            DestinationTextBox.Text = flights[selected_ind].Destination;
            DepartureTimeDateTimePicker.Value = flights[selected_ind].DepartureTime;
            FlightTimeTextBox.Text = flights[selected_ind].FlightTime.ToString();
            FlightTypeComboBox.SelectedItem = flights[selected_ind].FlightType;
        }
    }
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