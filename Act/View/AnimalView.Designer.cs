namespace IS_5
{
    partial class AnimalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalView));
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SexGroupBox = new System.Windows.Forms.GroupBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BreedTextBox = new System.Windows.Forms.TextBox();
            this.WoolTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.EarsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpecialSignsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IdenLabelTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrevScanButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.NextScanButton = new System.Windows.Forms.Button();
            this.ScanPictureBox = new System.Windows.Forms.PictureBox();
            this.ScanContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChipNumTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LocalityComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).BeginInit();
            this.ScanContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(12, 28);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(224, 22);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Checked = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(6, 21);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(69, 20);
            this.FemaleRadioButton.TabIndex = 3;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Самка";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexGroupBox
            // 
            this.SexGroupBox.Controls.Add(this.MaleRadioButton);
            this.SexGroupBox.Controls.Add(this.FemaleRadioButton);
            this.SexGroupBox.Location = new System.Drawing.Point(12, 56);
            this.SexGroupBox.Name = "SexGroupBox";
            this.SexGroupBox.Size = new System.Drawing.Size(224, 49);
            this.SexGroupBox.TabIndex = 4;
            this.SexGroupBox.TabStop = false;
            this.SexGroupBox.Text = "Пол";
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(115, 21);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(70, 20);
            this.MaleRadioButton.TabIndex = 4;
            this.MaleRadioButton.Text = "Самец";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порода";
            // 
            // BreedTextBox
            // 
            this.BreedTextBox.Location = new System.Drawing.Point(12, 127);
            this.BreedTextBox.Multiline = true;
            this.BreedTextBox.Name = "BreedTextBox";
            this.BreedTextBox.Size = new System.Drawing.Size(224, 41);
            this.BreedTextBox.TabIndex = 6;
            // 
            // WoolTextBox
            // 
            this.WoolTextBox.Location = new System.Drawing.Point(12, 234);
            this.WoolTextBox.Multiline = true;
            this.WoolTextBox.Name = "WoolTextBox";
            this.WoolTextBox.Size = new System.Drawing.Size(224, 41);
            this.WoolTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шерсть";
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.DecimalPlaces = 2;
            this.SizeNumericUpDown.Location = new System.Drawing.Point(12, 190);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(117, 22);
            this.SizeNumericUpDown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цвет";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(9, 297);
            this.ColorTextBox.Multiline = true;
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(224, 41);
            this.ColorTextBox.TabIndex = 12;
            // 
            // EarsTextBox
            // 
            this.EarsTextBox.Location = new System.Drawing.Point(9, 358);
            this.EarsTextBox.Multiline = true;
            this.EarsTextBox.Name = "EarsTextBox";
            this.EarsTextBox.Size = new System.Drawing.Size(224, 41);
            this.EarsTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Уши";
            // 
            // TailTextBox
            // 
            this.TailTextBox.Location = new System.Drawing.Point(9, 421);
            this.TailTextBox.Multiline = true;
            this.TailTextBox.Name = "TailTextBox";
            this.TailTextBox.Size = new System.Drawing.Size(224, 41);
            this.TailTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Хвост";
            // 
            // SpecialSignsTextBox
            // 
            this.SpecialSignsTextBox.Location = new System.Drawing.Point(268, 266);
            this.SpecialSignsTextBox.Multiline = true;
            this.SpecialSignsTextBox.Name = "SpecialSignsTextBox";
            this.SpecialSignsTextBox.Size = new System.Drawing.Size(224, 61);
            this.SpecialSignsTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Особые приметы";
            // 
            // IdenLabelTextBox
            // 
            this.IdenLabelTextBox.Location = new System.Drawing.Point(268, 349);
            this.IdenLabelTextBox.Name = "IdenLabelTextBox";
            this.IdenLabelTextBox.Size = new System.Drawing.Size(224, 22);
            this.IdenLabelTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Идентификационная метка";
            // 
            // PrevScanButton
            // 
            this.PrevScanButton.Image = global::IS_5.Properties.Resources.fast_forward_1_;
            this.PrevScanButton.Location = new System.Drawing.Point(251, 92);
            this.PrevScanButton.Name = "PrevScanButton";
            this.PrevScanButton.Size = new System.Drawing.Size(26, 32);
            this.PrevScanButton.TabIndex = 39;
            this.PrevScanButton.UseVisualStyleBackColor = true;
            this.PrevScanButton.Click += new System.EventHandler(this.PrevScanButton_Click);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(308, 207);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(125, 23);
            this.AddFileButton.TabIndex = 38;
            this.AddFileButton.Text = "Загрузить файл";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // NextScanButton
            // 
            this.NextScanButton.Image = ((System.Drawing.Image)(resources.GetObject("NextScanButton.Image")));
            this.NextScanButton.Location = new System.Drawing.Point(463, 92);
            this.NextScanButton.Name = "NextScanButton";
            this.NextScanButton.Size = new System.Drawing.Size(26, 32);
            this.NextScanButton.TabIndex = 37;
            this.NextScanButton.UseVisualStyleBackColor = true;
            this.NextScanButton.Click += new System.EventHandler(this.NextScanButton_Click);
            // 
            // ScanPictureBox
            // 
            this.ScanPictureBox.ContextMenuStrip = this.ScanContextMenuStrip;
            this.ScanPictureBox.Location = new System.Drawing.Point(283, 12);
            this.ScanPictureBox.Name = "ScanPictureBox";
            this.ScanPictureBox.Size = new System.Drawing.Size(174, 189);
            this.ScanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ScanPictureBox.TabIndex = 36;
            this.ScanPictureBox.TabStop = false;
            this.ScanPictureBox.DoubleClick += new System.EventHandler(this.ScanPictureBox_DoubleClick);
            // 
            // ScanContextMenuStrip
            // 
            this.ScanContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ScanContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.ScanContextMenuStrip.Name = "ScanContextMenuStrip";
            this.ScanContextMenuStrip.Size = new System.Drawing.Size(135, 28);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ChipNumTextBox
            // 
            this.ChipNumTextBox.Location = new System.Drawing.Point(268, 393);
            this.ChipNumTextBox.Name = "ChipNumTextBox";
            this.ChipNumTextBox.Size = new System.Drawing.Size(224, 22);
            this.ChipNumTextBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Номер чипа";
            // 
            // LocalityComboBox
            // 
            this.LocalityComboBox.FormattingEnabled = true;
            this.LocalityComboBox.Location = new System.Drawing.Point(268, 438);
            this.LocalityComboBox.Name = "LocalityComboBox";
            this.LocalityComboBox.Size = new System.Drawing.Size(224, 24);
            this.LocalityComboBox.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(268, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Муниципальный район";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(336, 490);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 44;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(417, 490);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 45;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AnimalView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 525);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LocalityComboBox);
            this.Controls.Add(this.ChipNumTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PrevScanButton);
            this.Controls.Add(this.AddFileButton);
            this.Controls.Add(this.NextScanButton);
            this.Controls.Add(this.ScanPictureBox);
            this.Controls.Add(this.IdenLabelTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpecialSignsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EarsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.WoolTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BreedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SexGroupBox);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AnimalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животное";
            this.SexGroupBox.ResumeLayout(false);
            this.SexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPictureBox)).EndInit();
            this.ScanContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.GroupBox SexGroupBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BreedTextBox;
        private System.Windows.Forms.TextBox WoolTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox EarsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SpecialSignsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdenLabelTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button PrevScanButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button NextScanButton;
        private System.Windows.Forms.PictureBox ScanPictureBox;
        private System.Windows.Forms.TextBox ChipNumTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LocalityComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip ScanContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}