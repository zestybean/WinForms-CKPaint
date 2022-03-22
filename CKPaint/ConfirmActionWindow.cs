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
        /// <summary>
        /// 0 = Normal Print Label
        /// 1 = Move Part Back
        /// </summary>
        public int actionState = 0;
        public bool confirmActionButtonSelected = false;
        public string partWOID = "";
        public string partJobNumber = "";

        public ConfirmActionWindow()
        {
            InitializeComponent();
        }

        private void ConfirmActionWindow_Load(object sender, EventArgs e)
        {
            woidTxtLbl.Text = partWOID;
            jobNumTxtLbl.Text = partJobNumber;

            if (actionState == 0)
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
                woidTxtLbl.Text = "MAJOR ERROR";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirmActionButtonSelected = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
