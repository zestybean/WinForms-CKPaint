
namespace CKPaint
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.title = new System.Windows.Forms.Label();
            this.partDispositionBtn = new System.Windows.Forms.Button();
            this.partLoaderBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 60);
            this.title.TabIndex = 2;
            this.title.Text = "CK PAINT - HOME";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partDispositionBtn
            // 
            this.partDispositionBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.partDispositionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDispositionBtn.ForeColor = System.Drawing.Color.White;
            this.partDispositionBtn.Location = new System.Drawing.Point(601, 117);
            this.partDispositionBtn.Name = "partDispositionBtn";
            this.partDispositionBtn.Size = new System.Drawing.Size(187, 85);
            this.partDispositionBtn.TabIndex = 4;
            this.partDispositionBtn.Text = "Part Disposition";
            this.partDispositionBtn.UseVisualStyleBackColor = false;
            this.partDispositionBtn.Click += new System.EventHandler(this.partDispositionBtn_Click);
            // 
            // partLoaderBtn
            // 
            this.partLoaderBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.partLoaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLoaderBtn.ForeColor = System.Drawing.Color.White;
            this.partLoaderBtn.Location = new System.Drawing.Point(12, 117);
            this.partLoaderBtn.Name = "partLoaderBtn";
            this.partLoaderBtn.Size = new System.Drawing.Size(187, 85);
            this.partLoaderBtn.TabIndex = 5;
            this.partLoaderBtn.Text = "Part Loader";
            this.partLoaderBtn.UseVisualStyleBackColor = false;
            this.partLoaderBtn.Click += new System.EventHandler(this.partLoaderBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CKPaint.Properties.Resources.plant;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Developed By Brando Lugo @ CK Technologies LLC. 2022";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.partLoaderBtn);
            this.Controls.Add(this.partDispositionBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CK Paint";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button partDispositionBtn;
        private System.Windows.Forms.Button partLoaderBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}