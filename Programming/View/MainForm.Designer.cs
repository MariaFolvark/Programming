namespace Programming
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
            Rectangles = new TabControl();
            EnumsTabPage = new TabPage();
            SeasonHandleGroupBox = new GroupBox();
            seasonHandleControl1 = new View.Panels.SeasonHandleControl();
            WeekdayParsingGroupBox = new GroupBox();
            weekdayParsingControl1 = new View.Panels.WeekdayParsingControl();
            EnumerationsGroupBox = new GroupBox();
            enumerationsControl1 = new View.Panels.EnumerationsControl();
            ClassesTabPage = new TabPage();
            FilmGroupBox = new GroupBox();
            RectanglesGroupBox_in_Classes = new GroupBox();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            RectanglesTabPage = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            filmControl1 = new View.Panels.FilmControl();
            Rectangles.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            FilmGroupBox.SuspendLayout();
            RectanglesGroupBox_in_Classes.SuspendLayout();
            RectanglesTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(EnumsTabPage);
            Rectangles.Controls.Add(ClassesTabPage);
            Rectangles.Controls.Add(RectanglesTabPage);
            Rectangles.Dock = DockStyle.Fill;
            Rectangles.Location = new Point(0, 0);
            Rectangles.Name = "Rectangles";
            Rectangles.SelectedIndex = 0;
            Rectangles.Size = new Size(923, 547);
            Rectangles.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(SeasonHandleGroupBox);
            EnumsTabPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsTabPage.Controls.Add(EnumerationsGroupBox);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(915, 514);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(seasonHandleControl1);
            SeasonHandleGroupBox.Location = new Point(353, 274);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(337, 137);
            SeasonHandleGroupBox.TabIndex = 9;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl1
            // 
            seasonHandleControl1.Location = new Point(6, 26);
            seasonHandleControl1.MaximumSize = new Size(304, 70);
            seasonHandleControl1.MinimumSize = new Size(304, 70);
            seasonHandleControl1.Name = "seasonHandleControl1";
            seasonHandleControl1.Size = new Size(304, 70);
            seasonHandleControl1.TabIndex = 0;
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(weekdayParsingControl1);
            WeekdayParsingGroupBox.Location = new Point(6, 274);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(336, 137);
            WeekdayParsingGroupBox.TabIndex = 8;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl1
            // 
            weekdayParsingControl1.Location = new Point(6, 26);
            weekdayParsingControl1.MaximumSize = new Size(308, 86);
            weekdayParsingControl1.MinimumSize = new Size(308, 86);
            weekdayParsingControl1.Name = "weekdayParsingControl1";
            weekdayParsingControl1.Size = new Size(308, 86);
            weekdayParsingControl1.TabIndex = 0;
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(enumerationsControl1);
            EnumerationsGroupBox.Location = new Point(8, 7);
            EnumerationsGroupBox.Margin = new Padding(3, 4, 3, 4);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Padding = new Padding(3, 4, 3, 4);
            EnumerationsGroupBox.Size = new Size(682, 260);
            EnumerationsGroupBox.TabIndex = 7;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Location = new Point(6, 27);
            enumerationsControl1.MaximumSize = new Size(480, 222);
            enumerationsControl1.MinimumSize = new Size(480, 222);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(480, 222);
            enumerationsControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(FilmGroupBox);
            ClassesTabPage.Controls.Add(RectanglesGroupBox_in_Classes);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(915, 514);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmGroupBox
            // 
            FilmGroupBox.Controls.Add(filmControl1);
            FilmGroupBox.Location = new Point(342, 6);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(310, 380);
            FilmGroupBox.TabIndex = 1;
            FilmGroupBox.TabStop = false;
            FilmGroupBox.Text = "Film";
            // 
            // RectanglesGroupBox_in_Classes
            // 
            RectanglesGroupBox_in_Classes.Controls.Add(rectanglesControl1);
            RectanglesGroupBox_in_Classes.Location = new Point(8, 6);
            RectanglesGroupBox_in_Classes.Name = "RectanglesGroupBox_in_Classes";
            RectanglesGroupBox_in_Classes.Size = new Size(310, 380);
            RectanglesGroupBox_in_Classes.TabIndex = 0;
            RectanglesGroupBox_in_Classes.TabStop = false;
            RectanglesGroupBox_in_Classes.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(6, 26);
            rectanglesControl1.MaximumSize = new Size(298, 344);
            rectanglesControl1.MinimumSize = new Size(298, 344);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(298, 344);
            rectanglesControl1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(rectanglesCollisionControl1);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(915, 514);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.AutoSize = true;
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(909, 508);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // filmControl1
            // 
            filmControl1.Location = new Point(6, 26);
            filmControl1.MaximumSize = new Size(295, 326);
            filmControl1.MinimumSize = new Size(295, 326);
            filmControl1.Name = "filmControl1";
            filmControl1.Size = new Size(295, 326);
            filmControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(923, 547);
            Controls.Add(Rectangles);
            MaximumSize = new Size(1000, 1000);
            Name = "MainForm";
            Text = "Programming";
            Load += MainForm_Load;
            Rectangles.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            SeasonHandleGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.ResumeLayout(false);
            ClassesTabPage.ResumeLayout(false);
            FilmGroupBox.ResumeLayout(false);
            RectanglesGroupBox_in_Classes.ResumeLayout(false);
            RectanglesTabPage.ResumeLayout(false);
            RectanglesTabPage.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl Rectangles;
        private TabPage EnumsTabPage;
        private GroupBox EnumerationsGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private GroupBox SeasonHandleGroupBox;
        private TabPage ClassesTabPage;
        private GroupBox RectanglesGroupBox_in_Classes;
        private GroupBox FilmGroupBox;
        private TabPage RectanglesTabPage;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsControl enumerationsControl1;
        private View.Panels.WeekdayParsingControl weekdayParsingControl1;
        private View.Panels.SeasonHandleControl seasonHandleControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
        private View.Panels.FilmControl filmControl1;
    }
}
#endregion