namespace WindowsFormsApp1
{
    partial class IncomingPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartNameField = new System.Windows.Forms.TextBox();
            this.StockField = new System.Windows.Forms.TextBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.colField = new System.Windows.Forms.TextBox();
            this.colLabel = new System.Windows.Forms.Label();
            this.RowField = new System.Windows.Forms.TextBox();
            this.RowLabel = new System.Windows.Forms.Label();
            this.CompartmentField = new System.Windows.Forms.TextBox();
            this.CompartmentLabel = new System.Windows.Forms.Label();
            this.FileBtn = new System.Windows.Forms.Button();
            this.BracketField = new System.Windows.Forms.TextBox();
            this.BracketLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 69);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bejövő alkatrészek kezelése";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 388);
            this.panel2.TabIndex = 1;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNameLabel.Location = new System.Drawing.Point(146, 81);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(119, 16);
            this.PartNameLabel.TabIndex = 2;
            this.PartNameLabel.Text = "Alkatrész név:";
            this.PartNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // PartNameField
            // 
            this.PartNameField.Location = new System.Drawing.Point(272, 81);
            this.PartNameField.Name = "PartNameField";
            this.PartNameField.Size = new System.Drawing.Size(170, 20);
            this.PartNameField.TabIndex = 3;
            // 
            // StockField
            // 
            this.StockField.Location = new System.Drawing.Point(272, 118);
            this.StockField.Name = "StockField";
            this.StockField.Size = new System.Drawing.Size(170, 20);
            this.StockField.TabIndex = 5;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(178, 118);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(87, 16);
            this.StockLabel.TabIndex = 4;
            this.StockLabel.Text = "Darabszám:";
            this.StockLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // colField
            // 
            this.colField.Location = new System.Drawing.Point(272, 159);
            this.colField.Name = "colField";
            this.colField.Size = new System.Drawing.Size(170, 20);
            this.colField.TabIndex = 7;
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLabel.Location = new System.Drawing.Point(202, 159);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(63, 16);
            this.colLabel.TabIndex = 6;
            this.colLabel.Text = "Oszlop:";
            // 
            // RowField
            // 
            this.RowField.Location = new System.Drawing.Point(272, 200);
            this.RowField.Name = "RowField";
            this.RowField.Size = new System.Drawing.Size(170, 20);
            this.RowField.TabIndex = 9;
            // 
            // RowLabel
            // 
            this.RowLabel.AutoSize = true;
            this.RowLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowLabel.Location = new System.Drawing.Point(226, 200);
            this.RowLabel.Name = "RowLabel";
            this.RowLabel.Size = new System.Drawing.Size(39, 16);
            this.RowLabel.TabIndex = 8;
            this.RowLabel.Text = "Sor:";
            // 
            // CompartmentField
            // 
            this.CompartmentField.Location = new System.Drawing.Point(272, 275);
            this.CompartmentField.Name = "CompartmentField";
            this.CompartmentField.Size = new System.Drawing.Size(170, 20);
            this.CompartmentField.TabIndex = 11;
            // 
            // CompartmentLabel
            // 
            this.CompartmentLabel.AutoSize = true;
            this.CompartmentLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompartmentLabel.Location = new System.Drawing.Point(202, 275);
            this.CompartmentLabel.Name = "CompartmentLabel";
            this.CompartmentLabel.Size = new System.Drawing.Size(63, 16);
            this.CompartmentLabel.TabIndex = 10;
            this.CompartmentLabel.Text = "Rekesz:";
            // 
            // FileBtn
            // 
            this.FileBtn.Location = new System.Drawing.Point(374, 337);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(135, 34);
            this.FileBtn.TabIndex = 12;
            this.FileBtn.Text = "Iktat";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FileBtn_Click);
            // 
            // BracketField
            // 
            this.BracketField.Location = new System.Drawing.Point(272, 238);
            this.BracketField.Name = "BracketField";
            this.BracketField.Size = new System.Drawing.Size(170, 20);
            this.BracketField.TabIndex = 15;
            // 
            // BracketLabel
            // 
            this.BracketLabel.AutoSize = true;
            this.BracketLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BracketLabel.Location = new System.Drawing.Point(218, 238);
            this.BracketLabel.Name = "BracketLabel";
            this.BracketLabel.Size = new System.Drawing.Size(47, 16);
            this.BracketLabel.TabIndex = 14;
            this.BracketLabel.Text = "Polc:";
            // 
            // IncomingPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 423);
            this.Controls.Add(this.BracketField);
            this.Controls.Add(this.BracketLabel);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.CompartmentField);
            this.Controls.Add(this.CompartmentLabel);
            this.Controls.Add(this.RowField);
            this.Controls.Add(this.RowLabel);
            this.Controls.Add(this.colField);
            this.Controls.Add(this.colLabel);
            this.Controls.Add(this.StockField);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.PartNameField);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomingPart";
            this.Text = "IncomingPart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.TextBox PartNameField;
        private System.Windows.Forms.TextBox StockField;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox colField;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.TextBox RowField;
        private System.Windows.Forms.Label RowLabel;
        private System.Windows.Forms.TextBox CompartmentField;
        private System.Windows.Forms.Label CompartmentLabel;
        private System.Windows.Forms.Button FileBtn;
        private System.Windows.Forms.TextBox BracketField;
        private System.Windows.Forms.Label BracketLabel;
    }
}