using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CKPaint
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            plantLabel.Text = "Plant:   " + CKPaint.Properties.Settings.Default["Plant"];
            siteLabel.Text = "Site:     " + CKPaint.Properties.Settings.Default["Site"];
        }

        private void partLoaderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loaderWindow = new PartLoader();
            loaderWindow.ShowDialog();
            this.Show();
            
        }

        private void partDispositionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form dispositionWindow = new PartDisposition();
            dispositionWindow.ShowDialog();
            this.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Form settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}
