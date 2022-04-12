
namespace CKPaint
{
    partial class MonitorReportForm
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
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generateButton = new System.Windows.Forms.Button();
            this.goToButton = new System.Windows.Forms.Button();
            this.reportBox = new System.Windows.Forms.GroupBox();
            this.partInlineHistoryReportBtn = new System.Windows.Forms.RadioButton();
            this.reworkOnFloorRadioBtn = new System.Windows.Forms.RadioButton();
            this.dispositionReportRadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.reportBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Location = new System.Drawing.Point(1133, 9);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(195, 22);
            this.dateTimeStart.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Location = new System.Drawing.Point(1133, 35);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(195, 22);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fromLabel.Location = new System.Drawing.Point(1083, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(44, 16);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "Start:";
            // 
            // ToLabel
            // 
            this.ToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToLabel.Location = new System.Drawing.Point(1088, 34);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(39, 16);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "End:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1315, 783);
            this.dataGridView1.TabIndex = 4;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(936, 9);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(117, 51);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // goToButton
            // 
            this.goToButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToButton.Location = new System.Drawing.Point(12, 9);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(103, 51);
            this.goToButton.TabIndex = 7;
            this.goToButton.Text = "Report File\r\nShortcut";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // reportBox
            // 
            this.reportBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportBox.Controls.Add(this.partInlineHistoryReportBtn);
            this.reportBox.Controls.Add(this.reworkOnFloorRadioBtn);
            this.reportBox.Controls.Add(this.dispositionReportRadioBtn);
            this.reportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportBox.Location = new System.Drawing.Point(413, 9);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(517, 51);
            this.reportBox.TabIndex = 8;
            this.reportBox.TabStop = false;
            this.reportBox.Text = "Report Type";
            // 
            // partInlineHistoryReportBtn
            // 
            this.partInlineHistoryReportBtn.AutoSize = true;
            this.partInlineHistoryReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInlineHistoryReportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.partInlineHistoryReportBtn.Location = new System.Drawing.Point(179, 21);
            this.partInlineHistoryReportBtn.Name = "partInlineHistoryReportBtn";
            this.partInlineHistoryReportBtn.Size = new System.Drawing.Size(146, 20);
            this.partInlineHistoryReportBtn.TabIndex = 2;
            this.partInlineHistoryReportBtn.TabStop = true;
            this.partInlineHistoryReportBtn.Text = "Inline History Report";
            this.partInlineHistoryReportBtn.UseVisualStyleBackColor = true;
            // 
            // reworkOnFloorRadioBtn
            // 
            this.reworkOnFloorRadioBtn.AutoSize = true;
            this.reworkOnFloorRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reworkOnFloorRadioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reworkOnFloorRadioBtn.Location = new System.Drawing.Point(6, 21);
            this.reworkOnFloorRadioBtn.Name = "reworkOnFloorRadioBtn";
            this.reworkOnFloorRadioBtn.Size = new System.Drawing.Size(167, 20);
            this.reworkOnFloorRadioBtn.TabIndex = 1;
            this.reworkOnFloorRadioBtn.TabStop = true;
            this.reworkOnFloorRadioBtn.Text = "Rework OnFloor Report";
            this.reworkOnFloorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dispositionReportRadioBtn
            // 
            this.dispositionReportRadioBtn.AutoSize = true;
            this.dispositionReportRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispositionReportRadioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dispositionReportRadioBtn.Location = new System.Drawing.Point(331, 21);
            this.dispositionReportRadioBtn.Name = "dispositionReportRadioBtn";
            this.dispositionReportRadioBtn.Size = new System.Drawing.Size(182, 20);
            this.dispositionReportRadioBtn.TabIndex = 0;
            this.dispositionReportRadioBtn.TabStop = true;
            this.dispositionReportRadioBtn.Text = "Disposition History Report";
            this.dispositionReportRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MonitorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1339, 861);
            this.Controls.Add(this.reportBox);
            this.Controls.Add(this.goToButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.MinimizeBox = false;
            this.Name = "MonitorReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonitorReportForm";
            this.Load += new System.EventHandler(this.MonitorReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.reportBox.ResumeLayout(false);
            this.reportBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button goToButton;
        private System.Windows.Forms.GroupBox reportBox;
        private System.Windows.Forms.RadioButton partInlineHistoryReportBtn;
        private System.Windows.Forms.RadioButton reworkOnFloorRadioBtn;
        private System.Windows.Forms.RadioButton dispositionReportRadioBtn;
    }
}