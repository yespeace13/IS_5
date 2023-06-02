namespace IS_5
{
    partial class Contractview
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateValid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrsGroupBox = new System.Windows.Forms.GroupBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrsButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConDataGrid)).BeginInit();
            this.ContractContextMenuStrip.SuspendLayout();
            this.FiltrsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(792, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(90, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Добавить";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateOrgButton_Click);
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
            this.NumContract,
            this.DateOfConclusion,
            this.DateValid,
            this.Executor,
            this.Client});
            this.ConDataGrid.ContextMenuStrip = this.ContractContextMenuStrip;
            this.ConDataGrid.Location = new System.Drawing.Point(12, 41);
            this.ConDataGrid.MultiSelect = false;
            this.ConDataGrid.Name = "ConDataGrid";
            this.ConDataGrid.ReadOnly = true;
            this.ConDataGrid.RowHeadersVisible = false;
            this.ConDataGrid.RowHeadersWidth = 51;
            this.ConDataGrid.RowTemplate.Height = 24;
            this.ConDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConDataGrid.Size = new System.Drawing.Size(1006, 370);
            this.ConDataGrid.TabIndex = 9;
            this.ConDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConDataGrid_ColumnHeaderMouseClick);
            this.ConDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConDataGrid_MouseDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NumContract
            // 
            this.NumContract.HeaderText = "Номер";
            this.NumContract.MinimumWidth = 6;
            this.NumContract.Name = "NumContract";
            this.NumContract.ReadOnly = true;
            // 
            // DateOfConclusion
            // 
            this.DateOfConclusion.HeaderText = "Дата заключения";
            this.DateOfConclusion.MinimumWidth = 6;
            this.DateOfConclusion.Name = "DateOfConclusion";
            this.DateOfConclusion.ReadOnly = true;
            // 
            // DateValid
            // 
            this.DateValid.HeaderText = "Дата действия";
            this.DateValid.MinimumWidth = 6;
            this.DateValid.Name = "DateValid";
            this.DateValid.ReadOnly = true;
            // 
            // Executor
            // 
            this.Executor.HeaderText = "Исполнитель";
            this.Executor.MinimumWidth = 6;
            this.Executor.Name = "Executor";
            this.Executor.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Заказчик";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // ContractContextMenuStrip
            // 
            this.ContractContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContractContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowToolStripMenuItem,
            this.ChangeToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ContractContextMenuStrip.Name = "OrganizationContextMenuStrip";
            this.ContractContextMenuStrip.Size = new System.Drawing.Size(150, 76);
            // 
            // ShowToolStripMenuItem
            // 
            this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
            this.ShowToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.ShowToolStripMenuItem.Text = "Просмотр";
            this.ShowToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            this.ChangeToolStripMenuItem.Click += new System.EventHandler(this.ChangeToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // FiltrsGroupBox
            // 
            this.FiltrsGroupBox.Controls.Add(this.AcceptButton);
            this.FiltrsGroupBox.Location = new System.Drawing.Point(377, 41);
            this.FiltrsGroupBox.Name = "FiltrsGroupBox";
            this.FiltrsGroupBox.Size = new System.Drawing.Size(641, 209);
            this.FiltrsGroupBox.TabIndex = 12;
            this.FiltrsGroupBox.TabStop = false;
            this.FiltrsGroupBox.Text = "Фильтрация";
            this.FiltrsGroupBox.Visible = false;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(549, 184);
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
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Контракты";
            // 
            // FiltrsButton
            // 
            this.FiltrsButton.Location = new System.Drawing.Point(711, 12);
            this.FiltrsButton.Name = "FiltrsButton";
            this.FiltrsButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrsButton.TabIndex = 14;
            this.FiltrsButton.Text = "Фильтры";
            this.FiltrsButton.UseVisualStyleBackColor = true;
            this.FiltrsButton.Click += new System.EventHandler(this.FiltrsButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(888, 12);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 23);
            this.ExportButton.TabIndex = 15;
            this.ExportButton.Text = "Экспорт в Excel";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // Contractview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1030, 452);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.FiltrsGroupBox);
            this.Controls.Add(this.FiltrsButton);
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
            this.Name = "Contractview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реестр";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConDataGrid)).EndInit();
            this.ContractContextMenuStrip.ResumeLayout(false);
            this.FiltrsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox FiltrsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FiltrsButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.ContextMenuStrip ContractContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}

