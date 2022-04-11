
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
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(1127, 12);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStart.TabIndex = 0;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(1127, 38);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEnd.TabIndex = 1;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(1095, 12);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(32, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "Start:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(1095, 38);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(29, 13);
            this.ToLabel.TabIndex = 3;
            this.ToLabel.Text = "End:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1315, 785);
            this.dataGridView1.TabIndex = 4;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(965, 7);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(117, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate Report";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(965, 35);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Report";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MonitorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 861);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.MinimizeBox = false;
            this.Name = "MonitorReportForm";
            this.Text = "MonitorReportForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MonitorReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button saveButton;
    }
}