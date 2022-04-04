
namespace CKPaint
{
    partial class SettingsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.settingsLabel = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.settingsDescriptionLabel = new System.Windows.Forms.Label();
            this.printerLabel = new System.Windows.Forms.Label();
            this.printerTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.plantLabel = new System.Windows.Forms.Label();
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.siteLabel = new System.Windows.Forms.Label();
            this.siteTextBox = new System.Windows.Forms.TextBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(584, 25);
            this.settingsLabel.TabIndex = 3;
            this.settingsLabel.Text = "Settings Window";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLabel.ForeColor = System.Drawing.Color.White;
            this.stationLabel.Location = new System.Drawing.Point(146, 133);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(93, 25);
            this.stationLabel.TabIndex = 11;
            this.stationLabel.Text = "Station:";
            // 
            // settingsDescriptionLabel
            // 
            this.settingsDescriptionLabel.AutoSize = true;
            this.settingsDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.settingsDescriptionLabel.Location = new System.Drawing.Point(129, 60);
            this.settingsDescriptionLabel.Name = "settingsDescriptionLabel";
            this.settingsDescriptionLabel.Size = new System.Drawing.Size(329, 48);
            this.settingsDescriptionLabel.TabIndex = 9;
            this.settingsDescriptionLabel.Text = "Please select or edit the following \r\nsettings for the application.";
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerLabel.ForeColor = System.Drawing.Color.White;
            this.printerLabel.Location = new System.Drawing.Point(146, 196);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(89, 25);
            this.printerLabel.TabIndex = 13;
            this.printerLabel.Text = "Printer:";
            // 
            // printerTextBox
            // 
            this.printerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerTextBox.Location = new System.Drawing.Point(151, 224);
            this.printerTextBox.Name = "printerTextBox";
            this.printerTextBox.Size = new System.Drawing.Size(263, 29);
            this.printerTextBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(341, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 44);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(75, 454);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 44);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // plantLabel
            // 
            this.plantLabel.AutoSize = true;
            this.plantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantLabel.ForeColor = System.Drawing.Color.White;
            this.plantLabel.Location = new System.Drawing.Point(146, 260);
            this.plantLabel.Name = "plantLabel";
            this.plantLabel.Size = new System.Drawing.Size(73, 25);
            this.plantLabel.TabIndex = 17;
            this.plantLabel.Text = "Plant:";
            // 
            // plantComboBox
            // 
            this.plantComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.plantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plantComboBox.Items.AddRange(new object[] {
            "BV",
            "MP",
            "GP"});
            this.plantComboBox.Location = new System.Drawing.Point(151, 288);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(263, 32);
            this.plantComboBox.TabIndex = 18;
            this.plantComboBox.SelectedIndexChanged += new System.EventHandler(this.plantComboBox_SelectedIndexChanged);
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteLabel.ForeColor = System.Drawing.Color.White;
            this.siteLabel.Location = new System.Drawing.Point(146, 326);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(60, 25);
            this.siteLabel.TabIndex = 20;
            this.siteLabel.Text = "Site:";
            // 
            // siteTextBox
            // 
            this.siteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteTextBox.Location = new System.Drawing.Point(151, 354);
            this.siteTextBox.Name = "siteTextBox";
            this.siteTextBox.ReadOnly = true;
            this.siteTextBox.Size = new System.Drawing.Size(263, 29);
            this.siteTextBox.TabIndex = 19;
            // 
            // stationComboBox
            // 
            this.stationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Items.AddRange(new object[] {
            "MAINLINE",
            "SPOVEN 1",
            "SPOVEN 2",
            "SPOVEN 3"});
            this.stationComboBox.Location = new System.Drawing.Point(151, 161);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(263, 32);
            this.stationComboBox.TabIndex = 21;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(584, 510);
            this.Controls.Add(this.stationComboBox);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.siteTextBox);
            this.Controls.Add(this.plantComboBox);
            this.Controls.Add(this.plantLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.printerLabel);
            this.Controls.Add(this.printerTextBox);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.settingsDescriptionLabel);
            this.Controls.Add(this.settingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint - Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label settingsDescriptionLabel;
        private System.Windows.Forms.Label printerLabel;
        private System.Windows.Forms.TextBox printerTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label plantLabel;
        private System.Windows.Forms.ComboBox plantComboBox;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.TextBox siteTextBox;
        private System.Windows.Forms.ComboBox stationComboBox;
    }
}