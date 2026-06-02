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
            SelectedFlightGroupBox.Location = new Point(264, 12);
            SelectedFlightGroupBox.MaximumSize = new Size(569, 424);
            SelectedFlightGroupBox.MinimumSize = new Size(569, 424);
            SelectedFlightGroupBox.Name = "SelectedFlightGroupBox";
            SelectedFlightGroupBox.Size = new Size(569, 424);
            SelectedFlightGroupBox.TabIndex = 1;
            SelectedFlightGroupBox.TabStop = false;
            SelectedFlightGroupBox.Text = "Selected Flight";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 453);
            Controls.Add(SelectedFlightGroupBox);
            Controls.Add(FlightsListBox);
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(866, 500);
            Name = "MainForm";
            Text = "FlightsApp";
            ResumeLayout(false);
        }

        #endregion

        private ListBox FlightsListBox;
        private GroupBox SelectedFlightGroupBox;
    }
}
