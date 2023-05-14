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
            this.grdOrg = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // grdOrg
            // 
            this.grdOrg.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.grdOrg.FullRowSelect = true;
            this.grdOrg.HideSelection = false;
            this.grdOrg.HoverSelection = true;
            this.grdOrg.Location = new System.Drawing.Point(12, 12);
            this.grdOrg.Name = "grdOrg";
            this.grdOrg.Size = new System.Drawing.Size(776, 426);
            this.grdOrg.TabIndex = 0;
            this.grdOrg.UseCompatibleStateImageBehavior = false;
            this.grdOrg.View = System.Windows.Forms.View.Details;
            // 
            // OrganizationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdOrg);
            this.Name = "OrganizationView";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView grdOrg;
    }
}

