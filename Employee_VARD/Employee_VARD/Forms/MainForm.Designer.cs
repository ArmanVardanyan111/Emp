namespace Employee_VARD.Forms
{
    partial class MainForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPopoln = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnZarplata = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUvol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Location = new System.Drawing.Point(588, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(31, 15);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "user";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(667, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPopoln
            // 
            this.btnPopoln.Location = new System.Drawing.Point(592, 323);
            this.btnPopoln.Name = "btnPopoln";
            this.btnPopoln.Size = new System.Drawing.Size(151, 48);
            this.btnPopoln.TabIndex = 4;
            this.btnPopoln.Text = "Пополнить баланс";
            this.btnPopoln.UseVisualStyleBackColor = true;
            this.btnPopoln.Click += new System.EventHandler(this.btnPopoln_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(12, 104);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(560, 334);
            this.DGV.TabIndex = 5;
            // 
            // btnZarplata
            // 
            this.btnZarplata.Location = new System.Drawing.Point(593, 259);
            this.btnZarplata.Name = "btnZarplata";
            this.btnZarplata.Size = new System.Drawing.Size(150, 45);
            this.btnZarplata.TabIndex = 6;
            this.btnZarplata.Text = "Перечислить зарплату";
            this.btnZarplata.UseVisualStyleBackColor = true;
            this.btnZarplata.Click += new System.EventHandler(this.btnZarplata_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Никак",
            "по возрастанию",
            "по убыванию",
            "Алфовиту"});
            this.cbSort.Location = new System.Drawing.Point(107, 74);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(193, 21);
            this.cbSort.TabIndex = 7;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сортировать";
            // 
            // btnUvol
            // 
            this.btnUvol.Location = new System.Drawing.Point(591, 395);
            this.btnUvol.Name = "btnUvol";
            this.btnUvol.Size = new System.Drawing.Size(150, 47);
            this.btnUvol.TabIndex = 9;
            this.btnUvol.Text = "Удалить сотрудника";
            this.btnUvol.UseVisualStyleBackColor = true;
            this.btnUvol.Click += new System.EventHandler(this.btnUvol_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.btnUvol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnZarplata);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnPopoln);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPopoln;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnZarplata;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUvol;
    }
}