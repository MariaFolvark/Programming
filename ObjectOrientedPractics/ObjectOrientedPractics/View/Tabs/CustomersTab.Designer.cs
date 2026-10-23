namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.SelectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerGroupBox.SuspendLayout();
            this.CustomersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedCustomerGroupBox
            // 
            this.SelectedCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.AddressLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.CostTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdTextBox);
            this.SelectedCustomerGroupBox.Controls.Add(this.IdLabel);
            this.SelectedCustomerGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectedCustomerGroupBox.Location = new System.Drawing.Point(269, 3);
            this.SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            this.SelectedCustomerGroupBox.Size = new System.Drawing.Size(377, 210);
            this.SelectedCustomerGroupBox.TabIndex = 3;
            this.SelectedCustomerGroupBox.TabStop = false;
            this.SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(11, 143);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(353, 50);
            this.NameTextBox.TabIndex = 5;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressLabel.Location = new System.Drawing.Point(7, 120);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CostTextBox.Location = new System.Drawing.Point(92, 70);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(272, 27);
            this.CostTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FullNameLabel.Location = new System.Drawing.Point(7, 73);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdTextBox.Location = new System.Drawing.Point(92, 30);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 27);
            this.IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdLabel.Location = new System.Drawing.Point(7, 33);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersGroupBox.Controls.Add(this.RemoveButton);
            this.CustomersGroupBox.Controls.Add(this.AddButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(260, 327);
            this.CustomersGroupBox.TabIndex = 2;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveButton.Location = new System.Drawing.Point(132, 266);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(119, 51);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.Location = new System.Drawing.Point(7, 266);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(119, 51);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(7, 30);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(244, 224);
            this.CustomersListBox.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedCustomerGroupBox);
            this.Controls.Add(this.CustomersGroupBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(688, 460);
            this.SelectedCustomerGroupBox.ResumeLayout(false);
            this.SelectedCustomerGroupBox.PerformLayout();
            this.CustomersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedCustomerGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
    }
}
