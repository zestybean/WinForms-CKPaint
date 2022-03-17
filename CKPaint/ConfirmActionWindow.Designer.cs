
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
            this.warningLogo = new System.Windows.Forms.PictureBox();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).BeginInit();
            this.warningPanel.SuspendLayout();
            this.SuspendLayout();
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
            // warningPanel
            // 
            this.warningPanel.BackColor = System.Drawing.Color.Gold;
            this.warningPanel.Controls.Add(this.warningLogo);
            this.warningPanel.Location = new System.Drawing.Point(0, -2);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(513, 104);
            this.warningPanel.TabIndex = 1;
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
            this.warningLabel.Text = "Warning: Please confirm the Job Number/WOID\r\nfor the loaded part. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Number: \r\nWOID:";
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
            // 
            // ConfirmActionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.warningPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmActionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint - Confirm Action";
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).EndInit();
            this.warningPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox warningLogo;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}