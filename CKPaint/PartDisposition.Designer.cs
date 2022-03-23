
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartDisposition));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getAllReworkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchJobNumRb = new System.Windows.Forms.RadioButton();
            this.searchWOIDRb = new System.Windows.Forms.RadioButton();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.title.Size = new System.Drawing.Size(1339, 93);
            this.title.TabIndex = 2;
            this.title.Text = "CK PAINT - PART DISPOSITION";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // partsOnFloorLabel
            // 
            this.partsOnFloorLabel.AutoSize = true;
            this.partsOnFloorLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.partsOnFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsOnFloorLabel.ForeColor = System.Drawing.Color.White;
            this.partsOnFloorLabel.Location = new System.Drawing.Point(12, 9);
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
            this.partsInlineLabel.Location = new System.Drawing.Point(12, 439);
            this.partsInlineLabel.Name = "partsInlineLabel";
            this.partsInlineLabel.Size = new System.Drawing.Size(330, 25);
            this.partsInlineLabel.TabIndex = 13;
            this.partsInlineLabel.Text = "PART DISPOSITION-HISTORY";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(12, 487);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1315, 340);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.controlPanel.Location = new System.Drawing.Point(12, 377);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 275);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // disposePartButton
            // 
            this.disposePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.disposePartButton.BackColor = System.Drawing.Color.SeaGreen;
            this.disposePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disposePartButton.ForeColor = System.Drawing.Color.White;
            this.disposePartButton.Location = new System.Drawing.Point(1051, 431);
            this.disposePartButton.Name = "disposePartButton";
            this.disposePartButton.Size = new System.Drawing.Size(276, 50);
            this.disposePartButton.TabIndex = 15;
            this.disposePartButton.Text = "Dispose Part";
            this.disposePartButton.UseVisualStyleBackColor = false;
            this.disposePartButton.Click += new System.EventHandler(this.disposePartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::CKPaint.Properties.Resources.ckt_logo_white300;
            this.pictureBox1.Location = new System.Drawing.Point(1027, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // getAllReworkButton
            // 
            this.getAllReworkButton.BackColor = System.Drawing.Color.Gold;
            this.getAllReworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllReworkButton.ForeColor = System.Drawing.Color.Black;
            this.getAllReworkButton.Location = new System.Drawing.Point(732, 28);
            this.getAllReworkButton.Name = "getAllReworkButton";
            this.getAllReworkButton.Size = new System.Drawing.Size(123, 62);
            this.getAllReworkButton.TabIndex = 22;
            this.getAllReworkButton.Text = "All Rework Parts";
            this.getAllReworkButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(603, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 64);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(474, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 64);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.searchJobNumRb);
            this.groupBox1.Controls.Add(this.searchWOIDRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 49);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By:";
            // 
            // searchJobNumRb
            // 
            this.searchJobNumRb.AutoSize = true;
            this.searchJobNumRb.Checked = true;
            this.searchJobNumRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchJobNumRb.Location = new System.Drawing.Point(6, 18);
            this.searchJobNumRb.Name = "searchJobNumRb";
            this.searchJobNumRb.Size = new System.Drawing.Size(123, 24);
            this.searchJobNumRb.TabIndex = 1;
            this.searchJobNumRb.TabStop = true;
            this.searchJobNumRb.Text = "Job Number";
            this.searchJobNumRb.UseVisualStyleBackColor = true;
            // 
            // searchWOIDRb
            // 
            this.searchWOIDRb.AutoSize = true;
            this.searchWOIDRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWOIDRb.Location = new System.Drawing.Point(143, 18);
            this.searchWOIDRb.Name = "searchWOIDRb";
            this.searchWOIDRb.Size = new System.Drawing.Size(75, 24);
            this.searchWOIDRb.TabIndex = 0;
            this.searchWOIDRb.Text = "WOID";
            this.searchWOIDRb.UseVisualStyleBackColor = true;
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxtBox.Location = new System.Drawing.Point(242, 60);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(227, 31);
            this.SearchTxtBox.TabIndex = 19;
            // 
            // PartDisposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1339, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getAllReworkButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.disposePartButton);
            this.Controls.Add(this.partsOnFloorLabel);
            this.Controls.Add(this.partsInlineLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartDisposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint - Part Disposition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartDisposition_FormClosing);
            this.Load += new System.EventHandler(this.PartDisposition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dpuNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button getAllReworkButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchJobNumRb;
        private System.Windows.Forms.RadioButton searchWOIDRb;
        private System.Windows.Forms.TextBox SearchTxtBox;
    }
}