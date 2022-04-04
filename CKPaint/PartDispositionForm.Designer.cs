
namespace CKPaint
{
    partial class PartDispositionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartDispositionForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.disposePartButton = new System.Windows.Forms.Button();
            this.InspectorTxtBox = new System.Windows.Forms.TextBox();
            this.inspectorTitle = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.WOIDTxtBox = new System.Windows.Forms.TextBox();
            this.WOIDTitle = new System.Windows.Forms.Label();
            this.defectCombo = new System.Windows.Forms.ComboBox();
            this.dispositionCombo = new System.Windows.Forms.ComboBox();
            this.dpuNumBox = new System.Windows.Forms.NumericUpDown();
            this.dpuTitle = new System.Windows.Forms.Label();
            this.dispositionTitle = new System.Windows.Forms.Label();
            this.defectTitle = new System.Windows.Forms.Label();
            this.warningLogo = new System.Windows.Forms.PictureBox();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).BeginInit();
            this.warningPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(409, 485);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(134, 44);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // disposePartButton
            // 
            this.disposePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.disposePartButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.disposePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disposePartButton.ForeColor = System.Drawing.Color.White;
            this.disposePartButton.Location = new System.Drawing.Point(12, 485);
            this.disposePartButton.Name = "disposePartButton";
            this.disposePartButton.Size = new System.Drawing.Size(134, 44);
            this.disposePartButton.TabIndex = 6;
            this.disposePartButton.Text = "Dipose Part";
            this.disposePartButton.UseVisualStyleBackColor = false;
            this.disposePartButton.Click += new System.EventHandler(this.disposePartButton_Click);
            // 
            // InspectorTxtBox
            // 
            this.InspectorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectorTxtBox.Location = new System.Drawing.Point(205, 250);
            this.InspectorTxtBox.Name = "InspectorTxtBox";
            this.InspectorTxtBox.Size = new System.Drawing.Size(227, 31);
            this.InspectorTxtBox.TabIndex = 2;
            this.InspectorTxtBox.TextChanged += new System.EventHandler(this.InspectorTxtBox_TextChanged);
            // 
            // inspectorTitle
            // 
            this.inspectorTitle.AutoSize = true;
            this.inspectorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectorTitle.ForeColor = System.Drawing.Color.White;
            this.inspectorTitle.Location = new System.Drawing.Point(91, 253);
            this.inspectorTitle.Name = "inspectorTitle";
            this.inspectorTitle.Size = new System.Drawing.Size(116, 25);
            this.inspectorTitle.TabIndex = 16;
            this.inspectorTitle.Text = "Inspector:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(202, 244);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 15;
            // 
            // WOIDTxtBox
            // 
            this.WOIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDTxtBox.Location = new System.Drawing.Point(205, 204);
            this.WOIDTxtBox.Name = "WOIDTxtBox";
            this.WOIDTxtBox.ReadOnly = true;
            this.WOIDTxtBox.Size = new System.Drawing.Size(227, 31);
            this.WOIDTxtBox.TabIndex = 1;
            // 
            // WOIDTitle
            // 
            this.WOIDTitle.AutoSize = true;
            this.WOIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDTitle.ForeColor = System.Drawing.Color.White;
            this.WOIDTitle.Location = new System.Drawing.Point(131, 207);
            this.WOIDTitle.Name = "WOIDTitle";
            this.WOIDTitle.Size = new System.Drawing.Size(79, 25);
            this.WOIDTitle.TabIndex = 14;
            this.WOIDTitle.Text = "WOID:";
            // 
            // defectCombo
            // 
            this.defectCombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Dirt",
            "Sag Marks",
            "Touch Marks",
            "Solvent Pop",
            "Light Paint",
            "Pin Holes",
            "Fish Eyes",
            "Mottling",
            "Off Color",
            "Wrong Color",
            "Substrate Flaw",
            "Fibers",
            "Part Swap",
            "Wiper Marks",
            "Orange Peel",
            "Fell of Rack",
            "Paint Run",
            "Light Clear",
            "Others",
            "Adhesion Test Failure",
            "Clear Run",
            "Over Spray",
            "Hose Drag",
            "Damaged by Handling",
            "Peel Off",
            "Poor Finesse",
            "Oil",
            "Porosity",
            "Blister",
            "Scratch",
            "Stain",
            "Dent",
            "Sink",
            "Touch up"});
            this.defectCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectCombo.Items.AddRange(new object[] {
            "Dirt",
            "Sag Marks",
            "Touch Marks",
            "Solvent Pop",
            "Light Paint",
            "Pin Holes",
            "Fish Eyes",
            "Mottling",
            "Off Color",
            "Wrong Color",
            "Substrate Flaw",
            "Fibers",
            "Part Swap",
            "Wiper Marks",
            "Orange Peel",
            "Fell of Rack",
            "Paint Run",
            "Light Clear",
            "Others",
            "Adhesion Test Failure",
            "Clear Run",
            "Over Spray",
            "Hose Drag",
            "Damaged by Handling",
            "Peel Off",
            "Poor Finesse",
            "Oil",
            "Porosity",
            "Blister",
            "Scratch",
            "Stain",
            "Dent",
            "Sink",
            "Touch up"});
            this.defectCombo.Location = new System.Drawing.Point(205, 296);
            this.defectCombo.Name = "defectCombo";
            this.defectCombo.Size = new System.Drawing.Size(136, 28);
            this.defectCombo.TabIndex = 3;
            this.defectCombo.SelectedIndexChanged += new System.EventHandler(this.defectCombo_SelectedIndexChanged);
            // 
            // dispositionCombo
            // 
            this.dispositionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dispositionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositionCombo.FormattingEnabled = true;
            this.dispositionCombo.Items.AddRange(new object[] {
            "Approved",
            "Finnesse",
            "Rework",
            "Scrap"});
            this.dispositionCombo.Location = new System.Drawing.Point(205, 384);
            this.dispositionCombo.Name = "dispositionCombo";
            this.dispositionCombo.Size = new System.Drawing.Size(136, 28);
            this.dispositionCombo.TabIndex = 5;
            this.dispositionCombo.SelectedIndexChanged += new System.EventHandler(this.dispositionCombo_SelectedIndexChanged);
            // 
            // dpuNumBox
            // 
            this.dpuNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpuNumBox.Location = new System.Drawing.Point(205, 339);
            this.dpuNumBox.Name = "dpuNumBox";
            this.dpuNumBox.Size = new System.Drawing.Size(66, 29);
            this.dpuNumBox.TabIndex = 4;
            this.dpuNumBox.ValueChanged += new System.EventHandler(this.dpuNumBox_ValueChanged);
            // 
            // dpuTitle
            // 
            this.dpuTitle.AutoSize = true;
            this.dpuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpuTitle.ForeColor = System.Drawing.Color.White;
            this.dpuTitle.Location = new System.Drawing.Point(125, 338);
            this.dpuTitle.Name = "dpuTitle";
            this.dpuTitle.Size = new System.Drawing.Size(83, 25);
            this.dpuTitle.TabIndex = 24;
            this.dpuTitle.Text = "DPU\'s:";
            // 
            // dispositionTitle
            // 
            this.dispositionTitle.AutoSize = true;
            this.dispositionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositionTitle.ForeColor = System.Drawing.Color.White;
            this.dispositionTitle.Location = new System.Drawing.Point(74, 383);
            this.dispositionTitle.Name = "dispositionTitle";
            this.dispositionTitle.Size = new System.Drawing.Size(136, 25);
            this.dispositionTitle.TabIndex = 25;
            this.dispositionTitle.Text = "Disposition:";
            // 
            // defectTitle
            // 
            this.defectTitle.AutoSize = true;
            this.defectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectTitle.ForeColor = System.Drawing.Color.White;
            this.defectTitle.Location = new System.Drawing.Point(122, 298);
            this.defectTitle.Name = "defectTitle";
            this.defectTitle.Size = new System.Drawing.Size(87, 25);
            this.defectTitle.TabIndex = 23;
            this.defectTitle.Text = "Defect:";
            // 
            // warningLogo
            // 
            this.warningLogo.BackColor = System.Drawing.Color.Gold;
            this.warningLogo.Image = global::CKPaint.Properties.Resources.warning;
            this.warningLogo.Location = new System.Drawing.Point(242, 13);
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
            this.warningPanel.Location = new System.Drawing.Point(-1, -1);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(561, 117);
            this.warningPanel.TabIndex = 26;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.White;
            this.warningLabel.Location = new System.Drawing.Point(2, 119);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(558, 50);
            this.warningLabel.TabIndex = 27;
            this.warningLabel.Text = "Warning: Please verify all the information is correct \r\nfor following disposition" +
    " on the part. ";
            // 
            // PartDispositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(555, 541);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.warningPanel);
            this.Controls.Add(this.defectCombo);
            this.Controls.Add(this.dispositionCombo);
            this.Controls.Add(this.dpuNumBox);
            this.Controls.Add(this.dpuTitle);
            this.Controls.Add(this.dispositionTitle);
            this.Controls.Add(this.defectTitle);
            this.Controls.Add(this.InspectorTxtBox);
            this.Controls.Add(this.inspectorTitle);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.WOIDTxtBox);
            this.Controls.Add(this.WOIDTitle);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.disposePartButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartDispositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint - Part Disposition Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PartDispositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningLogo)).EndInit();
            this.warningPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button disposePartButton;
        private System.Windows.Forms.TextBox InspectorTxtBox;
        private System.Windows.Forms.Label inspectorTitle;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox WOIDTxtBox;
        private System.Windows.Forms.Label WOIDTitle;
        private System.Windows.Forms.ComboBox defectCombo;
        private System.Windows.Forms.ComboBox dispositionCombo;
        private System.Windows.Forms.NumericUpDown dpuNumBox;
        private System.Windows.Forms.Label dpuTitle;
        private System.Windows.Forms.Label dispositionTitle;
        private System.Windows.Forms.Label defectTitle;
        private System.Windows.Forms.PictureBox warningLogo;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Label warningLabel;
    }
}