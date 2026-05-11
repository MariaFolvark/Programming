namespace Programming.View.Panels
{
    partial class SeasonHandleControl
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
            SeasonComboBox = new ComboBox();
            GoButton = new Button();
            ChooseSeasonLabel = new Label();
            SuspendLayout();
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(3, 28);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(187, 28);
            SeasonComboBox.TabIndex = 7;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(196, 28);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 6;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(3, 4);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(110, 20);
            ChooseSeasonLabel.TabIndex = 5;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonComboBox);
            Controls.Add(GoButton);
            Controls.Add(ChooseSeasonLabel);
            MaximumSize = new Size(304, 70);
            MinimumSize = new Size(304, 70);
            Name = "SeasonHandleControl";
            Size = new Size(304, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SeasonComboBox;
        private Button GoButton;
        private Label ChooseSeasonLabel;
    }
}
