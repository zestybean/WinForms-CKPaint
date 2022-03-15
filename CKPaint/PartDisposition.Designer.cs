
namespace CKPaint
{
    partial class PartDisposition
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
            this.title = new System.Windows.Forms.Label();
            this.partsOnFloorLabel = new System.Windows.Forms.Label();
            this.partsInlineLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.defectCombo = new System.Windows.Forms.ComboBox();
            this.dispositionCombo = new System.Windows.Forms.ComboBox();
            this.dpuNumBox = new System.Windows.Forms.NumericUpDown();
            this.InspectorTxtBox = new System.Windows.Forms.TextBox();
            this.inspectorTitle = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.WOIDTxtBox = new System.Windows.Forms.TextBox();
            this.WOIDTitle = new System.Windows.Forms.Label();
            this.dpuTitle = new System.Windows.Forms.Label();
            this.dispositionTitle = new System.Windows.Forms.Label();
            this.defectTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disposePartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.HotTrack;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1339, 25);
            this.title.TabIndex = 2;
            this.title.Text = "CK PAINT - PART DISPOSITION";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // partsOnFloorLabel
            // 
            this.partsOnFloorLabel.AutoSize = true;
            this.partsOnFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsOnFloorLabel.ForeColor = System.Drawing.Color.White;
            this.partsOnFloorLabel.Location = new System.Drawing.Point(12, 35);
            this.partsOnFloorLabel.Name = "partsOnFloorLabel";
            this.partsOnFloorLabel.Size = new System.Drawing.Size(167, 25);
            this.partsOnFloorLabel.TabIndex = 14;
            this.partsOnFloorLabel.Text = "PARTS-INLINE";
            // 
            // partsInlineLabel
            // 
            this.partsInlineLabel.AutoSize = true;
            this.partsInlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsInlineLabel.ForeColor = System.Drawing.Color.White;
            this.partsInlineLabel.Location = new System.Drawing.Point(12, 395);
            this.partsInlineLabel.Name = "partsInlineLabel";
            this.partsInlineLabel.Size = new System.Drawing.Size(330, 25);
            this.partsInlineLabel.TabIndex = 13;
            this.partsInlineLabel.Text = "PART DISPOSITION-HISTORY";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 423);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1315, 239);
            this.dataGridView2.TabIndex = 12;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.Controls.Add(this.defectCombo);
            this.controlPanel.Controls.Add(this.dispositionCombo);
            this.controlPanel.Controls.Add(this.dpuNumBox);
            this.controlPanel.Controls.Add(this.InspectorTxtBox);
            this.controlPanel.Controls.Add(this.inspectorTitle);
            this.controlPanel.Controls.Add(this.errorLabel);
            this.controlPanel.Controls.Add(this.WOIDTxtBox);
            this.controlPanel.Controls.Add(this.WOIDTitle);
            this.controlPanel.Controls.Add(this.dpuTitle);
            this.controlPanel.Controls.Add(this.dispositionTitle);
            this.controlPanel.Controls.Add(this.defectTitle);
            this.controlPanel.Location = new System.Drawing.Point(12, 333);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1315, 51);
            this.controlPanel.TabIndex = 11;
            // 
            // defectCombo
            // 
            this.defectCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectCombo.FormattingEnabled = true;
            this.defectCombo.Items.AddRange(new object[] {
            "Paint Run",
            "Dirt"});
            this.defectCombo.Location = new System.Drawing.Point(740, 8);
            this.defectCombo.Name = "defectCombo";
            this.defectCombo.Size = new System.Drawing.Size(136, 28);
            this.defectCombo.TabIndex = 6;
            // 
            // dispositionCombo
            // 
            this.dispositionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositionCombo.FormattingEnabled = true;
            this.dispositionCombo.Items.AddRange(new object[] {
            "Approved",
            "Finnesse",
            "Rework"});
            this.dispositionCombo.Location = new System.Drawing.Point(1167, 8);
            this.dispositionCombo.Name = "dispositionCombo";
            this.dispositionCombo.Size = new System.Drawing.Size(136, 28);
            this.dispositionCombo.TabIndex = 8;
            // 
            // dpuNumBox
            // 
            this.dpuNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpuNumBox.Location = new System.Drawing.Point(962, 7);
            this.dpuNumBox.Name = "dpuNumBox";
            this.dpuNumBox.Size = new System.Drawing.Size(66, 29);
            this.dpuNumBox.TabIndex = 7;
            // 
            // InspectorTxtBox
            // 
            this.InspectorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectorTxtBox.Location = new System.Drawing.Point(424, 7);
            this.InspectorTxtBox.Name = "InspectorTxtBox";
            this.InspectorTxtBox.Size = new System.Drawing.Size(227, 31);
            this.InspectorTxtBox.TabIndex = 5;
            // 
            // inspectorTitle
            // 
            this.inspectorTitle.AutoSize = true;
            this.inspectorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectorTitle.Location = new System.Drawing.Point(310, 10);
            this.inspectorTitle.Name = "inspectorTitle";
            this.inspectorTitle.Size = new System.Drawing.Size(116, 25);
            this.inspectorTitle.TabIndex = 11;
            this.inspectorTitle.Text = "Inspector:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(74, 38);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 10;
            // 
            // WOIDTxtBox
            // 
            this.WOIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDTxtBox.Location = new System.Drawing.Point(77, 7);
            this.WOIDTxtBox.Name = "WOIDTxtBox";
            this.WOIDTxtBox.Size = new System.Drawing.Size(227, 31);
            this.WOIDTxtBox.TabIndex = 4;
            // 
            // WOIDTitle
            // 
            this.WOIDTitle.AutoSize = true;
            this.WOIDTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDTitle.Location = new System.Drawing.Point(3, 10);
            this.WOIDTitle.Name = "WOIDTitle";
            this.WOIDTitle.Size = new System.Drawing.Size(79, 25);
            this.WOIDTitle.TabIndex = 5;
            this.WOIDTitle.Text = "WOID:";
            // 
            // dpuTitle
            // 
            this.dpuTitle.AutoSize = true;
            this.dpuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpuTitle.Location = new System.Drawing.Point(882, 10);
            this.dpuTitle.Name = "dpuTitle";
            this.dpuTitle.Size = new System.Drawing.Size(83, 25);
            this.dpuTitle.TabIndex = 16;
            this.dpuTitle.Text = "DPU\'s:";
            // 
            // dispositionTitle
            // 
            this.dispositionTitle.AutoSize = true;
            this.dispositionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositionTitle.Location = new System.Drawing.Point(1034, 10);
            this.dispositionTitle.Name = "dispositionTitle";
            this.dispositionTitle.Size = new System.Drawing.Size(136, 25);
            this.dispositionTitle.TabIndex = 19;
            this.dispositionTitle.Text = "Disposition:";
            // 
            // defectTitle
            // 
            this.defectTitle.AutoSize = true;
            this.defectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defectTitle.Location = new System.Drawing.Point(657, 10);
            this.defectTitle.Name = "defectTitle";
            this.defectTitle.Size = new System.Drawing.Size(87, 25);
            this.defectTitle.TabIndex = 13;
            this.defectTitle.Text = "Defect:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 264);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // disposePartButton
            // 
            this.disposePartButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.disposePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disposePartButton.ForeColor = System.Drawing.Color.White;
            this.disposePartButton.Location = new System.Drawing.Point(1179, 387);
            this.disposePartButton.Name = "disposePartButton";
            this.disposePartButton.Size = new System.Drawing.Size(148, 33);
            this.disposePartButton.TabIndex = 15;
            this.disposePartButton.Text = "Dispose Part";
            this.disposePartButton.UseVisualStyleBackColor = false;
            this.disposePartButton.Click += new System.EventHandler(this.disposePartButton_Click);
            // 
            // PartDisposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1339, 696);
            this.Controls.Add(this.disposePartButton);
            this.Controls.Add(this.partsOnFloorLabel);
            this.Controls.Add(this.partsInlineLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Name = "PartDisposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartDisposition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartDisposition_FormClosing);
            this.Load += new System.EventHandler(this.PartDisposition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label partsOnFloorLabel;
        private System.Windows.Forms.Label partsInlineLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox WOIDTxtBox;
        private System.Windows.Forms.Label WOIDTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown dpuNumBox;
        private System.Windows.Forms.Label defectTitle;
        private System.Windows.Forms.TextBox InspectorTxtBox;
        private System.Windows.Forms.Label inspectorTitle;
        private System.Windows.Forms.ComboBox defectCombo;
        private System.Windows.Forms.ComboBox dispositionCombo;
        private System.Windows.Forms.Label dpuTitle;
        private System.Windows.Forms.Label dispositionTitle;
        private System.Windows.Forms.Button disposePartButton;
    }
}