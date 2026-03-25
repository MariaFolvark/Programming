using System.Windows.Forms;

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
            tabControl1 = new TabControl();
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
            RectanglesGroupBox = new GroupBox();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            LenghtTextBox = new TextBox();
            LenghtLabel = new Label();
            RectanglesListBox = new ListBox();
            FindButton = new Button();
            tabControl1.SuspendLayout();
            EnumsTabPage.SuspendLayout();
            SeasonHandleGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            ClassesTabPage.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(EnumsTabPage);
            tabControl1.Controls.Add(ClassesTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 467);
            tabControl1.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            EnumsTabPage.Controls.Add(SeasonHandleGroupBox);
            EnumsTabPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsTabPage.Controls.Add(EnumerationsGroupBox);
            EnumsTabPage.Location = new Point(4, 29);
            EnumsTabPage.Name = "EnumsTabPage";
            EnumsTabPage.Padding = new Padding(3);
            EnumsTabPage.Size = new Size(792, 434);
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
            SeasonHandleGroupBox.Size = new Size(428, 137);
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
            EnumerationsGroupBox.Size = new Size(773, 260);
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
            ClassesTabPage.Controls.Add(RectanglesGroupBox);
            ClassesTabPage.Location = new Point(4, 29);
            ClassesTabPage.Name = "ClassesTabPage";
            ClassesTabPage.Padding = new Padding(3);
            ClassesTabPage.Size = new Size(792, 434);
            ClassesTabPage.TabIndex = 1;
            ClassesTabPage.Text = "Classes";
            ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(ColorLabel);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(LenghtTextBox);
            RectanglesGroupBox.Controls.Add(LenghtLabel);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(8, 6);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(387, 291);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(162, 155);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 6;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(162, 132);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(45, 20);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(162, 102);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 4;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(162, 79);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(49, 20);
            WidthLabel.TabIndex = 3;
            WidthLabel.Text = "Width:";
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(162, 49);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(125, 27);
            LenghtTextBox.TabIndex = 2;
            // 
            // LenghtLabel
            // 
            LenghtLabel.AutoSize = true;
            LenghtLabel.Location = new Point(162, 26);
            LenghtLabel.Name = "LenghtLabel";
            LenghtLabel.Size = new Size(54, 20);
            LenghtLabel.TabIndex = 1;
            LenghtLabel.Text = "Lenght:";
            // 
            // RectanglesLlistBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(150, 204);
            RectanglesListBox.TabIndex = 0;
            // 
            // FindButton
            // 
            FindButton.Location = new Point(162, 201);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(125, 29);
            FindButton.TabIndex = 7;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            EnumsTabPage.ResumeLayout(false);
            SeasonHandleGroupBox.ResumeLayout(false);
            SeasonHandleGroupBox.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            ClassesTabPage.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
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
        private GroupBox RectanglesGroupBox;
        private ListBox RectanglesListBox;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LenghtTextBox;
        private Label LenghtLabel;
        private Button FindButton;
    }
}
#endregion