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
    public partial class MonitorReportForm : Form
    {
        public MonitorReportForm()
        {
            InitializeComponent();
        }

        private void MonitorReportForm_Load(object sender, EventArgs e)
        {
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimeStart.Value = DateTime.Today.AddDays(-1);

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateTimeStart.Value = DateTime.Today;


            dateTimeStart.Value = DateTime.Today.AddDays(-1);

        }
    }
}
