namespace FlightsApp.View
{
    partial class InputDateTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label = new Label();
            DateTimePicker = new DateTimePicker();
            OKButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(12, 9);
            Label.Name = "Label";
            Label.Size = new Size(144, 20);
            Label.TabIndex = 0;
            Label.Text = "New Date and Time:";
            // 
            // DateTimePicker
            // 
            DateTimePicker.CustomFormat = "HH:mm dd.MM.yyyy";
            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.Location = new Point(12, 32);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(250, 27);
            DateTimePicker.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(12, 82);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(94, 29);
            OKButton.TabIndex = 2;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(168, 82);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // InputDateTimeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 123);
            Controls.Add(CancelButton);
            Controls.Add(OKButton);
            Controls.Add(DateTimePicker);
            Controls.Add(Label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputDateTimeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter New Date and Time";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private DateTimePicker DateTimePicker;
        private Button OKButton;
        private Button CancelButton;
    }
}