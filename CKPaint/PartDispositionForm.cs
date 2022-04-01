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
    public partial class PartDispositionForm : Form
    {
        public bool disposeActionButtonSelected = false;
        public string disposePartWOID = "";
        public string dispositionPartDefect = "";
        public string dispositionInspectorName = "Test";
        public int dispositionDPUNum = 0;
        public string dispositionResult = "";

        public PartDispositionForm()
        {
            InitializeComponent();

            defectCombo.Text = "";
            dispositionCombo.Text = "";
        }

        private void PartDispositionForm_Load(object sender, EventArgs e)
        {
            WOIDTxtBox.Text = disposePartWOID.ToString().ToUpper();
        }

        private void disposePartButton_Click(object sender, EventArgs e)
        {



            disposeActionButtonSelected = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void InspectorTxtBox_TextChanged(object sender, EventArgs e)
        {
            dispositionInspectorName = InspectorTxtBox.Text;
           
        }

        private void defectCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispositionPartDefect = defectCombo.SelectedItem.ToString().ToUpper();
      
        }

        private void dpuNumBox_ValueChanged(object sender, EventArgs e)
        {
            dispositionDPUNum = Convert.ToInt32(dpuNumBox.Value);
           
        }

        private void dispositionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispositionResult = dispositionCombo.SelectedItem.ToString().ToUpper();
          
        }

    }
}
