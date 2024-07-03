namespace Employee_VARD.Forms
{
    partial class Zarplata
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
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.cbSotrudniks = new System.Windows.Forms.ComboBox();
            this.btnPerech = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBalance
            // 
            this.nudBalance.BackColor = System.Drawing.SystemColors.Window;
            this.nudBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudBalance.Location = new System.Drawing.Point(78, 114);
            this.nudBalance.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(136, 20);
            this.nudBalance.TabIndex = 5;
            this.nudBalance.ValueChanged += new System.EventHandler(this.nudBalance_ValueChanged);
            this.nudBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudBalance_KeyUp);
            // 
            // cbSotrudniks
            // 
            this.cbSotrudniks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSotrudniks.FormattingEnabled = true;
            this.cbSotrudniks.Location = new System.Drawing.Point(78, 47);
            this.cbSotrudniks.Name = "cbSotrudniks";
            this.cbSotrudniks.Size = new System.Drawing.Size(136, 21);
            this.cbSotrudniks.TabIndex = 7;
            this.cbSotrudniks.SelectedIndexChanged += new System.EventHandler(this.cbSotrudniks_SelectedIndexChanged);
            // 
            // btnPerech
            // 
            this.btnPerech.Location = new System.Drawing.Point(24, 181);
            this.btnPerech.Name = "btnPerech";
            this.btnPerech.Size = new System.Drawing.Size(85, 29);
            this.btnPerech.TabIndex = 8;
            this.btnPerech.Text = "Перечислить";
            this.btnPerech.UseVisualStyleBackColor = true;
            this.btnPerech.Click += new System.EventHandler(this.btnPerech_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 29);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Сотрудник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сумма";
            // 
            // Zarplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPerech);
            this.Controls.Add(this.cbSotrudniks);
            this.Controls.Add(this.nudBalance);
            this.Name = "Zarplata";
            this.Text = "Перечисление зарплаты";
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.ComboBox cbSotrudniks;
        private System.Windows.Forms.Button btnPerech;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}