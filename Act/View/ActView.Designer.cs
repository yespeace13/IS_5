namespace IS_5
{
    partial class Actview
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
            this.components = new System.ComponentModel.Container();
            this.CreateButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.NumberOfPage = new System.Windows.Forms.NumericUpDown();
            this.SelectPageButton = new System.Windows.Forms.Button();
            this.PagesSize = new System.Windows.Forms.NumericUpDown();
            this.NumberPageLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ConDataGrid = new System.Windows.Forms.DataGridView();
            this.ContractContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.FiltrGroupBox = new System.Windows.Forms.GroupBox();
            this.FiltrEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FiltrStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClearFiltrsButton = new System.Windows.Forms.Button();
            this.AcceptFiltrButton = new System.Windows.Forms.Button();
            this.FiltrTextBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCapture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConDataGrid)).BeginInit();
            this.ContractContextMenuStrip.SuspendLayout();
            this.FiltrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateButton.Location = new System.Drawing.Point(631, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(90, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Добавить";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateContractButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextPageButton.Location = new System.Drawing.Point(727, 433);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(130, 23);
            this.NextPageButton.TabIndex = 2;
            this.NextPageButton.Text = "След. страница";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousPageButton.Location = new System.Drawing.Point(591, 433);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(130, 23);
            this.PreviousPageButton.TabIndex = 3;
            this.PreviousPageButton.Text = "Пред. страница";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // NumberOfPage
            // 
            this.NumberOfPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfPage.Location = new System.Drawing.Point(386, 433);
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
            this.SelectPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPageButton.Location = new System.Drawing.Point(468, 433);
            this.SelectPageButton.Name = "SelectPageButton";
            this.SelectPageButton.Size = new System.Drawing.Size(75, 23);
            this.SelectPageButton.TabIndex = 5;
            this.SelectPageButton.Text = "Перейти";
            this.SelectPageButton.UseVisualStyleBackColor = true;
            this.SelectPageButton.Click += new System.EventHandler(this.ForwardToPage_Click);
            // 
            // PagesSize
            // 
            this.PagesSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PagesSize.Location = new System.Drawing.Point(216, 433);
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
            this.NumberPageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPageLabel.AutoSize = true;
            this.NumberPageLabel.Location = new System.Drawing.Point(310, 428);
            this.NumberPageLabel.Name = "NumberPageLabel";
            this.NumberPageLabel.Size = new System.Drawing.Size(70, 32);
            this.NumberPageLabel.TabIndex = 7;
            this.NumberPageLabel.Text = "Номер\r\nстраницы";
            this.NumberPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            this.CountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(26, 428);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(184, 32);
            this.CountLabel.TabIndex = 8;
            this.CountLabel.Text = "Количество отображаемых\r\nэлементов";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConDataGrid
            // 
            this.ConDataGrid.AllowUserToAddRows = false;
            this.ConDataGrid.AllowUserToDeleteRows = false;
            this.ConDataGrid.AllowUserToOrderColumns = true;
            this.ConDataGrid.AllowUserToResizeRows = false;
            this.ConDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Organization,
            this.DateOfCapture,
            this.Contract});
            this.ConDataGrid.Location = new System.Drawing.Point(12, 41);
            this.ConDataGrid.MultiSelect = false;
            this.ConDataGrid.Name = "ConDataGrid";
            this.ConDataGrid.ReadOnly = true;
            this.ConDataGrid.RowHeadersVisible = false;
            this.ConDataGrid.RowHeadersWidth = 51;
            this.ConDataGrid.RowTemplate.Height = 24;
            this.ConDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConDataGrid.Size = new System.Drawing.Size(845, 384);
            this.ConDataGrid.TabIndex = 9;
            this.ConDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConDataGrid_ColumnHeaderMouseClick);
            this.ConDataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ConDataGrid_MouseDoubleClick);
            this.ConDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConDataGrid_MouseDown);
            // 
            // ContractContextMenuStrip
            // 
            this.ContractContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContractContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ContractContextMenuStrip.Name = "OrganizationContextMenuStrip";
            this.ContractContextMenuStrip.Size = new System.Drawing.Size(148, 52);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Акты";
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.Location = new System.Drawing.Point(727, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 23);
            this.ExportButton.TabIndex = 15;
            this.ExportButton.Text = "Экспорт в Excel";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // FiltrGroupBox
            // 
            this.FiltrGroupBox.Controls.Add(this.FiltrEndDateTimePicker);
            this.FiltrGroupBox.Controls.Add(this.FiltrStartDateTimePicker);
            this.FiltrGroupBox.Controls.Add(this.ClearFiltrsButton);
            this.FiltrGroupBox.Controls.Add(this.AcceptFiltrButton);
            this.FiltrGroupBox.Controls.Add(this.FiltrTextBox);
            this.FiltrGroupBox.Location = new System.Drawing.Point(158, 146);
            this.FiltrGroupBox.Name = "FiltrGroupBox";
            this.FiltrGroupBox.Size = new System.Drawing.Size(212, 89);
            this.FiltrGroupBox.TabIndex = 17;
            this.FiltrGroupBox.TabStop = false;
            this.FiltrGroupBox.Text = "Фильтр";
            this.FiltrGroupBox.Visible = false;
            // 
            // FiltrEndDateTimePicker
            // 
            this.FiltrEndDateTimePicker.Location = new System.Drawing.Point(6, 49);
            this.FiltrEndDateTimePicker.Name = "FiltrEndDateTimePicker";
            this.FiltrEndDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.FiltrEndDateTimePicker.TabIndex = 19;
            this.FiltrEndDateTimePicker.Visible = false;
            // 
            // FiltrStartDateTimePicker
            // 
            this.FiltrStartDateTimePicker.Location = new System.Drawing.Point(6, 32);
            this.FiltrStartDateTimePicker.Name = "FiltrStartDateTimePicker";
            this.FiltrStartDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.FiltrStartDateTimePicker.TabIndex = 18;
            this.FiltrStartDateTimePicker.Value = new System.DateTime(2000, 6, 8, 20, 7, 0, 0);
            this.FiltrStartDateTimePicker.Visible = false;
            // 
            // ClearFiltrsButton
            // 
            this.ClearFiltrsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearFiltrsButton.Location = new System.Drawing.Point(49, 60);
            this.ClearFiltrsButton.Name = "ClearFiltrsButton";
            this.ClearFiltrsButton.Size = new System.Drawing.Size(75, 23);
            this.ClearFiltrsButton.TabIndex = 3;
            this.ClearFiltrsButton.Text = "Сбросить";
            this.ClearFiltrsButton.UseVisualStyleBackColor = true;
            this.ClearFiltrsButton.Click += new System.EventHandler(this.ClearFiltrsButton_Click);
            // 
            // AcceptFiltrButton
            // 
            this.AcceptFiltrButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptFiltrButton.Location = new System.Drawing.Point(131, 60);
            this.AcceptFiltrButton.Name = "AcceptFiltrButton";
            this.AcceptFiltrButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptFiltrButton.TabIndex = 2;
            this.AcceptFiltrButton.Text = "Принять";
            this.AcceptFiltrButton.UseVisualStyleBackColor = true;
            this.AcceptFiltrButton.Click += new System.EventHandler(this.AcceptFiltrButton_Click);
            // 
            // FiltrTextBox
            // 
            this.FiltrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrTextBox.Location = new System.Drawing.Point(6, 21);
            this.FiltrTextBox.Name = "FiltrTextBox";
            this.FiltrTextBox.Size = new System.Drawing.Size(200, 22);
            this.FiltrTextBox.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.FillWeight = 31.20609F;
            this.Id.HeaderText = "Код";
            this.Id.MinimumWidth = 50;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.FillWeight = 128.1135F;
            this.Organization.HeaderText = "Организация";
            this.Organization.MinimumWidth = 100;
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // DateOfCapture
            // 
            this.DateOfCapture.FillWeight = 80.25263F;
            this.DateOfCapture.HeaderText = "Дата";
            this.DateOfCapture.MinimumWidth = 6;
            this.DateOfCapture.Name = "DateOfCapture";
            this.DateOfCapture.ReadOnly = true;
            // 
            // Contract
            // 
            this.Contract.HeaderText = "Контракт";
            this.Contract.MinimumWidth = 6;
            this.Contract.Name = "Contract";
            this.Contract.ReadOnly = true;
            // 
            // Actview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(869, 466);
            this.Controls.Add(this.FiltrGroupBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConDataGrid);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.NumberPageLabel);
            this.Controls.Add(this.PagesSize);
            this.Controls.Add(this.SelectPageButton);
            this.Controls.Add(this.NumberOfPage);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "Actview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConDataGrid)).EndInit();
            this.ContractContextMenuStrip.ResumeLayout(false);
            this.FiltrGroupBox.ResumeLayout(false);
            this.FiltrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.NumericUpDown NumberOfPage;
        private System.Windows.Forms.Button SelectPageButton;
        private System.Windows.Forms.NumericUpDown PagesSize;
        private System.Windows.Forms.Label NumberPageLabel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView ConDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.ContextMenuStrip ContractContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox FiltrGroupBox;
        private System.Windows.Forms.Button ClearFiltrsButton;
        private System.Windows.Forms.Button AcceptFiltrButton;
        private System.Windows.Forms.TextBox FiltrTextBox;
        private System.Windows.Forms.DateTimePicker FiltrStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker FiltrEndDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCapture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contract;
    }
}

