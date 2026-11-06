namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemsLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SelectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemDetailsPanel = new System.Windows.Forms.Panel();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.MainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsGroupBox.SuspendLayout();
            this.ItemsLayoutTable.SuspendLayout();
            this.SelectedItemGroupBox.SuspendLayout();
            this.ItemDetailsPanel.SuspendLayout();
            this.MainLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            this.ItemsGroupBox.Controls.Add(this.ItemsLayoutTable);
            this.ItemsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ItemsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.ItemsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemsGroupBox.Name = "ItemsGroupBox";
            this.ItemsGroupBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ItemsGroupBox.Size = new System.Drawing.Size(272, 392);
            this.ItemsGroupBox.TabIndex = 0;
            this.ItemsGroupBox.TabStop = false;
            this.ItemsGroupBox.Text = "Items";
            // 
            // ItemsLayoutTable
            // 
            this.ItemsLayoutTable.ColumnCount = 2;
            this.ItemsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ItemsLayoutTable.Controls.Add(this.ItemsListBox, 0, 0);
            this.ItemsLayoutTable.Controls.Add(this.AddButton, 0, 1);
            this.ItemsLayoutTable.Controls.Add(this.RemoveButton, 1, 1);
            this.ItemsLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsLayoutTable.Location = new System.Drawing.Point(8, 28);
            this.ItemsLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsLayoutTable.Name = "ItemsLayoutTable";
            this.ItemsLayoutTable.RowCount = 2;
            this.ItemsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemsLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.ItemsLayoutTable.Size = new System.Drawing.Size(256, 356);
            this.ItemsLayoutTable.TabIndex = 0;
            // 
            // ItemsListBox
            // 
            this.ItemsLayoutTable.SetColumnSpan(this.ItemsListBox, 2);
            this.ItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(4, 4);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(248, 286);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.Location = new System.Drawing.Point(4, 302);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 50);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.Location = new System.Drawing.Point(132, 302);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(120, 50);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SelectedItemGroupBox
            // 
            this.SelectedItemGroupBox.Controls.Add(this.ItemDetailsPanel);
            this.SelectedItemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedItemGroupBox.Location = new System.Drawing.Point(284, 4);
            this.SelectedItemGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            this.SelectedItemGroupBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.SelectedItemGroupBox.Size = new System.Drawing.Size(412, 392);
            this.SelectedItemGroupBox.TabIndex = 1;
            this.SelectedItemGroupBox.TabStop = false;
            this.SelectedItemGroupBox.Text = "Selected Item";
            // 
            // ItemDetailsPanel
            // 
            this.ItemDetailsPanel.Controls.Add(this.IdLabel);
            this.ItemDetailsPanel.Controls.Add(this.IdTextBox);
            this.ItemDetailsPanel.Controls.Add(this.CostLabel);
            this.ItemDetailsPanel.Controls.Add(this.CostTextBox);
            this.ItemDetailsPanel.Controls.Add(this.NameLabel);
            this.ItemDetailsPanel.Controls.Add(this.NameTextBox);
            this.ItemDetailsPanel.Controls.Add(this.DescriptionLabel);
            this.ItemDetailsPanel.Controls.Add(this.DescriptionTextBox);
            this.ItemDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemDetailsPanel.Location = new System.Drawing.Point(8, 28);
            this.ItemDetailsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ItemDetailsPanel.Name = "ItemDetailsPanel";
            this.ItemDetailsPanel.Size = new System.Drawing.Size(396, 356);
            this.ItemDetailsPanel.TabIndex = 0;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdLabel.Location = new System.Drawing.Point(7, 12);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdTextBox.Location = new System.Drawing.Point(50, 9);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(344, 27);
            this.IdTextBox.TabIndex = 1;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostLabel.Location = new System.Drawing.Point(7, 52);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 20);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostTextBox.Location = new System.Drawing.Point(50, 49);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(344, 27);
            this.CostTextBox.TabIndex = 3;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            this.CostTextBox.Leave += new System.EventHandler(this.CostTextBox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameLabel.Location = new System.Drawing.Point(8, 83);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox.Location = new System.Drawing.Point(11, 106);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(383, 55);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(7, 175);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DescriptionTextBox.Location = new System.Drawing.Point(11, 198);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(383, 155);
            this.DescriptionTextBox.TabIndex = 7;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // MainLayoutTable
            // 
            this.MainLayoutTable.ColumnCount = 2;
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayoutTable.Controls.Add(this.ItemsGroupBox, 0, 0);
            this.MainLayoutTable.Controls.Add(this.SelectedItemGroupBox, 1, 0);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.RowCount = 1;
            this.MainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutTable.Size = new System.Drawing.Size(700, 400);
            this.MainLayoutTable.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutTable);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(700, 400);
            this.ItemsGroupBox.ResumeLayout(false);
            this.ItemsLayoutTable.ResumeLayout(false);
            this.SelectedItemGroupBox.ResumeLayout(false);
            this.ItemDetailsPanel.ResumeLayout(false);
            this.ItemDetailsPanel.PerformLayout();
            this.MainLayoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox ItemsGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.GroupBox SelectedItemGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TableLayoutPanel MainLayoutTable;
        private System.Windows.Forms.TableLayoutPanel ItemsLayoutTable;
        private System.Windows.Forms.Panel ItemDetailsPanel;
    }
}