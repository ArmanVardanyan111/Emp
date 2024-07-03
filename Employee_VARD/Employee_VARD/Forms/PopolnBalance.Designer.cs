namespace Employee_VARD.Forms
{
    partial class PopolnBalanceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudBalance = new System.Windows.Forms.NumericUpDown();
            this.btnPopoln = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "На сколько пополнить баланс?";
            // 
            // nudBalance
            // 
            this.nudBalance.Location = new System.Drawing.Point(69, 88);
            this.nudBalance.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nudBalance.Name = "nudBalance";
            this.nudBalance.Size = new System.Drawing.Size(151, 20);
            this.nudBalance.TabIndex = 4;
            // 
            // btnPopoln
            // 
            this.btnPopoln.Location = new System.Drawing.Point(60, 132);
            this.btnPopoln.Name = "btnPopoln";
            this.btnPopoln.Size = new System.Drawing.Size(75, 23);
            this.btnPopoln.TabIndex = 5;
            this.btnPopoln.Text = "Пополнить";
            this.btnPopoln.UseVisualStyleBackColor = true;
            this.btnPopoln.Click += new System.EventHandler(this.btnPopoln_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PopolnBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPopoln);
            this.Controls.Add(this.nudBalance);
            this.Controls.Add(this.label2);
            this.Name = "PopolnBalanceForm";
            this.Text = "Пополнение баланса";
            ((System.ComponentModel.ISupportInitialize)(this.nudBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBalance;
        private System.Windows.Forms.Button btnPopoln;
        private System.Windows.Forms.Button button1;
    }
}