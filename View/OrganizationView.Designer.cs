namespace IS_5
{
    partial class OrganizationView
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TypeOwnerComboBox = new System.Windows.Forms.ComboBox();
            this.TypeOrganizationComboBox = new System.Windows.Forms.ComboBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.KPPTextBox = new System.Windows.Forms.TextBox();
            this.TaxIdenNumTextBox = new System.Windows.Forms.TextBox();
            this.NameOrgTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateOrgButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.NumberOfPage = new System.Windows.Forms.NumericUpDown();
            this.SelectPageButton = new System.Windows.Forms.Button();
            this.PagesSize = new System.Windows.Forms.NumericUpDown();
            this.NumberPageLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.OrgDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOwnOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOwnCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TypeOrgCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FiltrsGroupBox = new System.Windows.Forms.GroupBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrsButton = new System.Windows.Forms.Button();
            this.InsertUpdateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgDataGrid)).BeginInit();
            this.FiltrsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertUpdateGroupBox
            // 
            this.InsertUpdateGroupBox.Controls.Add(this.CancelButton);
            this.InsertUpdateGroupBox.Controls.Add(this.OkButton);
            this.InsertUpdateGroupBox.Controls.Add(this.label8);
            this.InsertUpdateGroupBox.Controls.Add(this.label7);
            this.InsertUpdateGroupBox.Controls.Add(this.label6);
            this.InsertUpdateGroupBox.Controls.Add(this.label5);
            this.InsertUpdateGroupBox.Controls.Add(this.TypeOwnerComboBox);
            this.InsertUpdateGroupBox.Controls.Add(this.TypeOrganizationComboBox);
            this.InsertUpdateGroupBox.Controls.Add(this.AddressTextBox);
            this.InsertUpdateGroupBox.Controls.Add(this.KPPTextBox);
            this.InsertUpdateGroupBox.Controls.Add(this.TaxIdenNumTextBox);
            this.InsertUpdateGroupBox.Controls.Add(this.NameOrgTextBox);
            this.InsertUpdateGroupBox.Controls.Add(this.label4);
            this.InsertUpdateGroupBox.Controls.Add(this.label3);
            this.InsertUpdateGroupBox.Location = new System.Drawing.Point(362, 50);
            this.InsertUpdateGroupBox.Name = "InsertUpdateGroupBox";
            this.InsertUpdateGroupBox.Size = new System.Drawing.Size(307, 354);
            this.InsertUpdateGroupBox.TabIndex = 1;
            this.InsertUpdateGroupBox.TabStop = false;
            this.InsertUpdateGroupBox.Text = "Организация";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(222, 325);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(141, 325);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 15;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Вид";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Тип";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "КПП";
            // 
            // TypeOwnerComboBox
            // 
            this.TypeOwnerComboBox.FormattingEnabled = true;
            this.TypeOwnerComboBox.Location = new System.Drawing.Point(6, 268);
            this.TypeOwnerComboBox.Name = "TypeOwnerComboBox";
            this.TypeOwnerComboBox.Size = new System.Drawing.Size(291, 24);
            this.TypeOwnerComboBox.TabIndex = 10;
            // 
            // TypeOrganizationComboBox
            // 
            this.TypeOrganizationComboBox.FormattingEnabled = true;
            this.TypeOrganizationComboBox.Location = new System.Drawing.Point(6, 222);
            this.TypeOrganizationComboBox.Name = "TypeOrganizationComboBox";
            this.TypeOrganizationComboBox.Size = new System.Drawing.Size(291, 24);
            this.TypeOrganizationComboBox.TabIndex = 9;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(6, 178);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(291, 22);
            this.AddressTextBox.TabIndex = 8;
            // 
            // KPPTextBox
            // 
            this.KPPTextBox.Location = new System.Drawing.Point(6, 134);
            this.KPPTextBox.Name = "KPPTextBox";
            this.KPPTextBox.Size = new System.Drawing.Size(291, 22);
            this.KPPTextBox.TabIndex = 7;
            // 
            // TaxIdenNumTextBox
            // 
            this.TaxIdenNumTextBox.Location = new System.Drawing.Point(6, 90);
            this.TaxIdenNumTextBox.Name = "TaxIdenNumTextBox";
            this.TaxIdenNumTextBox.Size = new System.Drawing.Size(291, 22);
            this.TaxIdenNumTextBox.TabIndex = 6;
            // 
            // NameOrgTextBox
            // 
            this.NameOrgTextBox.Location = new System.Drawing.Point(6, 46);
            this.NameOrgTextBox.Name = "NameOrgTextBox";
            this.NameOrgTextBox.Size = new System.Drawing.Size(291, 22);
            this.NameOrgTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название";
            // 
            // CreateOrgButton
            // 
            this.CreateOrgButton.Location = new System.Drawing.Point(928, 12);
            this.CreateOrgButton.Name = "CreateOrgButton";
            this.CreateOrgButton.Size = new System.Drawing.Size(90, 23);
            this.CreateOrgButton.TabIndex = 0;
            this.CreateOrgButton.Text = "Добавить";
            this.CreateOrgButton.UseVisualStyleBackColor = true;
            this.CreateOrgButton.Click += new System.EventHandler(this.CreateOrgButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(888, 419);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(130, 23);
            this.NextPageButton.TabIndex = 2;
            this.NextPageButton.Text = "След. страница";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Location = new System.Drawing.Point(752, 419);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(130, 23);
            this.PreviousPageButton.TabIndex = 3;
            this.PreviousPageButton.Text = "Пред. страница";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // NumberOfPage
            // 
            this.NumberOfPage.Location = new System.Drawing.Point(547, 419);
            this.NumberOfPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPage.Name = "NumberOfPage";
            this.NumberOfPage.Size = new System.Drawing.Size(64, 22);
            this.NumberOfPage.TabIndex = 4;
            this.NumberOfPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SelectPageButton
            // 
            this.SelectPageButton.Location = new System.Drawing.Point(629, 419);
            this.SelectPageButton.Name = "SelectPageButton";
            this.SelectPageButton.Size = new System.Drawing.Size(75, 23);
            this.SelectPageButton.TabIndex = 5;
            this.SelectPageButton.Text = "Перейти";
            this.SelectPageButton.UseVisualStyleBackColor = true;
            this.SelectPageButton.Click += new System.EventHandler(this.ForwardToPage_Click);
            // 
            // PagesSize
            // 
            this.PagesSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PagesSize.Location = new System.Drawing.Point(377, 419);
            this.PagesSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PagesSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PagesSize.Name = "PagesSize";
            this.PagesSize.Size = new System.Drawing.Size(64, 22);
            this.PagesSize.TabIndex = 6;
            this.PagesSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PagesSize.ValueChanged += new System.EventHandler(this.PagesSize_ValueChanged);
            // 
            // NumberPageLabel
            // 
            this.NumberPageLabel.AutoSize = true;
            this.NumberPageLabel.Location = new System.Drawing.Point(471, 414);
            this.NumberPageLabel.Name = "NumberPageLabel";
            this.NumberPageLabel.Size = new System.Drawing.Size(70, 32);
            this.NumberPageLabel.TabIndex = 7;
            this.NumberPageLabel.Text = "Номер\r\nстраницы";
            this.NumberPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(171, 414);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(184, 32);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Количество отображаемых\r\nэлементов";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrgDataGrid
            // 
            this.OrgDataGrid.AllowUserToAddRows = false;
            this.OrgDataGrid.AllowUserToDeleteRows = false;
            this.OrgDataGrid.AllowUserToResizeRows = false;
            this.OrgDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrgDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrgDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameOrg,
            this.INN,
            this.KPP,
            this.Address,
            this.TypeOrg,
            this.TypeOwnOrg});
            this.OrgDataGrid.Location = new System.Drawing.Point(12, 41);
            this.OrgDataGrid.MultiSelect = false;
            this.OrgDataGrid.Name = "OrgDataGrid";
            this.OrgDataGrid.ReadOnly = true;
            this.OrgDataGrid.RowHeadersVisible = false;
            this.OrgDataGrid.RowHeadersWidth = 51;
            this.OrgDataGrid.RowTemplate.Height = 24;
            this.OrgDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrgDataGrid.Size = new System.Drawing.Size(1006, 370);
            this.OrgDataGrid.TabIndex = 9;
            this.OrgDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrgDataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameOrg
            // 
            this.NameOrg.HeaderText = "Название";
            this.NameOrg.MinimumWidth = 6;
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.ReadOnly = true;
            // 
            // INN
            // 
            this.INN.HeaderText = "ИНН";
            this.INN.MinimumWidth = 6;
            this.INN.Name = "INN";
            this.INN.ReadOnly = true;
            // 
            // KPP
            // 
            this.KPP.HeaderText = "КПП";
            this.KPP.MinimumWidth = 6;
            this.KPP.Name = "KPP";
            this.KPP.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // TypeOrg
            // 
            this.TypeOrg.HeaderText = "Тип организации";
            this.TypeOrg.MinimumWidth = 6;
            this.TypeOrg.Name = "TypeOrg";
            this.TypeOrg.ReadOnly = true;
            // 
            // TypeOwnOrg
            // 
            this.TypeOwnOrg.HeaderText = "Вид организации";
            this.TypeOwnOrg.MinimumWidth = 6;
            this.TypeOwnOrg.Name = "TypeOwnOrg";
            this.TypeOwnOrg.ReadOnly = true;
            // 
            // TypeOwnCheckedListBox
            // 
            this.TypeOwnCheckedListBox.CheckOnClick = true;
            this.TypeOwnCheckedListBox.FormattingEnabled = true;
            this.TypeOwnCheckedListBox.Location = new System.Drawing.Point(226, 20);
            this.TypeOwnCheckedListBox.Name = "TypeOwnCheckedListBox";
            this.TypeOwnCheckedListBox.Size = new System.Drawing.Size(202, 157);
            this.TypeOwnCheckedListBox.TabIndex = 10;
            // 
            // TypeOrgCheckedListBox
            // 
            this.TypeOrgCheckedListBox.CheckOnClick = true;
            this.TypeOrgCheckedListBox.FormattingEnabled = true;
            this.TypeOrgCheckedListBox.HorizontalScrollbar = true;
            this.TypeOrgCheckedListBox.Location = new System.Drawing.Point(18, 20);
            this.TypeOrgCheckedListBox.Name = "TypeOrgCheckedListBox";
            this.TypeOrgCheckedListBox.Size = new System.Drawing.Size(202, 157);
            this.TypeOrgCheckedListBox.TabIndex = 11;
            // 
            // FiltrsGroupBox
            // 
            this.FiltrsGroupBox.Controls.Add(this.AcceptButton);
            this.FiltrsGroupBox.Controls.Add(this.TypeOrgCheckedListBox);
            this.FiltrsGroupBox.Controls.Add(this.TypeOwnCheckedListBox);
            this.FiltrsGroupBox.Location = new System.Drawing.Point(584, 41);
            this.FiltrsGroupBox.Name = "FiltrsGroupBox";
            this.FiltrsGroupBox.Size = new System.Drawing.Size(434, 209);
            this.FiltrsGroupBox.TabIndex = 12;
            this.FiltrsGroupBox.TabStop = false;
            this.FiltrsGroupBox.Text = "Фильтрация";
            this.FiltrsGroupBox.Visible = false;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(353, 180);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 12;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Организации";
            // 
            // FiltrsButton
            // 
            this.FiltrsButton.Location = new System.Drawing.Point(847, 12);
            this.FiltrsButton.Name = "FiltrsButton";
            this.FiltrsButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrsButton.TabIndex = 14;
            this.FiltrsButton.Text = "Фильтры";
            this.FiltrsButton.UseVisualStyleBackColor = true;
            this.FiltrsButton.Click += new System.EventHandler(this.FiltrsButton_Click);
            // 
            // OrganizationView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1030, 452);
            this.Controls.Add(this.FiltrsGroupBox);
            this.Controls.Add(this.FiltrsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertUpdateGroupBox);
            this.Controls.Add(this.OrgDataGrid);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.NumberPageLabel);
            this.Controls.Add(this.PagesSize);
            this.Controls.Add(this.SelectPageButton);
            this.Controls.Add(this.NumberOfPage);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.CreateOrgButton);
            this.Name = "OrganizationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр";
            this.Load += new System.EventHandler(this.OrganizationView_Load);
            this.InsertUpdateGroupBox.ResumeLayout(false);
            this.InsertUpdateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrgDataGrid)).EndInit();
            this.FiltrsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox InsertUpdateGroupBox;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.NumericUpDown NumberOfPage;
        private System.Windows.Forms.Button SelectPageButton;
        private System.Windows.Forms.NumericUpDown PagesSize;
        private System.Windows.Forms.Label NumberPageLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button CreateOrgButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TypeOwnerComboBox;
        private System.Windows.Forms.ComboBox TypeOrganizationComboBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox KPPTextBox;
        private System.Windows.Forms.TextBox TaxIdenNumTextBox;
        private System.Windows.Forms.TextBox NameOrgTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView OrgDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn INN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOwnOrg;
        private System.Windows.Forms.CheckedListBox TypeOwnCheckedListBox;
        private System.Windows.Forms.CheckedListBox TypeOrgCheckedListBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox FiltrsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FiltrsButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}

