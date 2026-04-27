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
            SeasonComboBox = new ComboBox();
            GoButton = new Button();
            ChooseSeasonLabel = new Label();
            WeekdayParsingGroupBox = new GroupBox();
            WeekDayLlabel2 = new Label();
            ParseButton = new Button();
            WeekdayTextBox = new TextBox();
            WeekdayLabel1 = new Label();
            EnumerationsGroupBox = new GroupBox();
            EnumsListBox = new ListBox();
            IntValueLabel = new Label();
            ValuesListBox = new ListBox();
            IntValueTextBox = new TextBox();
            ChooseValueLabel = new Label();
            ChooseEnumerationLabel = new Label();
            ClassesTabPage = new TabPage();
            FilmGroupBox = new GroupBox();
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
            RectanglesGroupBox_in_Classes = new GroupBox();
            RectanglesIdTextBox_in_Classes = new TextBox();
            RectanglesIdLabel_in_Classes = new Label();
            CenterCoordinatesTextBoxY_in_Classes = new TextBox();
            CenterCoordinatesLabel_in_Classes = new Label();
            CenterCoordinatesTextBoxX_in_Classes = new TextBox();
            CenterCoordinatesLabelY_in_Classes = new Label();
            CenterCoordinatesLabelX_in_Classes = new Label();
            RectangleFindButton_in_Classes = new Button();
            ColorTextBox_in_Classes = new TextBox();
            ColorLabel_in_Classes = new Label();
            WidthTextBox_in_Classes = new TextBox();
            WidthLabel_in_Classes = new Label();
            LengthTextBox_in_Classes = new TextBox();
            LengthLabel_in_Classes = new Label();
            RectanglesListBox_in_Classes = new ListBox();
            RectanglesTabPage = new TabPage();
            RectanglesPanel = new Panel();
            HeightLabel_in_Rectangles = new Label();
            HeightTextBox_in_Rectangles = new TextBox();
            WidthLabel_in_Rectangles = new Label();
            WidthTextBox_in_Rectangles = new TextBox();
            YLabel_in_Rectangles = new Label();
            YTextBox_in_Rectangles = new TextBox();
            XTextBox_in_Rectangles = new TextBox();
            XLabel_in_Rectangles = new Label();
            IdTextBox_in_Rectangles = new TextBox();
            IdLabel_in_Rectangles = new Label();
            SelectedRectangleLabel_in_Rectangles = new Label();
            DeleteButton_in_Rectangles = new Button();
            AddButton_in_Rectangles = new Button();
            ListBox_in_Rectangles = new ListBox();
            RectanglesLabel_in_Rectangles = new Label();
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
            Rectangles.Size = new Size(956, 556);
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
            EnumsTabPage.Size = new Size(948, 523);
            EnumsTabPage.TabIndex = 0;
            EnumsTabPage.Text = "Enums";
            EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            SeasonHandleGroupBox.Controls.Add(SeasonComboBox);
            SeasonHandleGroupBox.Controls.Add(GoButton);
            SeasonHandleGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonHandleGroupBox.Location = new Point(353, 274);
            SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            SeasonHandleGroupBox.Size = new Size(337, 137);
            SeasonHandleGroupBox.TabIndex = 9;
            SeasonHandleGroupBox.TabStop = false;
            SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(16, 56);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(187, 28);
            SeasonComboBox.TabIndex = 4;
            // 
            // GoButton
            // 
            GoButton.Location = new Point(209, 56);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(94, 29);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(16, 32);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(110, 20);
            ChooseSeasonLabel.TabIndex = 0;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Controls.Add(WeekDayLlabel2);
            WeekdayParsingGroupBox.Controls.Add(ParseButton);
            WeekdayParsingGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayParsingGroupBox.Controls.Add(WeekdayLabel1);
            WeekdayParsingGroupBox.Location = new Point(6, 274);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(336, 137);
            WeekdayParsingGroupBox.TabIndex = 8;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekDayLlabel2
            // 
            WeekDayLlabel2.AutoSize = true;
            WeekDayLlabel2.Location = new Point(16, 85);
            WeekDayLlabel2.Name = "WeekDayLlabel2";
            WeekDayLlabel2.Size = new Size(98, 20);
            WeekDayLlabel2.TabIndex = 3;
            WeekDayLlabel2.Text = "День недели";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(216, 55);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(16, 55);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(194, 27);
            WeekdayTextBox.TabIndex = 1;
            WeekdayTextBox.Text = "Введите день недели";
            // 
            // WeekdayLabel1
            // 
            WeekdayLabel1.AutoSize = true;
            WeekdayLabel1.Location = new Point(16, 32);
            WeekdayLabel1.Name = "WeekdayLabel1";
            WeekdayLabel1.Size = new Size(158, 20);
            WeekdayLabel1.TabIndex = 0;
            WeekdayLabel1.Text = "Type value for parsing:";
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Controls.Add(IntValueLabel);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(IntValueTextBox);
            EnumerationsGroupBox.Controls.Add(ChooseValueLabel);
            EnumerationsGroupBox.Controls.Add(ChooseEnumerationLabel);
            EnumerationsGroupBox.Location = new Point(8, 7);
            EnumerationsGroupBox.Margin = new Padding(3, 4, 3, 4);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Padding = new Padding(3, 4, 3, 4);
            EnumerationsGroupBox.Size = new Size(682, 260);
            EnumerationsGroupBox.TabIndex = 7;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(17, 51);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(150, 184);
            EnumsListBox.TabIndex = 3;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(345, 28);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(68, 20);
            IntValueLabel.TabIndex = 6;
            IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(187, 51);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.ScrollAlwaysVisible = true;
            ValuesListBox.Size = new Size(150, 184);
            ValuesListBox.TabIndex = 1;
            // 
            // IntValueTextBox
            // 
            IntValueTextBox.Location = new Point(345, 51);
            IntValueTextBox.Name = "IntValueTextBox";
            IntValueTextBox.Size = new Size(125, 27);
            IntValueTextBox.TabIndex = 2;
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(187, 28);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(101, 20);
            ChooseValueLabel.TabIndex = 5;
            ChooseValueLabel.Text = "Choose Value:";
            // 
            // ChooseEnumerationLabel
            // 
            ChooseEnumerationLabel.AutoSize = true;
            ChooseEnumerationLabel.Location = new Point(17, 28);
            ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            ChooseEnumerationLabel.Size = new Size(149, 20);
            ChooseEnumerationLabel.TabIndex = 4;
            ChooseEnumerationLabel.Text = "Choose Enumeration:";
            // 
            // ClassesTabPage
            // 
            ClassesTabPage.Controls.Add(FilmGroupBox);
            ClassesTabPage.Controls.Add(RectanglesGroupBox_in_Classes);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(948, 523);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // FilmGroupBox
            // 
            FilmGroupBox.Controls.Add(RatingTextBox);
            FilmGroupBox.Controls.Add(RatingLabel);
            FilmGroupBox.Controls.Add(GenreTextBox);
            FilmGroupBox.Controls.Add(GenreLabel);
            FilmGroupBox.Controls.Add(FilmFindButton);
            FilmGroupBox.Controls.Add(YearOfReleaseTextBox);
            FilmGroupBox.Controls.Add(YearOfReleaseLabel);
            FilmGroupBox.Controls.Add(DurationTextBox);
            FilmGroupBox.Controls.Add(DurationLabel);
            FilmGroupBox.Controls.Add(TitleTextBox);
            FilmGroupBox.Controls.Add(TitleLabel);
            FilmGroupBox.Controls.Add(FilmListBox);
            FilmGroupBox.Location = new Point(342, 6);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(310, 380);
            FilmGroupBox.TabIndex = 1;
            FilmGroupBox.TabStop = false;
            FilmGroupBox.Text = "Film";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(162, 261);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 11;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Location = new Point(162, 238);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(55, 20);
            RatingLabel.TabIndex = 10;
            RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(162, 208);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(125, 27);
            GenreTextBox.TabIndex = 9;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(162, 185);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre:";
            // 
            // FilmFindButton
            // 
            FilmFindButton.Location = new Point(162, 301);
            FilmFindButton.Name = "FilmFindButton";
            FilmFindButton.Size = new Size(125, 29);
            FilmFindButton.TabIndex = 7;
            FilmFindButton.Text = "Find";
            FilmFindButton.UseVisualStyleBackColor = true;
            // 
            // YearOfReleaseTextBox
            // 
            YearOfReleaseTextBox.Location = new Point(162, 155);
            YearOfReleaseTextBox.Name = "YearOfReleaseTextBox";
            YearOfReleaseTextBox.Size = new Size(125, 27);
            YearOfReleaseTextBox.TabIndex = 6;
            // 
            // YearOfReleaseLabel
            // 
            YearOfReleaseLabel.AutoSize = true;
            YearOfReleaseLabel.Location = new Point(162, 132);
            YearOfReleaseLabel.Name = "YearOfReleaseLabel";
            YearOfReleaseLabel.Size = new Size(109, 20);
            YearOfReleaseLabel.TabIndex = 5;
            YearOfReleaseLabel.Text = "Year of release:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(162, 102);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
            DurationTextBox.TabIndex = 4;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(162, 79);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 3;
            DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(162, 49);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(125, 27);
            TitleTextBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(162, 26);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Title:";
            // 
            // FilmListBox
            // 
            FilmListBox.FormattingEnabled = true;
            FilmListBox.Location = new Point(6, 26);
            FilmListBox.Name = "FilmListBox";
            FilmListBox.Size = new Size(150, 304);
            FilmListBox.TabIndex = 0;
            // 
            // RectanglesGroupBox_in_Classes
            // 
            RectanglesGroupBox_in_Classes.Controls.Add(RectanglesIdTextBox_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(RectanglesIdLabel_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(CenterCoordinatesTextBoxY_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(CenterCoordinatesLabel_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(CenterCoordinatesTextBoxX_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(CenterCoordinatesLabelY_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(CenterCoordinatesLabelX_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(RectangleFindButton_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(ColorTextBox_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(ColorLabel_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(WidthTextBox_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(WidthLabel_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(LengthTextBox_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(LengthLabel_in_Classes);
            RectanglesGroupBox_in_Classes.Controls.Add(RectanglesListBox_in_Classes);
            RectanglesGroupBox_in_Classes.Location = new Point(8, 6);
            RectanglesGroupBox_in_Classes.Name = "RectanglesGroupBox_in_Classes";
            RectanglesGroupBox_in_Classes.Size = new Size(310, 380);
            RectanglesGroupBox_in_Classes.TabIndex = 0;
            RectanglesGroupBox_in_Classes.TabStop = false;
            RectanglesGroupBox_in_Classes.Text = "Rectangles";
            // 
            // RectanglesIdTextBox_in_Classes
            // 
            RectanglesIdTextBox_in_Classes.Location = new Point(162, 49);
            RectanglesIdTextBox_in_Classes.Name = "RectanglesIdTextBox_in_Classes";
            RectanglesIdTextBox_in_Classes.ReadOnly = true;
            RectanglesIdTextBox_in_Classes.Size = new Size(125, 27);
            RectanglesIdTextBox_in_Classes.TabIndex = 15;
            // 
            // RectanglesIdLabel_in_Classes
            // 
            RectanglesIdLabel_in_Classes.AutoSize = true;
            RectanglesIdLabel_in_Classes.Location = new Point(162, 26);
            RectanglesIdLabel_in_Classes.Name = "RectanglesIdLabel_in_Classes";
            RectanglesIdLabel_in_Classes.Size = new Size(25, 20);
            RectanglesIdLabel_in_Classes.TabIndex = 14;
            RectanglesIdLabel_in_Classes.Text = "Id:";
            // 
            // CenterCoordinatesTextBoxY_in_Classes
            // 
            CenterCoordinatesTextBoxY_in_Classes.Location = new Point(230, 284);
            CenterCoordinatesTextBoxY_in_Classes.Name = "CenterCoordinatesTextBoxY_in_Classes";
            CenterCoordinatesTextBoxY_in_Classes.ReadOnly = true;
            CenterCoordinatesTextBoxY_in_Classes.Size = new Size(57, 27);
            CenterCoordinatesTextBoxY_in_Classes.TabIndex = 13;
            // 
            // CenterCoordinatesLabel_in_Classes
            // 
            CenterCoordinatesLabel_in_Classes.AutoSize = true;
            CenterCoordinatesLabel_in_Classes.Location = new Point(162, 238);
            CenterCoordinatesLabel_in_Classes.Name = "CenterCoordinatesLabel_in_Classes";
            CenterCoordinatesLabel_in_Classes.Size = new Size(137, 20);
            CenterCoordinatesLabel_in_Classes.TabIndex = 12;
            CenterCoordinatesLabel_in_Classes.Text = "Center coordinates:";
            // 
            // CenterCoordinatesTextBoxX_in_Classes
            // 
            CenterCoordinatesTextBoxX_in_Classes.Location = new Point(162, 284);
            CenterCoordinatesTextBoxX_in_Classes.Name = "CenterCoordinatesTextBoxX_in_Classes";
            CenterCoordinatesTextBoxX_in_Classes.ReadOnly = true;
            CenterCoordinatesTextBoxX_in_Classes.Size = new Size(57, 27);
            CenterCoordinatesTextBoxX_in_Classes.TabIndex = 10;
            // 
            // CenterCoordinatesLabelY_in_Classes
            // 
            CenterCoordinatesLabelY_in_Classes.AutoSize = true;
            CenterCoordinatesLabelY_in_Classes.Location = new Point(230, 261);
            CenterCoordinatesLabelY_in_Classes.Name = "CenterCoordinatesLabelY_in_Classes";
            CenterCoordinatesLabelY_in_Classes.Size = new Size(17, 20);
            CenterCoordinatesLabelY_in_Classes.TabIndex = 9;
            CenterCoordinatesLabelY_in_Classes.Text = "Y";
            // 
            // CenterCoordinatesLabelX_in_Classes
            // 
            CenterCoordinatesLabelX_in_Classes.AutoSize = true;
            CenterCoordinatesLabelX_in_Classes.Location = new Point(162, 261);
            CenterCoordinatesLabelX_in_Classes.Name = "CenterCoordinatesLabelX_in_Classes";
            CenterCoordinatesLabelX_in_Classes.Size = new Size(18, 20);
            CenterCoordinatesLabelX_in_Classes.TabIndex = 8;
            CenterCoordinatesLabelX_in_Classes.Text = "X";
            // 
            // RectangleFindButton_in_Classes
            // 
            RectangleFindButton_in_Classes.Location = new Point(162, 324);
            RectangleFindButton_in_Classes.Name = "RectangleFindButton_in_Classes";
            RectangleFindButton_in_Classes.Size = new Size(125, 29);
            RectangleFindButton_in_Classes.TabIndex = 7;
            RectangleFindButton_in_Classes.Text = "Find";
            RectangleFindButton_in_Classes.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox_in_Classes
            // 
            ColorTextBox_in_Classes.Location = new Point(162, 208);
            ColorTextBox_in_Classes.Name = "ColorTextBox_in_Classes";
            ColorTextBox_in_Classes.Size = new Size(125, 27);
            ColorTextBox_in_Classes.TabIndex = 6;
            // 
            // ColorLabel_in_Classes
            // 
            ColorLabel_in_Classes.AutoSize = true;
            ColorLabel_in_Classes.Location = new Point(162, 185);
            ColorLabel_in_Classes.Name = "ColorLabel_in_Classes";
            ColorLabel_in_Classes.Size = new Size(48, 20);
            ColorLabel_in_Classes.TabIndex = 5;
            ColorLabel_in_Classes.Text = "Color:";
            // 
            // WidthTextBox_in_Classes
            // 
            WidthTextBox_in_Classes.Location = new Point(162, 155);
            WidthTextBox_in_Classes.Name = "WidthTextBox_in_Classes";
            WidthTextBox_in_Classes.Size = new Size(125, 27);
            WidthTextBox_in_Classes.TabIndex = 4;
            // 
            // WidthLabel_in_Classes
            // 
            WidthLabel_in_Classes.AutoSize = true;
            WidthLabel_in_Classes.Location = new Point(162, 132);
            WidthLabel_in_Classes.Name = "WidthLabel_in_Classes";
            WidthLabel_in_Classes.Size = new Size(52, 20);
            WidthLabel_in_Classes.TabIndex = 3;
            WidthLabel_in_Classes.Text = "Width:";
            // 
            // LengthTextBox_in_Classes
            // 
            LengthTextBox_in_Classes.Location = new Point(162, 102);
            LengthTextBox_in_Classes.Name = "LengthTextBox_in_Classes";
            LengthTextBox_in_Classes.Size = new Size(125, 27);
            LengthTextBox_in_Classes.TabIndex = 2;
            // 
            // LengthLabel_in_Classes
            // 
            LengthLabel_in_Classes.AutoSize = true;
            LengthLabel_in_Classes.Location = new Point(162, 79);
            LengthLabel_in_Classes.Name = "LengthLabel_in_Classes";
            LengthLabel_in_Classes.Size = new Size(57, 20);
            LengthLabel_in_Classes.TabIndex = 1;
            LengthLabel_in_Classes.Text = "Length:";
            // 
            // RectanglesListBox_in_Classes
            // 
            RectanglesListBox_in_Classes.FormattingEnabled = true;
            RectanglesListBox_in_Classes.Location = new Point(6, 26);
            RectanglesListBox_in_Classes.Name = "RectanglesListBox_in_Classes";
            RectanglesListBox_in_Classes.Size = new Size(150, 324);
            RectanglesListBox_in_Classes.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            RectanglesTabPage.Controls.Add(RectanglesPanel);
            RectanglesTabPage.Controls.Add(HeightLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(HeightTextBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(WidthLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(WidthTextBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(YLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(YTextBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(XTextBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(XLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(IdTextBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(IdLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(SelectedRectangleLabel_in_Rectangles);
            RectanglesTabPage.Controls.Add(DeleteButton_in_Rectangles);
            RectanglesTabPage.Controls.Add(AddButton_in_Rectangles);
            RectanglesTabPage.Controls.Add(ListBox_in_Rectangles);
            RectanglesTabPage.Controls.Add(RectanglesLabel_in_Rectangles);
            RectanglesTabPage.Location = new Point(4, 29);
            RectanglesTabPage.Name = "RectanglesTabPage";
            RectanglesTabPage.Padding = new Padding(3);
            RectanglesTabPage.Size = new Size(948, 523);
            RectanglesTabPage.TabIndex = 2;
            RectanglesTabPage.Text = "Rectangles";
            RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(362, 24);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(555, 474);
            RectanglesPanel.TabIndex = 15;
            // 
            // HeightLabel_in_Rectangles
            // 
            HeightLabel_in_Rectangles.AutoSize = true;
            HeightLabel_in_Rectangles.Location = new Point(31, 474);
            HeightLabel_in_Rectangles.Name = "HeightLabel_in_Rectangles";
            HeightLabel_in_Rectangles.Size = new Size(57, 20);
            HeightLabel_in_Rectangles.TabIndex = 14;
            HeightLabel_in_Rectangles.Text = "Height:";
            // 
            // HeightTextBox_in_Rectangles
            // 
            HeightTextBox_in_Rectangles.Location = new Point(94, 471);
            HeightTextBox_in_Rectangles.Name = "HeightTextBox_in_Rectangles";
            HeightTextBox_in_Rectangles.Size = new Size(125, 27);
            HeightTextBox_in_Rectangles.TabIndex = 13;
            // 
            // WidthLabel_in_Rectangles
            // 
            WidthLabel_in_Rectangles.AutoSize = true;
            WidthLabel_in_Rectangles.Location = new Point(36, 441);
            WidthLabel_in_Rectangles.Name = "WidthLabel_in_Rectangles";
            WidthLabel_in_Rectangles.Size = new Size(52, 20);
            WidthLabel_in_Rectangles.TabIndex = 12;
            WidthLabel_in_Rectangles.Text = "Width:";
            // 
            // WidthTextBox_in_Rectangles
            // 
            WidthTextBox_in_Rectangles.Location = new Point(94, 438);
            WidthTextBox_in_Rectangles.Name = "WidthTextBox_in_Rectangles";
            WidthTextBox_in_Rectangles.Size = new Size(125, 27);
            WidthTextBox_in_Rectangles.TabIndex = 11;
            // 
            // YLabel_in_Rectangles
            // 
            YLabel_in_Rectangles.AutoSize = true;
            YLabel_in_Rectangles.Location = new Point(68, 408);
            YLabel_in_Rectangles.Name = "YLabel_in_Rectangles";
            YLabel_in_Rectangles.Size = new Size(20, 20);
            YLabel_in_Rectangles.TabIndex = 10;
            YLabel_in_Rectangles.Text = "Y:";
            // 
            // YTextBox_in_Rectangles
            // 
            YTextBox_in_Rectangles.Location = new Point(94, 405);
            YTextBox_in_Rectangles.Name = "YTextBox_in_Rectangles";
            YTextBox_in_Rectangles.Size = new Size(125, 27);
            YTextBox_in_Rectangles.TabIndex = 9;
            // 
            // XTextBox_in_Rectangles
            // 
            XTextBox_in_Rectangles.Location = new Point(94, 372);
            XTextBox_in_Rectangles.Name = "XTextBox_in_Rectangles";
            XTextBox_in_Rectangles.Size = new Size(125, 27);
            XTextBox_in_Rectangles.TabIndex = 8;
            // 
            // XLabel_in_Rectangles
            // 
            XLabel_in_Rectangles.AutoSize = true;
            XLabel_in_Rectangles.Location = new Point(67, 375);
            XLabel_in_Rectangles.Name = "XLabel_in_Rectangles";
            XLabel_in_Rectangles.Size = new Size(21, 20);
            XLabel_in_Rectangles.TabIndex = 7;
            XLabel_in_Rectangles.Text = "X:";
            // 
            // IdTextBox_in_Rectangles
            // 
            IdTextBox_in_Rectangles.Location = new Point(94, 339);
            IdTextBox_in_Rectangles.Name = "IdTextBox_in_Rectangles";
            IdTextBox_in_Rectangles.ReadOnly = true;
            IdTextBox_in_Rectangles.Size = new Size(125, 27);
            IdTextBox_in_Rectangles.TabIndex = 6;
            // 
            // IdLabel_in_Rectangles
            // 
            IdLabel_in_Rectangles.AutoSize = true;
            IdLabel_in_Rectangles.Location = new Point(63, 342);
            IdLabel_in_Rectangles.Name = "IdLabel_in_Rectangles";
            IdLabel_in_Rectangles.Size = new Size(25, 20);
            IdLabel_in_Rectangles.TabIndex = 5;
            IdLabel_in_Rectangles.Text = "Id:";
            // 
            // SelectedRectangleLabel_in_Rectangles
            // 
            SelectedRectangleLabel_in_Rectangles.AutoSize = true;
            SelectedRectangleLabel_in_Rectangles.Location = new Point(25, 306);
            SelectedRectangleLabel_in_Rectangles.Name = "SelectedRectangleLabel_in_Rectangles";
            SelectedRectangleLabel_in_Rectangles.Size = new Size(139, 20);
            SelectedRectangleLabel_in_Rectangles.TabIndex = 4;
            SelectedRectangleLabel_in_Rectangles.Text = "Selected Rectangle:";
            // 
            // DeleteButton_in_Rectangles
            // 
            DeleteButton_in_Rectangles.FlatStyle = FlatStyle.Flat;
            DeleteButton_in_Rectangles.Image = Properties.Resources.DeleteButton;
            DeleteButton_in_Rectangles.Location = new Point(176, 242);
            DeleteButton_in_Rectangles.Name = "DeleteButton_in_Rectangles";
            DeleteButton_in_Rectangles.Size = new Size(131, 50);
            DeleteButton_in_Rectangles.TabIndex = 3;
            DeleteButton_in_Rectangles.UseVisualStyleBackColor = true;
            // 
            // AddButton_in_Rectangles
            // 
            AddButton_in_Rectangles.FlatStyle = FlatStyle.Flat;
            AddButton_in_Rectangles.Image = Properties.Resources.AddButton;
            AddButton_in_Rectangles.Location = new Point(25, 242);
            AddButton_in_Rectangles.Name = "AddButton_in_Rectangles";
            AddButton_in_Rectangles.Size = new Size(131, 50);
            AddButton_in_Rectangles.TabIndex = 2;
            AddButton_in_Rectangles.UseVisualStyleBackColor = true;
            // 
            // ListBox_in_Rectangles
            // 
            ListBox_in_Rectangles.FormattingEnabled = true;
            ListBox_in_Rectangles.Location = new Point(25, 47);
            ListBox_in_Rectangles.Name = "ListBox_in_Rectangles";
            ListBox_in_Rectangles.Size = new Size(331, 184);
            ListBox_in_Rectangles.TabIndex = 1;
            // 
            // RectanglesLabel_in_Rectangles
            // 
            RectanglesLabel_in_Rectangles.AutoSize = true;
            RectanglesLabel_in_Rectangles.Location = new Point(25, 24);
            RectanglesLabel_in_Rectangles.Name = "RectanglesLabel_in_Rectangles";
            RectanglesLabel_in_Rectangles.Size = new Size(84, 20);
            RectanglesLabel_in_Rectangles.TabIndex = 0;
            RectanglesLabel_in_Rectangles.Text = "Rectangles:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 556);
            Controls.Add(Rectangles);
            Name = "MainForm";
            Text = "Programming";
            Load += MainForm_Load;
            Rectangles.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            ClassesTabPage.ResumeLayout(false);
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            RectanglesGroupBox_in_Classes.ResumeLayout(false);
            RectanglesGroupBox_in_Classes.PerformLayout();
            RectanglesTabPage.ResumeLayout(false);
            RectanglesTabPage.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl Rectangles;
        private TabPage EnumsTabPage;
        private TextBox IntValueTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label ChooseEnumerationLabel;
        private GroupBox EnumerationsGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private Label WeekdayLabel1;
        private Button ParseButton;
        private TextBox WeekdayTextBox;
        private Label WeekDayLlabel2;
        private GroupBox SeasonHandleGroupBox;
        private ComboBox SeasonComboBox;
        private Button GoButton;
        private Label ChooseSeasonLabel;
        private TabPage ClassesTabPage;
        private GroupBox RectanglesGroupBox_in_Classes;
        private ListBox RectanglesListBox_in_Classes;
        private TextBox ColorTextBox_in_Classes;
        private Label ColorLabel_in_Classes;
        private TextBox WidthTextBox_in_Classes;
        private Label WidthLabel_in_Classes;
        private TextBox LengthTextBox_in_Classes;
        private Label LengthLabel_in_Classes;
        private Button RectangleFindButton_in_Classes;
        private GroupBox FilmGroupBox;
        private ListBox FilmListBox;
        private Button FilmFindButton;
        private TextBox YearOfReleaseTextBox;
        private Label YearOfReleaseLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private TextBox RatingTextBox;
        private Label RatingLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Label CenterCoordinatesLabel_in_Classes;
        private TextBox CenterCoordinatesTextBoxX_in_Classes;
        private Label CenterCoordinatesLabelY_in_Classes;
        private Label CenterCoordinatesLabelX_in_Classes;
        private TextBox CenterCoordinatesTextBoxY_in_Classes;
        private TextBox RectanglesIdTextBox_in_Classes;
        private Label RectanglesIdLabel_in_Classes;
        private TabPage RectanglesTabPage;
        private Label RectanglesLabel_in_Rectangles;
        private ListBox ListBox_in_Rectangles;
        private Label SelectedRectangleLabel_in_Rectangles;
        private Button DeleteButton_in_Rectangles;
        private Button AddButton_in_Rectangles;
        private TextBox IdTextBox_in_Rectangles;
        private Label IdLabel_in_Rectangles;
        private TextBox YTextBox_in_Rectangles;
        private TextBox XTextBox_in_Rectangles;
        private Label XLabel_in_Rectangles;
        private Label YLabel_in_Rectangles;
        private TextBox HeightTextBox_in_Rectangles;
        private Label WidthLabel_in_Rectangles;
        private TextBox WidthTextBox_in_Rectangles;
        private Label HeightLabel_in_Rectangles;
        private Panel RectanglesPanel;
    }
}
#endregion