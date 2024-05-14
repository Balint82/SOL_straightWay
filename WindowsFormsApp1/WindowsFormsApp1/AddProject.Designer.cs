namespace WindowsFormsApp1
{
    partial class AddProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerNameLabel = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.TextBox();
            this.DescField = new System.Windows.Forms.TextBox();
            this.CustomerNameField = new System.Windows.Forms.TextBox();
            this.LocationField = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ProjectIDLabel = new System.Windows.Forms.TextBox();
            this.CustomerIDLabel = new System.Windows.Forms.TextBox();
            this.ProjectIDField = new System.Windows.Forms.TextBox();
            this.CustomerIDField = new System.Windows.Forms.TextBox();
            this.CustomerEmailLabel = new System.Windows.Forms.TextBox();
            this.CustomerEmailField = new System.Windows.Forms.TextBox();
            this.WorkTimeField = new System.Windows.Forms.TextBox();
            this.WorkHourLabel = new System.Windows.Forms.TextBox();
            this.WorkPriceField = new System.Windows.Forms.TextBox();
            this.WorkPriceLabel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 593);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 67);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Projekt\r\nhozzáadása";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(171, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 70);
            this.panel3.TabIndex = 1;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerNameLabel.Location = new System.Drawing.Point(295, 89);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(55, 28);
            this.CustomerNameLabel.TabIndex = 3;
            this.CustomerNameLabel.Text = "Név:";
            this.CustomerNameLabel.TextChanged += new System.EventHandler(this.CustomerNameLabel_TextChanged);
            // 
            // LocationLabel
            // 
            this.LocationLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Black;
            this.LocationLabel.Location = new System.Drawing.Point(247, 132);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(103, 28);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Helyszín:";
            // 
            // DescLabel
            // 
            this.DescLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DescLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescLabel.ForeColor = System.Drawing.Color.Black;
            this.DescLabel.Location = new System.Drawing.Point(267, 353);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(83, 28);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Leírás:";
            // 
            // DescField
            // 
            this.DescField.Location = new System.Drawing.Point(364, 353);
            this.DescField.Multiline = true;
            this.DescField.Name = "DescField";
            this.DescField.Size = new System.Drawing.Size(218, 201);
            this.DescField.TabIndex = 6;
            this.DescField.TextChanged += new System.EventHandler(this.DescField_TextChanged);
            // 
            // CustomerNameField
            // 
            this.CustomerNameField.Location = new System.Drawing.Point(364, 90);
            this.CustomerNameField.Multiline = true;
            this.CustomerNameField.Name = "CustomerNameField";
            this.CustomerNameField.Size = new System.Drawing.Size(218, 27);
            this.CustomerNameField.TabIndex = 7;
            this.CustomerNameField.TextChanged += new System.EventHandler(this.CustomerNameField_TextChanged);
            // 
            // LocationField
            // 
            this.LocationField.Location = new System.Drawing.Point(364, 133);
            this.LocationField.Multiline = true;
            this.LocationField.Name = "LocationField";
            this.LocationField.Size = new System.Drawing.Size(218, 27);
            this.LocationField.TabIndex = 8;
            this.LocationField.TextChanged += new System.EventHandler(this.LocationField_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateButton.Location = new System.Drawing.Point(820, 525);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(141, 39);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Létrehozás";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ProjectIDLabel
            // 
            this.ProjectIDLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ProjectIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProjectIDLabel.ForeColor = System.Drawing.Color.Black;
            this.ProjectIDLabel.Location = new System.Drawing.Point(233, 176);
            this.ProjectIDLabel.Name = "ProjectIDLabel";
            this.ProjectIDLabel.Size = new System.Drawing.Size(117, 28);
            this.ProjectIDLabel.TabIndex = 10;
            this.ProjectIDLabel.Text = "Project ID:";
            this.ProjectIDLabel.TextChanged += new System.EventHandler(this.ProjectIDLabel_TextChanged);
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomerIDLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerIDLabel.Location = new System.Drawing.Point(177, 222);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(170, 28);
            this.CustomerIDLabel.TabIndex = 11;
            this.CustomerIDLabel.Text = "Megrendelő ID:";
            this.CustomerIDLabel.TextChanged += new System.EventHandler(this.CustomerIDLabel_TextChanged);
            // 
            // ProjectIDField
            // 
            this.ProjectIDField.Location = new System.Drawing.Point(364, 177);
            this.ProjectIDField.Multiline = true;
            this.ProjectIDField.Name = "ProjectIDField";
            this.ProjectIDField.Size = new System.Drawing.Size(218, 27);
            this.ProjectIDField.TabIndex = 12;
            // 
            // CustomerIDField
            // 
            this.CustomerIDField.Location = new System.Drawing.Point(364, 222);
            this.CustomerIDField.Multiline = true;
            this.CustomerIDField.Name = "CustomerIDField";
            this.CustomerIDField.Size = new System.Drawing.Size(218, 27);
            this.CustomerIDField.TabIndex = 13;
            // 
            // CustomerEmailLabel
            // 
            this.CustomerEmailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerEmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustomerEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.CustomerEmailLabel.Location = new System.Drawing.Point(209, 268);
            this.CustomerEmailLabel.Multiline = true;
            this.CustomerEmailLabel.Name = "CustomerEmailLabel";
            this.CustomerEmailLabel.Size = new System.Drawing.Size(175, 63);
            this.CustomerEmailLabel.TabIndex = 14;
            this.CustomerEmailLabel.Text = "Megrendelő                  e-mail:";
            this.CustomerEmailLabel.TextChanged += new System.EventHandler(this.CustomerEmailLabel_TextChanged_1);
            // 
            // CustomerEmailField
            // 
            this.CustomerEmailField.Location = new System.Drawing.Point(364, 294);
            this.CustomerEmailField.Multiline = true;
            this.CustomerEmailField.Name = "CustomerEmailField";
            this.CustomerEmailField.Size = new System.Drawing.Size(218, 27);
            this.CustomerEmailField.TabIndex = 15;
            // 
            // WorkTimeField
            // 
            this.WorkTimeField.Location = new System.Drawing.Point(756, 223);
            this.WorkTimeField.Multiline = true;
            this.WorkTimeField.Name = "WorkTimeField";
            this.WorkTimeField.Size = new System.Drawing.Size(193, 27);
            this.WorkTimeField.TabIndex = 17;
            // 
            // WorkHourLabel
            // 
            this.WorkHourLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WorkHourLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkHourLabel.ForeColor = System.Drawing.Color.Black;
            this.WorkHourLabel.Location = new System.Drawing.Point(614, 222);
            this.WorkHourLabel.Name = "WorkHourLabel";
            this.WorkHourLabel.Size = new System.Drawing.Size(117, 28);
            this.WorkHourLabel.TabIndex = 16;
            this.WorkHourLabel.Text = "Munkaóra:";
            this.WorkHourLabel.TextChanged += new System.EventHandler(this.WorkHourLabel_TextChanged);
            // 
            // WorkPriceField
            // 
            this.WorkPriceField.Location = new System.Drawing.Point(756, 294);
            this.WorkPriceField.Multiline = true;
            this.WorkPriceField.Name = "WorkPriceField";
            this.WorkPriceField.Size = new System.Drawing.Size(193, 27);
            this.WorkPriceField.TabIndex = 19;
            // 
            // WorkPriceLabel
            // 
            this.WorkPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WorkPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WorkPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.WorkPriceLabel.Location = new System.Drawing.Point(620, 293);
            this.WorkPriceLabel.Name = "WorkPriceLabel";
            this.WorkPriceLabel.Size = new System.Drawing.Size(111, 28);
            this.WorkPriceLabel.TabIndex = 18;
            this.WorkPriceLabel.Text = "Munkadíj:";
            this.WorkPriceLabel.TextChanged += new System.EventHandler(this.WorkPriceLabel_TextChanged_1);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.WorkPriceField);
            this.Controls.Add(this.WorkPriceLabel);
            this.Controls.Add(this.WorkTimeField);
            this.Controls.Add(this.WorkHourLabel);
            this.Controls.Add(this.CustomerEmailField);
            this.Controls.Add(this.CustomerEmailLabel);
            this.Controls.Add(this.CustomerIDField);
            this.Controls.Add(this.ProjectIDField);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.ProjectIDLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LocationField);
            this.Controls.Add(this.CustomerNameField);
            this.Controls.Add(this.DescField);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 630);
            this.MinimumSize = new System.Drawing.Size(1000, 630);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.AddProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox CustomerNameLabel;
        private System.Windows.Forms.TextBox LocationLabel;
        private System.Windows.Forms.TextBox DescLabel;
        private System.Windows.Forms.TextBox DescField;
        private System.Windows.Forms.TextBox CustomerNameField;
        private System.Windows.Forms.TextBox LocationField;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox ProjectIDLabel;
        private System.Windows.Forms.TextBox CustomerIDLabel;
        private System.Windows.Forms.TextBox ProjectIDField;
        private System.Windows.Forms.TextBox CustomerIDField;
        private System.Windows.Forms.TextBox CustomerEmailLabel;
        private System.Windows.Forms.TextBox CustomerEmailField;
        private System.Windows.Forms.TextBox WorkTimeField;
        private System.Windows.Forms.TextBox WorkHourLabel;
        private System.Windows.Forms.TextBox WorkPriceField;
        private System.Windows.Forms.TextBox WorkPriceLabel;
    }
}