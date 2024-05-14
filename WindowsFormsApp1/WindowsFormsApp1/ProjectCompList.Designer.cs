namespace WindowsFormsApp1
{
    partial class ProjectCompList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListCompBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProjektKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oszlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rekesz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Darab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.ListCompBtn);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 360);
            this.panel1.TabIndex = 0;
            // 
            // ListCompBtn
            // 
            this.ListCompBtn.Location = new System.Drawing.Point(23, 103);
            this.ListCompBtn.Name = "ListCompBtn";
            this.ListCompBtn.Size = new System.Drawing.Size(75, 63);
            this.ListCompBtn.TabIndex = 0;
            this.ListCompBtn.Text = "Listáz";
            this.ListCompBtn.UseVisualStyleBackColor = true;
            this.ListCompBtn.Click += new System.EventHandler(this.ListCompBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 98);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekthez tartozó alkatrészek listázása";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjektKod,
            this.ANev,
            this.Sor,
            this.Oszlop,
            this.Polc,
            this.Rekesz,
            this.Darab});
            this.dataGridView1.Location = new System.Drawing.Point(118, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 349);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProjektKod
            // 
            this.ProjektKod.HeaderText = "Projekt ID";
            this.ProjektKod.Name = "ProjektKod";
            // 
            // ANev
            // 
            this.ANev.HeaderText = "Alkatrész Név";
            this.ANev.Name = "ANev";
            // 
            // Sor
            // 
            this.Sor.HeaderText = "Sor";
            this.Sor.Name = "Sor";
            // 
            // Oszlop
            // 
            this.Oszlop.HeaderText = "Oszlop";
            this.Oszlop.Name = "Oszlop";
            // 
            // Polc
            // 
            this.Polc.HeaderText = "Polc";
            this.Polc.Name = "Polc";
            // 
            // Rekesz
            // 
            this.Rekesz.HeaderText = "Rekesz";
            this.Rekesz.Name = "Rekesz";
            // 
            // Darab
            // 
            this.Darab.HeaderText = "Darab";
            this.Darab.Name = "Darab";
            // 
            // ProjectCompList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectCompList";
            this.Text = "ProjectCompList";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListCompBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjektKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oszlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rekesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Darab;
    }
}