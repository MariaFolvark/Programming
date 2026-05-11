namespace Programming.View.Panels
{
    partial class FilmControl
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
            RatingTextBox = new TextBox();
            RatingLabel = new Label();
            GenreTextBox = new TextBox();
            GenreLabel = new Label();
            FilmFindButton = new Button();
            YearOfReleaseTextBox = new TextBox();
            YearOfReleaseLabel = new Label();
            DurationTextBox = new TextBox();
            DurationLabel = new Label();
            TitleTextBox = new TextBox();
            TitleLabel = new Label();
            FilmListBox = new ListBox();
            SuspendLayout();
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(159, 238);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 23;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(159, 215);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 22;
            RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(159, 185);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 21;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(159, 162);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 20;
            GenreLabel.Text = "Genre:";
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(159, 278);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(125, 29);
            FilmFindButton.TabIndex = 19;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            // 
            // YearOfReleaseTextBox
            // 
            YearOfReleaseTextBox.Location = new Point(159, 132);
            YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            YearOfReleaseTextBox.Size = new Size(125, 27);
            YearOfReleaseTextBox.TabIndex = 18;
            // 
            // YearOfReleaseLabel
            // 
            YearOfReleaseLabel.AutoSize = true;
            YearOfReleaseLabel.Location = new Point(159, 109);
            YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            YearOfReleaseLabel.Size = new Size(109, 20);
            YearOfReleaseLabel.TabIndex = 17;
            YearOfReleaseLabel.Text = "Year of release:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(159, 79);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 16;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(159, 56);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 15;
            DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(159, 26);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(125, 27);
            TitleTextBox.TabIndex = 14;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(159, 3);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 13;
            TitleLabel.Text = "Title:";
            // 
            // FilmListBox
            // 
            FilmListBox.FormattingEnabled = true;
            FilmListBox.Location = new Point(3, 3);
            FilmListBox.Name = "FilmListBox";
            FilmListBox.Size = new Size(150, 304);
            FilmListBox.TabIndex = 12;
            // 
            // FilmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RatingTextBox);
            Controls.Add(RatingLabel);
            Controls.Add(GenreTextBox);
            Controls.Add(GenreLabel);
            Controls.Add(FilmFindButton);
            Controls.Add(YearOfReleaseTextBox);
            Controls.Add(YearOfReleaseLabel);
            Controls.Add(DurationTextBox);
            Controls.Add(DurationLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleLabel);
            Controls.Add(FilmListBox);
            MaximumSize = new Size(295, 326);
            MinimumSize = new Size(295, 326);
            Name = "FilmControl";
            Size = new Size(295, 326);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Button FilmFindButton;
        private TextBox YearOfReleaseTextBox;
        private Label YearOfReleaseLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private ListBox FilmListBox;
    }
}
