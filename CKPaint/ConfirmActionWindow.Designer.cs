
namespace CKPaint
{
    partial class ConfirmActionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmActionWindow));
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningLogo = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.jobNumberLbl = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.codeDescriptionLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.woidLbl = new System.Windows.Forms.Label();
            this.woidTxtLbl = new System.Windows.Forms.Label();
            this.jobNumTxtLbl = new System.Windows.Forms.Label();
            this.warningPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // warningPanel
            // 
            this.warningPanel.BackColor = System.Drawing.Color.Gold;
            this.warningPanel.Controls.Add(this.warningLogo);
            this.warningPanel.Location = new System.Drawing.Point(0, -2);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(513, 104);
            this.warningPanel.TabIndex = 1;
            // 
            // warningLogo
            // 
            this.warningLogo.BackColor = System.Drawing.Color.Gold;
            this.warningLogo.Image = global::CKPaint.Properties.Resources.warning;
            this.warningLogo.Location = new System.Drawing.Point(219, 14);
            this.warningLogo.Name = "warningLogo";
            this.warningLogo.Size = new System.Drawing.Size(82, 78);
            this.warningLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warningLogo.TabIndex = 0;
            this.warningLogo.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.White;
            this.warningLabel.Location = new System.Drawing.Point(4, 105);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(509, 50);
            this.warningLabel.TabIndex = 2;
            this.warningLabel.Text = "Warning: Please confirm the Job Number/WOID\r\nfor following action on the part. ";
            // 
            // jobNumberLbl
            // 
            this.jobNumberLbl.AutoSize = true;
            this.jobNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumberLbl.ForeColor = System.Drawing.Color.White;
            this.jobNumberLbl.Location = new System.Drawing.Point(159, 168);
            this.jobNumberLbl.Name = "jobNumberLbl";
            this.jobNumberLbl.Size = new System.Drawing.Size(152, 25);
            this.jobNumberLbl.TabIndex = 3;
            this.jobNumberLbl.Text = "Job Number: \r";
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(56, 394);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(134, 44);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Print Label";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(322, 394);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 44);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // codeDescriptionLabel
            // 
            this.codeDescriptionLabel.AutoSize = true;
            this.codeDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.codeDescriptionLabel.Location = new System.Drawing.Point(64, 291);
            this.codeDescriptionLabel.Name = "codeDescriptionLabel";
            this.codeDescriptionLabel.Size = new System.Drawing.Size(392, 25);
            this.codeDescriptionLabel.TabIndex = 6;
            this.codeDescriptionLabel.Text = "Please enter code to confirm action:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTextBox.Location = new System.Drawing.Point(122, 348);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(263, 29);
            this.codeTextBox.TabIndex = 7;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.ForeColor = System.Drawing.Color.White;
            this.codeLabel.Location = new System.Drawing.Point(117, 320);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(74, 25);
            this.codeLabel.TabIndex = 8;
            this.codeLabel.Text = "Code:";
            // 
            // woidLbl
            // 
            this.woidLbl.AutoSize = true;
            this.woidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woidLbl.ForeColor = System.Drawing.Color.White;
            this.woidLbl.Location = new System.Drawing.Point(159, 226);
            this.woidLbl.Name = "woidLbl";
            this.woidLbl.Size = new System.Drawing.Size(79, 25);
            this.woidLbl.TabIndex = 9;
            this.woidLbl.Text = "WOID:";
            // 
            // woidTxtLbl
            // 
            this.woidTxtLbl.AutoSize = true;
            this.woidTxtLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.woidTxtLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.woidTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woidTxtLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.woidTxtLbl.Location = new System.Drawing.Point(214, 251);
            this.woidTxtLbl.Name = "woidTxtLbl";
            this.woidTxtLbl.Size = new System.Drawing.Size(99, 31);
            this.woidTxtLbl.TabIndex = 10;
            this.woidTxtLbl.Text = "000000";
            // 
            // jobNumTxtLbl
            // 
            this.jobNumTxtLbl.AutoSize = true;
            this.jobNumTxtLbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jobNumTxtLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jobNumTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNumTxtLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.jobNumTxtLbl.Location = new System.Drawing.Point(214, 193);
            this.jobNumTxtLbl.Name = "jobNumTxtLbl";
            this.jobNumTxtLbl.Size = new System.Drawing.Size(99, 31);
            this.jobNumTxtLbl.TabIndex = 11;
            this.jobNumTxtLbl.Text = "000000";
            // 
            // ConfirmActionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.jobNumTxtLbl);
            this.Controls.Add(this.woidTxtLbl);
            this.Controls.Add(this.woidLbl);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeDescriptionLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.jobNumberLbl);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.warningPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmActionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint - Confirm Action";
            this.Load += new System.EventHandler(this.ConfirmActionWindow_Load);
            this.warningPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox warningLogo;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label jobNumberLbl;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label codeDescriptionLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label woidLbl;
        private System.Windows.Forms.Label woidTxtLbl;
        private System.Windows.Forms.Label jobNumTxtLbl;
    }
}