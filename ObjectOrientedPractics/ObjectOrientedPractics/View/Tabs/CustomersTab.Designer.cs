namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RightLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerDetailsPanel = new System.Windows.Forms.Panel();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.MainLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.CustomersGroupBox.SuspendLayout();
            this.CustomersLayoutTable.SuspendLayout();
            this.RightLayoutTable.SuspendLayout();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.CustomerDetailsPanel.SuspendLayout();
            this.MainLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Controls.Add(this.CustomersLayoutTable);
            this.CustomersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomersGroupBox.Location = new System.Drawing.Point(4, 4);
            this.CustomersGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.CustomersGroupBox.Size = new System.Drawing.Size(358, 558);
            this.CustomersGroupBox.TabIndex = 0;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersLayoutTable
            // 
            this.CustomersLayoutTable.ColumnCount = 2;
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CustomersLayoutTable.Controls.Add(this.CustomersListBox, 0, 0);
            this.CustomersLayoutTable.Controls.Add(this.AddButton, 0, 1);
            this.CustomersLayoutTable.Controls.Add(this.RemoveButton, 1, 1);
            this.CustomersLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersLayoutTable.Location = new System.Drawing.Point(8, 28);
            this.CustomersLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.CustomersLayoutTable.Name = "CustomersLayoutTable";
            this.CustomersLayoutTable.RowCount = 2;
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CustomersLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.CustomersLayoutTable.Size = new System.Drawing.Size(342, 522);
            this.CustomersLayoutTable.TabIndex = 0;
            // 
            // CustomersListBox
            // 
            this.CustomersLayoutTable.SetColumnSpan(this.CustomersListBox, 2);
            this.CustomersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(4, 4);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(334, 452);
            this.CustomersListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.Location = new System.Drawing.Point(4, 468);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(163, 50);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.Location = new System.Drawing.Point(175, 468);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(163, 50);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // RightLayoutTable
            // 
            this.RightLayoutTable.ColumnCount = 1;
            this.RightLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutTable.Controls.Add(this.SelectedCustomerGroupBox, 0, 0);
            this.RightLayoutTable.Controls.Add(this.Panel2, 0, 1);
            this.RightLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLayoutTable.Location = new System.Drawing.Point(366, 0);
            this.RightLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.RightLayoutTable.Name = "RightLayoutTable";
            this.RightLayoutTable.RowCount = 2;
            this.RightLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.RightLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.RightLayoutTable.Size = new System.Drawing.Size(551, 566);
            this.RightLayoutTable.TabIndex = 1;
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Controls.Add(this.CustomerDetailsPanel);
            this.SelectedCustomerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedCustomerGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(4, 4);
            this.SelectedCustomerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(543, 246);
            this.SelectedCustomerGroupBox.TabIndex = 0;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // CustomerDetailsPanel
            // 
            this.CustomerDetailsPanel.Controls.Add(this.IdLabel);
            this.CustomerDetailsPanel.Controls.Add(this.IdTextBox);
            this.CustomerDetailsPanel.Controls.Add(this.FullNameLabel);
            this.CustomerDetailsPanel.Controls.Add(this.FullNameTextBox);
            this.CustomerDetailsPanel.Controls.Add(this.AddressLabel);
            this.CustomerDetailsPanel.Controls.Add(this.AddressTextBox);
            this.CustomerDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDetailsPanel.Location = new System.Drawing.Point(8, 28);
            this.CustomerDetailsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerDetailsPanel.Name = "CustomerDetailsPanel";
            this.CustomerDetailsPanel.Size = new System.Drawing.Size(527, 210);
            this.CustomerDetailsPanel.TabIndex = 0;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdLabel.Location = new System.Drawing.Point(4, 9);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4);
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
            this.IdTextBox.Location = new System.Drawing.Point(91, 5);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(432, 27);
            this.IdTextBox.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullNameLabel.Location = new System.Drawing.Point(4, 49);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullNameTextBox.Location = new System.Drawing.Point(91, 45);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(432, 27);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressLabel.Location = new System.Drawing.Point(4, 84);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressTextBox.Location = new System.Drawing.Point(4, 111);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(519, 95);
            this.AddressTextBox.TabIndex = 5;
            // 
            // Panel2
            // 
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(4, 258);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(543, 304);
            this.Panel2.TabIndex = 4;
            // 
            // MainLayoutTable
            // 
            this.MainLayoutTable.ColumnCount = 2;
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainLayoutTable.Controls.Add(this.CustomersGroupBox, 0, 0);
            this.MainLayoutTable.Controls.Add(this.RightLayoutTable, 1, 0);
            this.MainLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainLayoutTable.Name = "MainLayoutTable";
            this.MainLayoutTable.RowCount = 1;
            this.MainLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutTable.Size = new System.Drawing.Size(917, 566);
            this.MainLayoutTable.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutTable);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(917, 566);
            this.CustomersGroupBox.ResumeLayout(false);
            this.CustomersLayoutTable.ResumeLayout(false);
            this.RightLayoutTable.ResumeLayout(false);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.CustomerDetailsPanel.ResumeLayout(false);
            this.CustomerDetailsPanel.PerformLayout();
            this.MainLayoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.TableLayoutPanel MainLayoutTable;
        private System.Windows.Forms.TableLayoutPanel CustomersLayoutTable;
        private System.Windows.Forms.TableLayoutPanel RightLayoutTable;
        private System.Windows.Forms.Panel CustomerDetailsPanel;
    }
}