
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
            this.title = new System.Windows.Forms.Label();
            this.partDispositionBtn = new System.Windows.Forms.Button();
            this.partLoaderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(800, 25);
            this.title.TabIndex = 2;
            this.title.Text = "CK PAINT - HOME";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // partDispositionBtn
            // 
            this.partDispositionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDispositionBtn.Location = new System.Drawing.Point(502, 175);
            this.partDispositionBtn.Name = "partDispositionBtn";
            this.partDispositionBtn.Size = new System.Drawing.Size(187, 85);
            this.partDispositionBtn.TabIndex = 4;
            this.partDispositionBtn.Text = "Part Disposition";
            this.partDispositionBtn.UseVisualStyleBackColor = true;
            this.partDispositionBtn.Click += new System.EventHandler(this.partDispositionBtn_Click);
            // 
            // partLoaderBtn
            // 
            this.partLoaderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLoaderBtn.Location = new System.Drawing.Point(99, 175);
            this.partLoaderBtn.Name = "partLoaderBtn";
            this.partLoaderBtn.Size = new System.Drawing.Size(187, 85);
            this.partLoaderBtn.TabIndex = 5;
            this.partLoaderBtn.Text = "Part Loader";
            this.partLoaderBtn.UseVisualStyleBackColor = true;
            this.partLoaderBtn.Click += new System.EventHandler(this.partLoaderBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partLoaderBtn);
            this.Controls.Add(this.partDispositionBtn);
            this.Controls.Add(this.title);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button partDispositionBtn;
        private System.Windows.Forms.Button partLoaderBtn;
    }
}