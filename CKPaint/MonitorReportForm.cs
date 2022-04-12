using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using ClosedXML.Excel;

namespace CKPaint
{
    public partial class MonitorReportForm : Form
    {
        string connStr_PBET = ConfigurationManager.ConnectionStrings["PBET"].ConnectionString;

        DataSet reportDataSet = new DataSet();

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
            dateTimeEnd.Value = DateTime.Today;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            reportDataSet.Clear();
            //Series of sql calls to gather data
            using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    sqlConnection.Open();

                    //Execute the stored procedure for Parts OnFloor
                    //and update the data grid view
                    using (SqlCommand sqlCommand = new SqlCommand("spGenerateReportByDateTime", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@REPORTTYPE", "DISPOSITION");
                        sqlCommand.Parameters.AddWithValue("@TIMESTART", dateTimeStart.Value);
                        sqlCommand.Parameters.AddWithValue("@TIMEEND", dateTimeEnd.Value);
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(reportDataSet, "Report");
                        }

                        ThreadSafe(() => dataGridView1.DataSource = reportDataSet);
                        ThreadSafe(() => dataGridView1.DataMember = "Report");

                    }

                    //Close connection after table is filled
                    sqlConnection.Close();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Refresh Table Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(err);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(method);
                }
                else
                {
                    method();
                }
            }
            catch (ObjectDisposedException err)
            {
                MessageBox.Show(err.Message, "Thread Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {

                DataTable reportTable = reportDataSet.Tables[0];


                var workSheet = workbook.Worksheets.Add(reportTable, "DISPOSITION");

                workbook.SaveAs(@"C:\Users\Public\Desktop\CKPaint-Reports\DispositionReport.xlsx");
                
            } 
        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Public\Desktop\CKPaint-Reports\");
        }
    }
}
