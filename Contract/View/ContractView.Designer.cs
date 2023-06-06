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
            this.ContractContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportButton = new System.Windows.Forms.Button();
            this.FiltrGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearFiltrsButton = new System.Windows.Forms.Button();
            this.AcceptFiltrButton = new System.Windows.Forms.Button();
            this.FiltrTextBox = new System.Windows.Forms.TextBox();
            this.FiltrStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfConclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateValidation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Executor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConDataGrid)).BeginInit();
            this.ContractContextMenuStrip.SuspendLayout();
            this.FiltrGroupBox.SuspendLayout();
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
            this.CreateButton.Click += new System.EventHandler(this.CreateContractButton_Click);
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
            this.Number,
            this.DateOfConclusion,
            this.DateValidation,
            this.Executor,
            this.Client});
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
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Контракты";
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
            // FiltrGroupBox
            // 
            this.FiltrGroupBox.Controls.Add(this.FiltrStartDateTimePicker);
            this.FiltrGroupBox.Controls.Add(this.ClearFiltrsButton);
            this.FiltrGroupBox.Controls.Add(this.AcceptFiltrButton);
            this.FiltrGroupBox.Controls.Add(this.FiltrTextBox);
            this.FiltrGroupBox.Location = new System.Drawing.Point(57, 146);
            this.FiltrGroupBox.Name = "FiltrGroupBox";
            this.FiltrGroupBox.Size = new System.Drawing.Size(211, 79);
            this.FiltrGroupBox.TabIndex = 17;
            this.FiltrGroupBox.TabStop = false;
            this.FiltrGroupBox.Text = "Фильтр";
            this.FiltrGroupBox.Visible = false;
            // 
            // ClearFiltrsButton
            // 
            this.ClearFiltrsButton.Location = new System.Drawing.Point(49, 50);
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
            this.AcceptFiltrButton.Location = new System.Drawing.Point(130, 50);
            this.AcceptFiltrButton.Name = "AcceptFiltrButton";
            this.AcceptFiltrButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptFiltrButton.TabIndex = 2;
            this.AcceptFiltrButton.Text = "Принять";
            this.AcceptFiltrButton.UseVisualStyleBackColor = true;
            this.AcceptFiltrButton.Click += new System.EventHandler(this.AcceptFiltrButton_Click);
            // 
            // FiltrTextBox
            // 
            this.FiltrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltrTextBox.Location = new System.Drawing.Point(6, 22);
            this.FiltrTextBox.Name = "FiltrTextBox";
            this.FiltrTextBox.Size = new System.Drawing.Size(199, 22);
            this.FiltrTextBox.TabIndex = 1;
            // 
            // FiltrStartDateTimePicker
            // 
            this.FiltrStartDateTimePicker.Location = new System.Drawing.Point(6, 50);
            this.FiltrStartDateTimePicker.Name = "FiltrStartDateTimePicker";
            this.FiltrStartDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.FiltrStartDateTimePicker.TabIndex = 18;
            this.FiltrStartDateTimePicker.Visible = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Код";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // DateOfConclusion
            // 
            this.DateOfConclusion.HeaderText = "Дата заключения";
            this.DateOfConclusion.MinimumWidth = 6;
            this.DateOfConclusion.Name = "DateOfConclusion";
            this.DateOfConclusion.ReadOnly = true;
            // 
            // DateValidation
            // 
            this.DateValidation.HeaderText = "Дата действия";
            this.DateValidation.MinimumWidth = 6;
            this.DateValidation.Name = "DateValidation";
            this.DateValidation.ReadOnly = true;
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
            // Contractview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1030, 452);
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
            this.Name = "Contractview";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfConclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateValidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Executor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
    }
}

