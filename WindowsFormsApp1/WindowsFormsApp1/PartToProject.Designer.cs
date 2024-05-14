using System;

namespace WindowsFormsApp1
{
    partial class PartToProject
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PartComboBox = new System.Windows.Forms.ComboBox();
            this.PartLabel = new System.Windows.Forms.Label();
            this.ChoosedPartsLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockField = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.PartsListBox = new System.Windows.Forms.ListBox();
            this.InfoLogTextbox = new System.Windows.Forms.TextBox();
            this.InfoLogLabel = new System.Windows.Forms.Label();
            this.ProjectIDLabel = new System.Windows.Forms.Label();
            this.ProjectIDField = new System.Windows.Forms.TextBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 85);
            this.panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(19, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(437, 47);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Alkatrész projekthez rendelése";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 396);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 407);
            this.panel3.TabIndex = 1;
            // 
            // PartComboBox
            // 
            this.PartComboBox.FormattingEnabled = true;
            this.PartComboBox.Location = new System.Drawing.Point(236, 108);
            this.PartComboBox.Name = "PartComboBox";
            this.PartComboBox.Size = new System.Drawing.Size(273, 21);
            this.PartComboBox.TabIndex = 2;
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLabel.Location = new System.Drawing.Point(150, 108);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(70, 16);
            this.PartLabel.TabIndex = 3;
            this.PartLabel.Text = "Alkatrész:";
            // 
            // ChoosedPartsLabel
            // 
            this.ChoosedPartsLabel.AutoSize = true;
            this.ChoosedPartsLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosedPartsLabel.Location = new System.Drawing.Point(150, 238);
            this.ChoosedPartsLabel.Name = "ChoosedPartsLabel";
            this.ChoosedPartsLabel.Size = new System.Drawing.Size(159, 16);
            this.ChoosedPartsLabel.TabIndex = 5;
            this.ChoosedPartsLabel.Text = "Kiválasztott alkatrészek:";
            this.ChoosedPartsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(526, 109);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(49, 16);
            this.StockLabel.TabIndex = 6;
            this.StockLabel.Text = "Darab:";
            // 
            // StockField
            // 
            this.StockField.Location = new System.Drawing.Point(585, 109);
            this.StockField.Name = "StockField";
            this.StockField.Size = new System.Drawing.Size(81, 20);
            this.StockField.TabIndex = 7;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(695, 109);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(91, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Hozzáad";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PartsListBox
            // 
            this.PartsListBox.FormattingEnabled = true;
            this.PartsListBox.Location = new System.Drawing.Point(236, 257);
            this.PartsListBox.Name = "PartsListBox";
            this.PartsListBox.Size = new System.Drawing.Size(273, 186);
            this.PartsListBox.TabIndex = 9;
            this.PartsListBox.SelectedIndexChanged += new System.EventHandler(this.PartsListBox_SelectedIndexChanged);
            // 
            // InfoLogTextbox
            // 
            this.InfoLogTextbox.Location = new System.Drawing.Point(585, 257);
            this.InfoLogTextbox.Multiline = true;
            this.InfoLogTextbox.Name = "InfoLogTextbox";
            this.InfoLogTextbox.Size = new System.Drawing.Size(201, 87);
            this.InfoLogTextbox.TabIndex = 10;
            // 
            // InfoLogLabel
            // 
            this.InfoLogLabel.AutoSize = true;
            this.InfoLogLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLogLabel.Location = new System.Drawing.Point(582, 241);
            this.InfoLogLabel.Name = "InfoLogLabel";
            this.InfoLogLabel.Size = new System.Drawing.Size(133, 13);
            this.InfoLogLabel.TabIndex = 11;
            this.InfoLogLabel.Text = "Információs ablak:";
            this.InfoLogLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ProjectIDLabel
            // 
            this.ProjectIDLabel.AutoSize = true;
            this.ProjectIDLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectIDLabel.Location = new System.Drawing.Point(150, 152);
            this.ProjectIDLabel.Name = "ProjectIDLabel";
            this.ProjectIDLabel.Size = new System.Drawing.Size(70, 16);
            this.ProjectIDLabel.TabIndex = 13;
            this.ProjectIDLabel.Text = "ProjectID:";
            this.ProjectIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProjectIDField
            // 
            this.ProjectIDField.Location = new System.Drawing.Point(236, 151);
            this.ProjectIDField.Name = "ProjectIDField";
            this.ProjectIDField.Size = new System.Drawing.Size(273, 20);
            this.ProjectIDField.TabIndex = 14;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBtn.Location = new System.Drawing.Point(695, 420);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(91, 23);
            this.CheckBtn.TabIndex = 15;
            this.CheckBtn.Text = "Ellenőriz";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // PartToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 488);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.ProjectIDField);
            this.Controls.Add(this.ProjectIDLabel);
            this.Controls.Add(this.InfoLogLabel);
            this.Controls.Add(this.InfoLogTextbox);
            this.Controls.Add(this.PartsListBox);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StockField);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.ChoosedPartsLabel);
            this.Controls.Add(this.PartLabel);
            this.Controls.Add(this.PartComboBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PartToProject";
            this.Text = "PartToProject";
            this.Load += new System.EventHandler(this.PartToProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox PartComboBox;
        private System.Windows.Forms.Label PartLabel;
        private System.Windows.Forms.Label ChoosedPartsLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox StockField;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox PartsListBox;
        private System.Windows.Forms.TextBox InfoLogTextbox;
        private System.Windows.Forms.Label InfoLogLabel;
        private System.Windows.Forms.Label ProjectIDLabel;
        private System.Windows.Forms.TextBox ProjectIDField;
        private System.Windows.Forms.Button CheckBtn;
    }
}