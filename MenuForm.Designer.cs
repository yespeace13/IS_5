namespace IS_5
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OrgsButton = new System.Windows.Forms.Button();
            this.ContractsButton = new System.Windows.Forms.Button();
            this.ActsButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrgsButton
            // 
            this.OrgsButton.Location = new System.Drawing.Point(197, 152);
            this.OrgsButton.Name = "OrgsButton";
            this.OrgsButton.Size = new System.Drawing.Size(319, 33);
            this.OrgsButton.TabIndex = 0;
            this.OrgsButton.Text = "Организации";
            this.OrgsButton.UseVisualStyleBackColor = true;
            this.OrgsButton.Click += new System.EventHandler(this.OrgsButton_Click);
            // 
            // ContractsButton
            // 
            this.ContractsButton.Location = new System.Drawing.Point(197, 191);
            this.ContractsButton.Name = "ContractsButton";
            this.ContractsButton.Size = new System.Drawing.Size(319, 33);
            this.ContractsButton.TabIndex = 1;
            this.ContractsButton.Text = "Контракты";
            this.ContractsButton.UseVisualStyleBackColor = true;
            this.ContractsButton.Click += new System.EventHandler(this.ContractsButton_Click);
            // 
            // ActsButton
            // 
            this.ActsButton.Location = new System.Drawing.Point(197, 230);
            this.ActsButton.Name = "ActsButton";
            this.ActsButton.Size = new System.Drawing.Size(319, 33);
            this.ActsButton.TabIndex = 2;
            this.ActsButton.Text = "Акты";
            this.ActsButton.UseVisualStyleBackColor = true;
            this.ActsButton.Click += new System.EventHandler(this.ActsButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(197, 269);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(319, 33);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Отчет";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "План";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ActsButton);
            this.Controls.Add(this.ContractsButton);
            this.Controls.Add(this.OrgsButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OrgsButton;
        private System.Windows.Forms.Button ContractsButton;
        private System.Windows.Forms.Button ActsButton;
        private System.Windows.Forms.Button ReportButton;
    }
}