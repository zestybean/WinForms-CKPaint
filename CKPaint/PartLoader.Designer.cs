
namespace CKPaint
{
    partial class PartLoader
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
            this.debugLabel = new System.Windows.Forms.Label();
            this.printLabelButton = new System.Windows.Forms.Button();
            this.WOIDTxtBox = new System.Windows.Forms.TextBox();
            this.WOIDLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.partsInlineLabel = new System.Windows.Forms.Label();
            this.partsOnFloorLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchJobNumRb = new System.Windows.Forms.RadioButton();
            this.searchWOIDRb = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.getAllReworkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            this.title.TabIndex = 1;
            this.title.Text = "CK PAINT - PART LOADER";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // debugLabel
            // 
            this.debugLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.debugLabel.AutoSize = true;
            this.debugLabel.ForeColor = System.Drawing.Color.White;
            this.debugLabel.Location = new System.Drawing.Point(5, 0);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(57, 13);
            this.debugLabel.TabIndex = 2;
            this.debugLabel.Text = "Debugger:";
            // 
            // printLabelButton
            // 
            this.printLabelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.printLabelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabelButton.ForeColor = System.Drawing.Color.White;
            this.printLabelButton.Location = new System.Drawing.Point(309, 10);
            this.printLabelButton.Name = "printLabelButton";
            this.printLabelButton.Size = new System.Drawing.Size(123, 30);
            this.printLabelButton.TabIndex = 3;
            this.printLabelButton.Text = "Print Label";
            this.printLabelButton.UseVisualStyleBackColor = false;
            this.printLabelButton.Click += new System.EventHandler(this.printLabelButton_Click);
            // 
            // WOIDTxtBox
            // 
            this.WOIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDTxtBox.Location = new System.Drawing.Point(76, 10);
            this.WOIDTxtBox.Name = "WOIDTxtBox";
            this.WOIDTxtBox.Size = new System.Drawing.Size(227, 31);
            this.WOIDTxtBox.TabIndex = 4;
            this.WOIDTxtBox.TextChanged += new System.EventHandler(this.WOIDTxtBox_TextChanged);
            // 
            // WOIDLabel
            // 
            this.WOIDLabel.AutoSize = true;
            this.WOIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WOIDLabel.Location = new System.Drawing.Point(3, 13);
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
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPanel.Controls.Add(this.errorLabel);
            this.controlPanel.Controls.Add(this.printLabelButton);
            this.controlPanel.Controls.Add(this.WOIDTxtBox);
            this.controlPanel.Controls.Add(this.WOIDLabel);
            this.controlPanel.Location = new System.Drawing.Point(12, 480);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1315, 51);
            this.controlPanel.TabIndex = 6;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 565);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1315, 239);
            this.dataGridView2.TabIndex = 7;
            // 
            // partsInlineLabel
            // 
            this.partsInlineLabel.AutoSize = true;
            this.partsInlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsInlineLabel.ForeColor = System.Drawing.Color.White;
            this.partsInlineLabel.Location = new System.Drawing.Point(12, 537);
            this.partsInlineLabel.Name = "partsInlineLabel";
            this.partsInlineLabel.Size = new System.Drawing.Size(167, 25);
            this.partsInlineLabel.TabIndex = 8;
            this.partsInlineLabel.Text = "PARTS-INLINE";
            // 
            // partsOnFloorLabel
            // 
            this.partsOnFloorLabel.AutoSize = true;
            this.partsOnFloorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsOnFloorLabel.ForeColor = System.Drawing.Color.White;
            this.partsOnFloorLabel.Location = new System.Drawing.Point(12, 36);
            this.partsOnFloorLabel.Name = "partsOnFloorLabel";
            this.partsOnFloorLabel.Size = new System.Drawing.Size(205, 25);
            this.partsOnFloorLabel.TabIndex = 9;
            this.partsOnFloorLabel.Text = "PARTS-ONFLOOR";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Location = new System.Drawing.Point(1141, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(171, 38);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh Connection";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTxtBox.Location = new System.Drawing.Point(244, 83);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(227, 31);
            this.SearchTxtBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.searchJobNumRb);
            this.groupBox1.Controls.Add(this.searchWOIDRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 49);
            this.groupBox1.TabIndex = 12;
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
            this.searchJobNumRb.CheckedChanged += new System.EventHandler(this.searchJobNumRb_CheckedChanged);
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
            this.searchWOIDRb.CheckedChanged += new System.EventHandler(this.searchWOIDRb_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(476, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 33);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.debugLabel);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Location = new System.Drawing.Point(12, 810);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 44);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(605, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 87);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // getAllReworkButton
            // 
            this.getAllReworkButton.BackColor = System.Drawing.Color.Gold;
            this.getAllReworkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllReworkButton.ForeColor = System.Drawing.Color.Black;
            this.getAllReworkButton.Location = new System.Drawing.Point(476, 28);
            this.getAllReworkButton.Name = "getAllReworkButton";
            this.getAllReworkButton.Size = new System.Drawing.Size(123, 51);
            this.getAllReworkButton.TabIndex = 15;
            this.getAllReworkButton.Text = "All Rework Parts";
            this.getAllReworkButton.UseVisualStyleBackColor = false;
            this.getAllReworkButton.Click += new System.EventHandler(this.getAllReworkButton_Click);
            // 
            // PartLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1339, 861);
            this.Controls.Add(this.getAllReworkButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.partsOnFloorLabel);
            this.Controls.Add(this.partsInlineLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK-Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LandingPage_FormClosing);
            this.Load += new System.EventHandler(this.LandingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button printLabelButton;
        private System.Windows.Forms.TextBox WOIDTxtBox;
        private System.Windows.Forms.Label WOIDLabel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label partsInlineLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label partsOnFloorLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton searchJobNumRb;
        private System.Windows.Forms.RadioButton searchWOIDRb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button getAllReworkButton;
    }
}

