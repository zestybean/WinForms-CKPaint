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
    public partial class ConfirmActionWindow : Form
    {
        public int actionState = 1;

        public ConfirmActionWindow()
        {
            InitializeComponent();
        }

        private void ConfirmActionWindow_Load(object sender, EventArgs e)
        {
            if(actionState == 0)
            {
                warningPanel.BackColor = Color.Gold;
                warningLogo.BackColor = Color.Gold;
                codeDescriptionLabel.Visible = false;
                codeLabel.Visible = false;
                codeTextBox.Visible = false;
                confirmButton.Text = "Print Label";
            } else if(actionState == 1)
            {
                warningPanel.BackColor = Color.Tomato;
                warningLogo.BackColor = Color.Tomato;
                codeDescriptionLabel.Visible = true;
                codeLabel.Visible = true;
                codeTextBox.Visible = true;
                confirmButton.Text = "Confirm";
                confirmButton.BackColor = Color.ForestGreen;
            } else
            {

            }
        }
    }
}
