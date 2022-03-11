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
    }
}
