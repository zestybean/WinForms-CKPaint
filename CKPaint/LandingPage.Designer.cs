﻿
namespace CKPaint
{
    partial class LandingPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.errLbl = new System.Windows.Forms.Label();
            this.printLabelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WOIDLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(260, 25);
            this.title.TabIndex = 1;
            this.title.Text = "CK PAINT - SCHEDULE";
            // 
            // errLbl
            // 
            this.errLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errLbl.AutoSize = true;
            this.errLbl.Location = new System.Drawing.Point(9, 613);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(57, 13);
            this.errLbl.TabIndex = 2;
            this.errLbl.Text = "Debugger:";
            // 
            // printLabelButton
            // 
            this.printLabelButton.Location = new System.Drawing.Point(310, 3);
            this.printLabelButton.Name = "printLabelButton";
            this.printLabelButton.Size = new System.Drawing.Size(86, 30);
            this.printLabelButton.TabIndex = 3;
            this.printLabelButton.Text = "Print Label";
            this.printLabelButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(77, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 31);
            this.textBox1.TabIndex = 4;
            // 
            // WOIDLabel
            // 
            this.WOIDLabel.AutoSize = true;
            this.WOIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDLabel.Location = new System.Drawing.Point(4, 6);
            this.WOIDLabel.Name = "WOIDLabel";
            this.WOIDLabel.Size = new System.Drawing.Size(79, 25);
            this.WOIDLabel.TabIndex = 5;
            this.WOIDLabel.Text = "WOID:";
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.Controls.Add(this.printLabelButton);
            this.controlPanel.Controls.Add(this.textBox1);
            this.controlPanel.Controls.Add(this.WOIDLabel);
            this.controlPanel.Location = new System.Drawing.Point(12, 410);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1315, 110);
            this.controlPanel.TabIndex = 6;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 635);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.errLbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingPage_FormClosing);
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label errLbl;
        private System.Windows.Forms.Button printLabelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label WOIDLabel;
        private System.Windows.Forms.Panel controlPanel;
    }
}

