namespace FlightsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FlightsListBox = new ListBox();
            SelectedFlightGroupBox = new GroupBox();
            DepartureTimeDateTimePicker = new DateTimePicker();
            FlightTypeLabel = new Label();
            FlightTypeComboBox = new ComboBox();
            FlightTimeLabel = new Label();
            FlightTimeTextBox = new TextBox();
            DepartureTimeLabel = new Label();
            DestinationTextBox = new TextBox();
            DepartureTextBox = new TextBox();
            FlightNameTextBox = new TextBox();
            DestinationLabel = new Label();
            DepartureLabel = new Label();
            FlightNameLabel = new Label();
            AddButton = new Button();
            EditDateButton = new Button();
            DeleteButton = new Button();
            SelectedFlightGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FlightsListBox
            // 
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.Location = new Point(12, 12);
            FlightsListBox.MaximumSize = new Size(246, 424);
            FlightsListBox.MinimumSize = new Size(246, 424);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(246, 424);
            FlightsListBox.TabIndex = 0;
            // 
            // SelectedFlightGroupBox
            // 
            SelectedFlightGroupBox.Controls.Add(DepartureTimeDateTimePicker);
            SelectedFlightGroupBox.Controls.Add(FlightTypeLabel);
            SelectedFlightGroupBox.Controls.Add(FlightTypeComboBox);
            SelectedFlightGroupBox.Controls.Add(FlightTimeLabel);
            SelectedFlightGroupBox.Controls.Add(FlightTimeTextBox);
            SelectedFlightGroupBox.Controls.Add(DepartureTimeLabel);
            SelectedFlightGroupBox.Controls.Add(DestinationTextBox);
            SelectedFlightGroupBox.Controls.Add(DepartureTextBox);
            SelectedFlightGroupBox.Controls.Add(FlightNameTextBox);
            SelectedFlightGroupBox.Controls.Add(DestinationLabel);
            SelectedFlightGroupBox.Controls.Add(DepartureLabel);
            SelectedFlightGroupBox.Controls.Add(FlightNameLabel);
            SelectedFlightGroupBox.Location = new Point(264, 12);
            SelectedFlightGroupBox.MaximumSize = new Size(569, 245);
            SelectedFlightGroupBox.MinimumSize = new Size(569, 245);
            SelectedFlightGroupBox.Name = "SelectedFlightGroupBox";
            SelectedFlightGroupBox.Size = new Size(569, 245);
            SelectedFlightGroupBox.TabIndex = 1;
            SelectedFlightGroupBox.TabStop = false;
            SelectedFlightGroupBox.Text = "Selected Flight";
            // 
            // DepartureTimeDateTimePicker
            // 
            DepartureTimeDateTimePicker.CustomFormat = "HH:mm dd.MM.yyyy";
            DepartureTimeDateTimePicker.Enabled = false;
            DepartureTimeDateTimePicker.Format = DateTimePickerFormat.Custom;
            DepartureTimeDateTimePicker.Location = new Point(128, 130);
            DepartureTimeDateTimePicker.Name = "DepartureTimeDateTimePicker";
            DepartureTimeDateTimePicker.Size = new Size(231, 27);
            DepartureTimeDateTimePicker.TabIndex = 12;
            // 
            // FlightTypeLabel
            // 
            FlightTypeLabel.AutoSize = true;
            FlightTypeLabel.Location = new Point(38, 199);
            FlightTypeLabel.Name = "FlightTypeLabel";
            FlightTypeLabel.Size = new Size(84, 20);
            FlightTypeLabel.TabIndex = 11;
            FlightTypeLabel.Text = "Flight Type:";
            // 
            // FlightTypeComboBox
            // 
            FlightTypeComboBox.FormattingEnabled = true;
            FlightTypeComboBox.Location = new Point(128, 196);
            FlightTypeComboBox.Name = "FlightTypeComboBox";
            FlightTypeComboBox.Size = new Size(231, 28);
            FlightTypeComboBox.TabIndex = 10;
            // 
            // FlightTimeLabel
            // 
            FlightTimeLabel.AutoSize = true;
            FlightTimeLabel.Location = new Point(36, 166);
            FlightTimeLabel.Name = "FlightTimeLabel";
            FlightTimeLabel.Size = new Size(86, 20);
            FlightTimeLabel.TabIndex = 9;
            FlightTimeLabel.Text = "Flight Time:";
            // 
            // FlightTimeTextBox
            // 
            FlightTimeTextBox.Location = new Point(128, 163);
            FlightTimeTextBox.Name = "FlightTimeTextBox";
            FlightTimeTextBox.Size = new Size(231, 27);
            FlightTimeTextBox.TabIndex = 8;
            // 
            // DepartureTimeLabel
            // 
            DepartureTimeLabel.AutoSize = true;
            DepartureTimeLabel.Location = new Point(6, 133);
            DepartureTimeLabel.Name = "DepartureTimeLabel";
            DepartureTimeLabel.Size = new Size(116, 20);
            DepartureTimeLabel.TabIndex = 7;
            DepartureTimeLabel.Text = "Departure Time:";
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(128, 97);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(231, 27);
            DestinationTextBox.TabIndex = 5;
            // 
            // DepartureTextBox
            // 
            DepartureTextBox.Location = new Point(128, 64);
            DepartureTextBox.Name = "DepartureTextBox";
            DepartureTextBox.Size = new Size(231, 27);
            DepartureTextBox.TabIndex = 4;
            // 
            // FlightNameTextBox
            // 
            FlightNameTextBox.Location = new Point(128, 31);
            FlightNameTextBox.Name = "FlightNameTextBox";
            FlightNameTextBox.Size = new Size(231, 27);
            FlightNameTextBox.TabIndex = 3;
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(34, 100);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(88, 20);
            DestinationLabel.TabIndex = 2;
            DestinationLabel.Text = "Destination:";
            // 
            // DepartureLabel
            // 
            DepartureLabel.AutoSize = true;
            DepartureLabel.Location = new Point(43, 67);
            DepartureLabel.Name = "DepartureLabel";
            DepartureLabel.Size = new Size(79, 20);
            DepartureLabel.TabIndex = 1;
            DepartureLabel.Text = "Departure:";
            // 
            // FlightNameLabel
            // 
            FlightNameLabel.AutoSize = true;
            FlightNameLabel.Location = new Point(29, 34);
            FlightNameLabel.Name = "FlightNameLabel";
            FlightNameLabel.Size = new Size(93, 20);
            FlightNameLabel.TabIndex = 0;
            FlightNameLabel.Text = "Flight Name:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(270, 280);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EditDateButton
            // 
            EditDateButton.Location = new Point(270, 315);
            EditDateButton.Name = "EditDateButton";
            EditDateButton.Size = new Size(94, 29);
            EditDateButton.TabIndex = 3;
            EditDateButton.Text = "Edit date";
            EditDateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(270, 350);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 576);
            Controls.Add(DeleteButton);
            Controls.Add(EditDateButton);
            Controls.Add(AddButton);
            Controls.Add(SelectedFlightGroupBox);
            Controls.Add(FlightsListBox);
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(866, 500);
            Name = "MainForm";
            Text = "FlightsApp";
            SelectedFlightGroupBox.ResumeLayout(false);
            SelectedFlightGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox FlightsListBox;
        private GroupBox SelectedFlightGroupBox;
        private Button AddButton;
        private Button EditDateButton;
        private Button DeleteButton;
        private Label FlightNameLabel;
        private Label DestinationLabel;
        private Label DepartureLabel;
        private TextBox FlightNameTextBox;
        private TextBox DepartureTextBox;
        private TextBox DestinationTextBox;
        private Label DepartureTimeLabel;
        private TextBox FlightTimeTextBox;
        private Label FlightTimeLabel;
        private ComboBox FlightTypeComboBox;
        private Label FlightTypeLabel;
        private DateTimePicker DepartureTimeDateTimePicker;
    }
}
