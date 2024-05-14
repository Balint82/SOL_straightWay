
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WorkPriceField = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.WorkTimeField = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ProjectIDField = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListPriceAndTime = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.ProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkaora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkadij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arkalkulacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NettoAr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalcPriceBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(-1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 321);
            this.panel1.TabIndex = 46;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(4, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(268, 51);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Munkavégzés és -díj";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 63);
            this.panel3.TabIndex = 45;
            // 
            // WorkPriceField
            // 
            this.WorkPriceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkPriceField.Location = new System.Drawing.Point(267, 162);
            this.WorkPriceField.Name = "WorkPriceField";
            this.WorkPriceField.Size = new System.Drawing.Size(157, 31);
            this.WorkPriceField.TabIndex = 52;
            this.WorkPriceField.TextChanged += new System.EventHandler(this.WorkPriceField_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(101, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(157, 24);
            this.textBox6.TabIndex = 51;
            this.textBox6.Text = "Munkadíj:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WorkTimeField
            // 
            this.WorkTimeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkTimeField.Location = new System.Drawing.Point(267, 117);
            this.WorkTimeField.Name = "WorkTimeField";
            this.WorkTimeField.Size = new System.Drawing.Size(157, 31);
            this.WorkTimeField.TabIndex = 50;
            this.WorkTimeField.TextChanged += new System.EventHandler(this.WorkTimeField_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(101, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 24);
            this.textBox4.TabIndex = 49;
            this.textBox4.Text = "Munkaóra:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProjectIDField
            // 
            this.ProjectIDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjectIDField.Location = new System.Drawing.Point(267, 73);
            this.ProjectIDField.Name = "ProjectIDField";
            this.ProjectIDField.Size = new System.Drawing.Size(157, 31);
            this.ProjectIDField.TabIndex = 48;
            this.ProjectIDField.TextChanged += new System.EventHandler(this.ProjectIDField_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(101, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 24);
            this.textBox1.TabIndex = 47;
            this.textBox1.Text = "Projekt Kód:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ListPriceAndTime
            // 
            this.ListPriceAndTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ListPriceAndTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.ListPriceAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListPriceAndTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListPriceAndTime.Location = new System.Drawing.Point(316, 233);
            this.ListPriceAndTime.Name = "ListPriceAndTime";
            this.ListPriceAndTime.Size = new System.Drawing.Size(108, 39);
            this.ListPriceAndTime.TabIndex = 56;
            this.ListPriceAndTime.Text = "Listáz";
            this.ListPriceAndTime.UseVisualStyleBackColor = false;
            this.ListPriceAndTime.Click += new System.EventHandler(this.ListPriceAndTime_Click);
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectID,
            this.Munkaora,
            this.Munkadij,
            this.Arkalkulacio,
            this.NettoAr});
            this.datagrid.Location = new System.Drawing.Point(451, 76);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(543, 282);
            this.datagrid.TabIndex = 57;
            // 
            // ProjectID
            // 
            this.ProjectID.HeaderText = "ProjectID";
            this.ProjectID.Name = "ProjectID";
            // 
            // Munkaora
            // 
            this.Munkaora.HeaderText = "Munkaóra";
            this.Munkaora.Name = "Munkaora";
            // 
            // Munkadij
            // 
            this.Munkadij.HeaderText = "Munkadíj";
            this.Munkadij.Name = "Munkadij";
            // 
            // Arkalkulacio
            // 
            this.Arkalkulacio.HeaderText = "Arkalkulacio";
            this.Arkalkulacio.Name = "Arkalkulacio";
            // 
            // NettoAr
            // 
            this.NettoAr.HeaderText = "Nettó Ár";
            this.NettoAr.Name = "NettoAr";
            // 
            // CalcPriceBtn
            // 
            this.CalcPriceBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CalcPriceBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.CalcPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalcPriceBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalcPriceBtn.Location = new System.Drawing.Point(101, 319);
            this.CalcPriceBtn.Name = "CalcPriceBtn";
            this.CalcPriceBtn.Size = new System.Drawing.Size(323, 39);
            this.CalcPriceBtn.TabIndex = 58;
            this.CalcPriceBtn.Text = "Árkalkuláció";
            this.CalcPriceBtn.UseVisualStyleBackColor = false;
            this.CalcPriceBtn.Click += new System.EventHandler(this.CalcPriceBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 378);
            this.Controls.Add(this.CalcPriceBtn);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.ListPriceAndTime);
            this.Controls.Add(this.WorkPriceField);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.WorkTimeField);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ProjectIDField);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox WorkPriceField;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox WorkTimeField;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox ProjectIDField;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ListPriceAndTime;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkaora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkadij;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arkalkulacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NettoAr;
        private System.Windows.Forms.Button CalcPriceBtn;
    }
}