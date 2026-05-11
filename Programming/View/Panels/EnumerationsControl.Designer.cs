namespace Programming.View.Panels
{
    partial class EnumerationsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            EnumsListBox = new ListBox();
            IntValueLabel = new Label();
            ValuesListBox = new ListBox();
            IntValueTextBox = new TextBox();
            ChooseValueLabel = new Label();
            ChooseEnumerationLabel = new Label();
            SuspendLayout();
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(4, 26);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(150, 184);
            EnumsListBox.TabIndex = 9;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(332, 3);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(68, 20);
            IntValueLabel.TabIndex = 12;
            IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(174, 26);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.ScrollAlwaysVisible = true;
            ValuesListBox.Size = new Size(150, 184);
            ValuesListBox.TabIndex = 7;
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(332, 26);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(125, 27);
            IntValueTextBox.TabIndex = 8;
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(174, 3);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(101, 20);
            ChooseValueLabel.TabIndex = 11;
            ChooseValueLabel.Text = "Choose Value:";
            // 
            // ChooseEnumerationLabel
            // 
            ChooseEnumerationLabel.AutoSize = true;
            ChooseEnumerationLabel.Location = new Point(4, 3);
            ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            ChooseEnumerationLabel.Size = new Size(149, 20);
            ChooseEnumerationLabel.TabIndex = 10;
            ChooseEnumerationLabel.Text = "Choose Enumeration:";
            // 
            // EnumerationsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EnumsListBox);
            Controls.Add(IntValueLabel);
            Controls.Add(ValuesListBox);
            Controls.Add(IntValueTextBox);
            Controls.Add(ChooseValueLabel);
            Controls.Add(ChooseEnumerationLabel);
            MaximumSize = new Size(480, 222);
            MinimumSize = new Size(480, 222);
            Name = "EnumerationsControl";
            Size = new Size(480, 222);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox EnumsListBox;
        private Label IntValueLabel;
        private ListBox ValuesListBox;
        private TextBox IntValueTextBox;
        private Label ChooseValueLabel;
        private Label ChooseEnumerationLabel;
    }
}
