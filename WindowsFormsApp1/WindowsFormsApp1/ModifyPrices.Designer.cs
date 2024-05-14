namespace WindowsFormsApp1
{
    partial class ModifyPrices
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ModifyPriceBtn = new System.Windows.Forms.Button();
            this.PartNameField = new System.Windows.Forms.TextBox();
            this.PartNameLabel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelBtn.Location = new System.Drawing.Point(275, 256);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 33);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "Mégse";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ModifyPriceBtn
            // 
            this.ModifyPriceBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ModifyPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModifyPriceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModifyPriceBtn.Location = new System.Drawing.Point(556, 256);
            this.ModifyPriceBtn.Name = "ModifyPriceBtn";
            this.ModifyPriceBtn.Size = new System.Drawing.Size(132, 33);
            this.ModifyPriceBtn.TabIndex = 22;
            this.ModifyPriceBtn.Text = "Ármódosítás";
            this.ModifyPriceBtn.UseVisualStyleBackColor = false;
            this.ModifyPriceBtn.Click += new System.EventHandler(this.ModifyPriceBtn_Click);
            // 
            // PartNameField
            // 
            this.PartNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PartNameField.Location = new System.Drawing.Point(424, 115);
            this.PartNameField.Name = "PartNameField";
            this.PartNameField.Size = new System.Drawing.Size(208, 31);
            this.PartNameField.TabIndex = 17;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PartNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartNameLabel.Enabled = false;
            this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PartNameLabel.Location = new System.Drawing.Point(275, 120);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PartNameLabel.Size = new System.Drawing.Size(127, 24);
            this.PartNameLabel.TabIndex = 16;
            this.PartNameLabel.Text = "Alkatrésznév:";
            this.PartNameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PartNameLabel.TextChanged += new System.EventHandler(this.PartNameLabel_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(143, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 65);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 454);
            this.panel1.TabIndex = 14;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(22, 11);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 61);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Raktár";
            // 
            // PriceField
            // 
            this.PriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceField.Location = new System.Drawing.Point(424, 166);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(208, 31);
            this.PriceField.TabIndex = 25;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceLabel.Enabled = false;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLabel.Location = new System.Drawing.Point(361, 173);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriceLabel.Size = new System.Drawing.Size(41, 24);
            this.PriceLabel.TabIndex = 24;
            this.PriceLabel.Text = "Ár:";
            this.PriceLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ModifyPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.PriceField);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ModifyPriceBtn);
            this.Controls.Add(this.PartNameField);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModifyPrices";
            this.Text = "ModifyPrices";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ModifyPriceBtn;
        private System.Windows.Forms.TextBox PartNameField;
        private System.Windows.Forms.TextBox PartNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.TextBox PriceLabel;
    }
}