namespace Employee_VARD
{
    partial class UvolitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPerech = new System.Windows.Forms.Button();
            this.cbSotrudniks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPerech
            // 
            this.btnPerech.Location = new System.Drawing.Point(46, 112);
            this.btnPerech.Name = "btnPerech";
            this.btnPerech.Size = new System.Drawing.Size(85, 29);
            this.btnPerech.TabIndex = 15;
            this.btnPerech.Text = "Удалить";
            this.btnPerech.UseVisualStyleBackColor = true;
            // 
            // cbSotrudniks
            // 
            this.cbSotrudniks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSotrudniks.FormattingEnabled = true;
            this.cbSotrudniks.Location = new System.Drawing.Point(100, 44);
            this.cbSotrudniks.Name = "cbSotrudniks";
            this.cbSotrudniks.Size = new System.Drawing.Size(136, 21);
            this.cbSotrudniks.TabIndex = 14;
            // 
            // UvolitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPerech);
            this.Controls.Add(this.cbSotrudniks);
            this.Name = "UvolitForm";
            this.Text = "UvolitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPerech;
        private System.Windows.Forms.ComboBox cbSotrudniks;
    }
}