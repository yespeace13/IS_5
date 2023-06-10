namespace IS_5
{
    partial class ActEditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActEditView));
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateOfCapDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrgsComboBox = new System.Windows.Forms.ComboBox();
            this.AnimalsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdenLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.ScanContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DelScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangeAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ContractsComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PrevScanButton = new System.Windows.Forms.Button();
            this.NextScanButton = new System.Windows.Forms.Button();
            this.ScanPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsDataGridView)).BeginInit();
            this.ScanContextMenuStrip.SuspendLayout();
            this.DataContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(296, 429);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(377, 429);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Организация";
            // 
            // DateOfCapDateTimePicker
            // 
            this.DateOfCapDateTimePicker.Location = new System.Drawing.Point(12, 120);
            this.DateOfCapDateTimePicker.Name = "DateOfCapDateTimePicker";
            this.DateOfCapDateTimePicker.Size = new System.Drawing.Size(186, 22);
            this.DateOfCapDateTimePicker.TabIndex = 3;
            // 
            // OrgsComboBox
            // 
            this.OrgsComboBox.FormattingEnabled = true;
            this.OrgsComboBox.Location = new System.Drawing.Point(12, 74);
            this.OrgsComboBox.Name = "OrgsComboBox";
            this.OrgsComboBox.Size = new System.Drawing.Size(186, 24);
            this.OrgsComboBox.TabIndex = 4;
            // 
            // AnimalsDataGridView
            // 
            this.AnimalsDataGridView.AllowUserToAddRows = false;
            this.AnimalsDataGridView.AllowUserToDeleteRows = false;
            this.AnimalsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AnimalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdenLabel,
            this.ChipNumber,
            this.Locality});
            this.AnimalsDataGridView.Location = new System.Drawing.Point(12, 233);
            this.AnimalsDataGridView.MultiSelect = false;
            this.AnimalsDataGridView.Name = "AnimalsDataGridView";
            this.AnimalsDataGridView.ReadOnly = true;
            this.AnimalsDataGridView.RowHeadersVisible = false;
            this.AnimalsDataGridView.RowHeadersWidth = 51;
            this.AnimalsDataGridView.RowTemplate.Height = 24;
            this.AnimalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnimalsDataGridView.Size = new System.Drawing.Size(438, 190);
            this.AnimalsDataGridView.TabIndex = 5;
            this.AnimalsDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AnimalsDataGridView_MouseDoubleClick);
            this.AnimalsDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnimalsDataGridView_MouseDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // IdenLabel
            // 
            this.IdenLabel.HeaderText = "Идентификационная метка";
            this.IdenLabel.MinimumWidth = 6;
            this.IdenLabel.Name = "IdenLabel";
            this.IdenLabel.ReadOnly = true;
            // 
            // ChipNumber
            // 
            this.ChipNumber.HeaderText = "Чип";
            this.ChipNumber.MinimumWidth = 6;
            this.ChipNumber.Name = "ChipNumber";
            this.ChipNumber.ReadOnly = true;
            // 
            // Locality
            // 
            this.Locality.HeaderText = "Муниципальный район";
            this.Locality.MinimumWidth = 6;
            this.Locality.Name = "Locality";
            this.Locality.ReadOnly = true;
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(377, 204);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(75, 23);
            this.AddAnimalButton.TabIndex = 6;
            this.AddAnimalButton.Text = "Добавить";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            this.AddAnimalButton.Click += new System.EventHandler(this.AddAnimalButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата отлова";
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(246, 204);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(125, 23);
            this.AddFileButton.TabIndex = 30;
            this.AddFileButton.Text = "Загрузить файл";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // ScanContextMenuStrip
            // 
            this.ScanContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ScanContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelScanToolStripMenuItem});
            this.ScanContextMenuStrip.Name = "ScanContextMenuStrip";
            this.ScanContextMenuStrip.Size = new System.Drawing.Size(135, 28);
            // 
            // DelScanToolStripMenuItem
            // 
            this.DelScanToolStripMenuItem.Name = "DelScanToolStripMenuItem";
            this.DelScanToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DelScanToolStripMenuItem.Text = "Удалить";
            this.DelScanToolStripMenuItem.Click += new System.EventHandler(this.DelScanToolStripMenuItem_Click);
            // 
            // DataContextMenuStrip
            // 
            this.DataContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DataContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeAnimalToolStripMenuItem,
            this.DeleteAnimalToolStripMenuItem});
            this.DataContextMenuStrip.Name = "DataContextMenuStrip";
            this.DataContextMenuStrip.Size = new System.Drawing.Size(148, 52);
            // 
            // ChangeAnimalToolStripMenuItem
            // 
            this.ChangeAnimalToolStripMenuItem.Name = "ChangeAnimalToolStripMenuItem";
            this.ChangeAnimalToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ChangeAnimalToolStripMenuItem.Text = "Изменить";
            this.ChangeAnimalToolStripMenuItem.Click += new System.EventHandler(this.ChangeAnimalToolStripMenuItem_Click);
            // 
            // DeleteAnimalToolStripMenuItem
            // 
            this.DeleteAnimalToolStripMenuItem.Name = "DeleteAnimalToolStripMenuItem";
            this.DeleteAnimalToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DeleteAnimalToolStripMenuItem.Text = "Удалить";
            this.DeleteAnimalToolStripMenuItem.Click += new System.EventHandler(this.DeleteAnimalToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Контракт";
            // 
            // ContractsComboBox
            // 
            this.ContractsComboBox.FormattingEnabled = true;
            this.ContractsComboBox.Location = new System.Drawing.Point(15, 28);
            this.ContractsComboBox.Name = "ContractsComboBox";
            this.ContractsComboBox.Size = new System.Drawing.Size(186, 24);
            this.ContractsComboBox.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"png|*.png|*.jpg|\"";
            // 
            // PrevScanButton
            // 
            this.PrevScanButton.Image = global::IS_5.Properties.Resources.fast_forward_1_;
            this.PrevScanButton.Location = new System.Drawing.Point(212, 89);
            this.PrevScanButton.Name = "PrevScanButton";
            this.PrevScanButton.Size = new System.Drawing.Size(26, 32);
            this.PrevScanButton.TabIndex = 35;
            this.PrevScanButton.UseVisualStyleBackColor = true;
            this.PrevScanButton.Click += new System.EventHandler(this.PrevScanButton_Click);
            // 
            // NextScanButton
            // 
            this.NextScanButton.Image = ((System.Drawing.Image)(resources.GetObject("NextScanButton.Image")));
            this.NextScanButton.Location = new System.Drawing.Point(424, 89);
            this.NextScanButton.Name = "NextScanButton";
            this.NextScanButton.Size = new System.Drawing.Size(26, 32);
            this.NextScanButton.TabIndex = 28;
            this.NextScanButton.UseVisualStyleBackColor = true;
            this.NextScanButton.Click += new System.EventHandler(this.NextScanButton_Click);
            // 
            // ScanPictureBox
            // 
            this.ScanPictureBox.ContextMenuStrip = this.ScanContextMenuStrip;
            this.ScanPictureBox.Location = new System.Drawing.Point(244, 9);
            this.ScanPictureBox.Name = "ScanPictureBox";
            this.ScanPictureBox.Size = new System.Drawing.Size(174, 189);
            this.ScanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ScanPictureBox.TabIndex = 27;
            this.ScanPictureBox.TabStop = false;
            // 
            // ActEditView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(462, 464);
            this.Controls.Add(this.PrevScanButton);
            this.Controls.Add(this.ContractsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.NextScanButton);
            this.Controls.Add(this.ScanPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddAnimalButton);
            this.Controls.Add(this.AnimalsDataGridView);
            this.Controls.Add(this.OrgsComboBox);
            this.Controls.Add(this.DateOfCapDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Name = "ActEditView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акт";
            ((System.ComponentModel.ISupportInitialize)(this.AnimalsDataGridView)).EndInit();
            this.ScanContextMenuStrip.ResumeLayout(false);
            this.DataContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateOfCapDateTimePicker;
        private System.Windows.Forms.ComboBox OrgsComboBox;
        private System.Windows.Forms.DataGridView AnimalsDataGridView;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button NextScanButton;
        private System.Windows.Forms.PictureBox ScanPictureBox;
        private System.Windows.Forms.ContextMenuStrip DataContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChangeAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAnimalToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ScanContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DelScanToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdenLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ContractsComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button PrevScanButton;
    }
}