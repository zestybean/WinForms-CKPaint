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
    public partial class SettingsWindow : Form
    {
        

        public SettingsWindow()
        {
            InitializeComponent(); 
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            printerTextBox.Text = CKPaint.Properties.Settings.Default["Printer"].ToString().Trim().ToUpper();
            stationComboBox.Text = CKPaint.Properties.Settings.Default["Station"].ToString().Trim().ToUpper();
            plantComboBox.Text = CKPaint.Properties.Settings.Default["Plant"].ToString().Trim().ToUpper();

            if(plantComboBox.Text == "BV")
            {
                siteTextBox.Text = "5130";
            } else if (plantComboBox.Text == "MP")
            {
                siteTextBox.Text = "5100";
            } else if (plantComboBox.Text == "GP")
            {
                siteTextBox.Text = "5140";
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != "paintck")
            {
                return;
            }

            CKPaint.Properties.Settings.Default["Printer"] = printerTextBox.Text.ToString().Trim().ToUpper();
            CKPaint.Properties.Settings.Default["Station"] = stationComboBox.Text.ToString().Trim().ToUpper();
            CKPaint.Properties.Settings.Default["Plant"] = plantComboBox.Text.ToString().Trim().ToUpper();
            CKPaint.Properties.Settings.Default["Site"] = siteTextBox.Text.ToString().Trim().ToUpper();
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plantComboBox.Text == "BV")
            {
                siteTextBox.Text = "5130";
            }
            else if (plantComboBox.Text == "MP")
            {
                siteTextBox.Text = "5100";
            }
            else if (plantComboBox.Text == "GP")
            {
                siteTextBox.Text = "5140";
            }
        }
    }
}
