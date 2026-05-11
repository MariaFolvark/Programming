namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            WeekDayLlabel2 = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            WeekdayLabel1 = new Label();
            SuspendLayout();
            // 
            // WeekDayLlabel2
            // 
            WeekDayLlabel2.AutoSize = true;
            WeekDayLlabel2.Location = new Point(3, 58);
            WeekDayLlabel2.Name = "WeekDayLlabel2";
            WeekDayLlabel2.Size = new Size(98, 20);
            WeekDayLlabel2.TabIndex = 7;
            WeekDayLlabel2.Text = "День недели";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(203, 28);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 6;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(3, 28);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(194, 27);
            WeekdayTextBox.TabIndex = 5;
            WeekdayTextBox.Text = "Введите день недели";
            // 
            // WeekdayLabel1
            // 
            WeekdayLabel1.AutoSize = true;
            WeekdayLabel1.Location = new Point(3, 5);
            WeekdayLabel1.Name = "WeekdayLabel1";
            WeekdayLabel1.Size = new Size(158, 20);
            WeekdayLabel1.TabIndex = 4;
            WeekdayLabel1.Text = "Type value for parsing:";
            // 
            // WeekdayParsingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekDayLlabel2);
            Controls.Add(ParseButton);
            Controls.Add(WeekdayTextBox);
            Controls.Add(WeekdayLabel1);
            MaximumSize = new Size(308, 86);
            MinimumSize = new Size(308, 86);
            Name = "WeekdayParsingControl";
            Size = new Size(308, 86);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WeekDayLlabel2;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label WeekdayLabel1;
    }
}
