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
            Enums = new TabPage();
            groupBox2 = new GroupBox();
            label2 = new Label();
            ParseButton = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            EnumsListBox = new ListBox();
            IntValue = new Label();
            ValuesListBox = new ListBox();
            textBox1 = new TextBox();
            ChooseValueLabel = new Label();
            ChooseEnumerationLabel = new Label();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 467);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(groupBox2);
            Enums.Controls.Add(groupBox1);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(792, 434);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(ParseButton);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(10, 273);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 137);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "День недели";
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
            // textBox2
            // 
            textBox2.Location = new Point(16, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Введите день недели";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Type value for parsing:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(IntValue);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ChooseValueLabel);
            groupBox1.Controls.Add(ChooseEnumerationLabel);
            groupBox1.Location = new Point(9, 7);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(773, 260);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
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
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(345, 28);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(68, 20);
            IntValue.TabIndex = 6;
            IntValue.Text = "Int value:";
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
            // textBox1
            // 
            textBox1.Location = new Point(345, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
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
            Enums.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage Enums;
        private TextBox textBox1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label IntValue;
        private Label ChooseValueLabel;
        private Label ChooseEnumerationLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button ParseButton;
        private TextBox textBox2;
        private Label label2;
    }
}
#endregion