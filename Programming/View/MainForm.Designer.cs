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
            groupBox1 = new GroupBox();
            EnumsListBox = new ListBox();
            IntValue = new Label();
            ValuesListBox = new ListBox();
            textBox1 = new TextBox();
            ChooseValueLabel = new Label();
            ChooseEnumerationLabel = new Label();
            tabControl1.SuspendLayout();
            Enums.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Enums);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 338);
            tabControl1.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(groupBox1);
            Enums.Location = new Point(4, 24);
            Enums.Margin = new Padding(3, 2, 3, 2);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3, 2, 3, 2);
            Enums.Size = new Size(692, 310);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(IntValue);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ChooseValueLabel);
            groupBox1.Controls.Add(ChooseEnumerationLabel);
            groupBox1.Location = new Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 287);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Location = new Point(15, 38);
            EnumsListBox.Margin = new Padding(3, 2, 3, 2);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.ScrollAlwaysVisible = true;
            EnumsListBox.Size = new Size(132, 139);
            EnumsListBox.TabIndex = 3;
            // 
            // IntValue
            // 
            IntValue.AutoSize = true;
            IntValue.Location = new Point(302, 21);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(55, 15);
            IntValue.TabIndex = 6;
            IntValue.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(164, 38);
            ValuesListBox.Margin = new Padding(3, 2, 3, 2);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.ScrollAlwaysVisible = true;
            ValuesListBox.Size = new Size(132, 139);
            ValuesListBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 38);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // ChooseValueLabel
            // 
            ChooseValueLabel.AutoSize = true;
            ChooseValueLabel.Location = new Point(164, 21);
            ChooseValueLabel.Name = "ChooseValueLabel";
            ChooseValueLabel.Size = new Size(81, 15);
            ChooseValueLabel.TabIndex = 5;
            ChooseValueLabel.Text = "Choose Value:";
            // 
            // ChooseEnumerationLabel
            // 
            ChooseEnumerationLabel.AutoSize = true;
            ChooseEnumerationLabel.Location = new Point(15, 21);
            ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            ChooseEnumerationLabel.Size = new Size(121, 15);
            ChooseEnumerationLabel.TabIndex = 4;
            ChooseEnumerationLabel.Text = "Choose Enumeration:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Programming";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            Enums.ResumeLayout(false);
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
    }
}
#endregion