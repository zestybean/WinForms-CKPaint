using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace CKPaint
{
    public partial class PartDisposition : Form
    {
        //This connection string is called from App.config file, alternatively it could also be hardcoded into this string var.
        string connStr_PBET = ConfigurationManager.ConnectionStrings["PBET"].ConnectionString;
        //string connStr_MODS = ConfigurationManager.ConnectionStrings["MODS"].ConnectionString;

        //Sql Dependency Object
        public SqlTableDependency<SecondarySchedule> secondaryScheduleDependency;

        public PartDisposition()
        {
            InitializeComponent();
        }

        private void PartDisposition_Load(object sender, EventArgs e)
        {
            //On the start of the program fill the table up from the DB
            //and initialiaze the SQL dependecy functions
            RefreshTable();
            StartSecondaryScheduleTableDependency();
            AdjustColumnOrder(dataGridView1);
        }

        private void PartDisposition_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Stop the dependency when applications is closing
            try
            {
                StopSecondaryScheduleTableDependency();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Form Closing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
        }

        private void AdjustColumnOrder(DataGridView dv)
        {
            //Rearrange data grid view columns columns
            dv.Columns["JobNumber"].DisplayIndex = 0;
            dv.Columns["WOID"].DisplayIndex = 1;
            dv.Columns["WOIDRH"].DisplayIndex = 2;
            dv.Columns["PartNumber"].DisplayIndex = 3;
            dv.Columns["PartNumberRH"].DisplayIndex = 4;
            dv.Columns["ColorCode"].DisplayIndex = 5;
            dv.Columns["SetNumber"].DisplayIndex = 6;
            dv.Columns["PartInline"].DisplayIndex = 7;
            dv.Columns["PartRework"].DisplayIndex = 8;
            dv.Columns["PartDisposed"].DisplayIndex = 9;

            //Ignore these
            dv.Columns["ScheduleID"].Visible = false;
            dv.Columns["Primer"].Visible = false;
            dv.Columns["ProductType"].Visible = false;
            dv.Columns["ProductPlatform"].Visible = false;
            dv.Columns["Description"].Visible = false;
            dv.Columns["DescriptionRH"].Visible = false;
            dv.Columns["RackPosition"].Visible = false;
            dv.Columns["RackPositionRH"].Visible = false;
            dv.Columns["AssembleDate"].Visible = false;
            dv.Columns["PaintBlock"].Visible = false;
            dv.Columns["ShipDate"].Visible = false;
            dv.Columns["ImportDate"].Visible = false;
        }

        void RefreshTable()
        {
            //This function fills the datagridview from the current data in the
            //db, because the table is using SQL dependency multi-threading needs
            //to be called in order to properly execute commands
            DataSet inlinePartsDataSet = new DataSet();
            DataSet dispositionHistoryDataSet = new DataSet();

            //Series of sql calls to gather data
            using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    sqlConnection.Open();

                    //Execute the stored procedure for Parts OnFloor
                    //and update the data grid view
                    using (SqlCommand sqlCommand = new SqlCommand("spGetInlineParts", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(inlinePartsDataSet, "SecondarySchedule");
                        }

                        ThreadSafe(() => dataGridView1.DataSource = inlinePartsDataSet);
                        ThreadSafe(() => dataGridView1.DataMember = "SecondarySchedule");

                    }

                    //Execute the stored procedure for Parts Inline
                    //and update the data grid view
                    //DISPOSITION HISTORY HERE
                    using (SqlCommand sqlCommand = new SqlCommand("spGetDispositionHistory", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(dispositionHistoryDataSet, "SecondarySchedule");
                        }

                        ThreadSafe(() => dataGridView2.DataSource = dispositionHistoryDataSet);
                        ThreadSafe(() => dataGridView2.DataMember = "SecondarySchedule");

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
                MessageBox.Show(err.Message, "Tread Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
        }


        private bool StartSecondaryScheduleTableDependency()
        {
            try
            {
                //Init the sql dependency using the connection string
                //after, point to the functions handling the onchanged and 
                //error functions
                secondaryScheduleDependency = new SqlTableDependency<SecondarySchedule>(connStr_PBET);
                secondaryScheduleDependency.OnChanged += SecondaryScheduleTableDependency_OnChange;
                secondaryScheduleDependency.OnError += SecondaryScheduleTableDependency_OnError;
                secondaryScheduleDependency.Start();
                return true;
            }
            catch (Exception err)
            {

                MessageBox.Show("Error setting up the table dependency please check the network and contact the shift supervisor.",
                    "Secondary Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }

            return false;
        }

        private bool StopSecondaryScheduleTableDependency()
        {
            try
            {
                if (secondaryScheduleDependency != null)
                {
                    secondaryScheduleDependency.Stop();
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Stop Secondary Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
            return false;
        }

        private void SecondaryScheduleTableDependency_OnError(object sender, ErrorEventArgs err)
        {
            MessageBox.Show(err.Message, "Secondary Dependency OnError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(err.Error.Message);
        }

        private void SecondaryScheduleTableDependency_OnChange(object sender, RecordChangedEventArgs<SecondarySchedule> ent)
        {
            try
            {
                var changedEntity = ent.Entity;

                switch (ent.ChangeType)
                {
                    case ChangeType.Insert:
                        {
                            RefreshTable();
                        }
                        break;
                    case ChangeType.Update:
                        {
                            RefreshTable();
                        }
                        break;
                    case ChangeType.Delete:
                        {
                            RefreshTable();
                        }
                        break;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Secondary Dependency OnChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(err);
            }
        }

        private void disposePartButton_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            //DISPOSITION DOUBLE CLICK
            string partWOID = dataGridView1.Rows[e.RowIndex].Cells[19].Value.ToString();
            

            PartDispositionForm partDispositionForm = new PartDispositionForm();
            partDispositionForm.disposePartWOID = partWOID;
            

            partDispositionForm.ShowDialog();
            if (partDispositionForm.disposeActionButtonSelected)
            {
                //SecondarySchedule SecondarySchedule_Part = new SecondarySchedule();
                PartDispositionHistory PartDispositionHistory_Part = new PartDispositionHistory();

                //Series of sql calls to gather data
                using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
                {

                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        sqlConnection.Open();
                        using (SqlCommand sqlCommand = new SqlCommand("spDisposePartByWOID", sqlConnection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@WOID", partDispositionForm.disposePartWOID);
                            sqlCommand.Parameters.AddWithValue("@DISPOSITION", partDispositionForm.dispositionResult.ToString().ToUpper());
                            var sqlReader = sqlCommand.ExecuteReader();

                            sqlReader.Read();
                            if (sqlReader.HasRows)
                            {
                                PartDispositionHistory_Part.InspectorName = partDispositionForm.dispositionInspectorName.ToString().ToUpper();
                                PartDispositionHistory_Part.JobNumber = sqlReader.GetString(2);
                                PartDispositionHistory_Part.PartNumber = sqlReader.GetString(4);
                                PartDispositionHistory_Part.PartNumberRH = sqlReader.GetString(5);
                                PartDispositionHistory_Part.ColorCode = sqlReader.GetString(6);
                                PartDispositionHistory_Part.InspectorID = "000000"; //FIX
                                PartDispositionHistory_Part.PaintStation = sqlReader.GetString(17);
                                PartDispositionHistory_Part.PaintDate = sqlReader.GetDateTime(16);
                                PartDispositionHistory_Part.PartProcess = "Placeholder"; // FIX ROBOT OR MANUAL from the disp form
                                PartDispositionHistory_Part.ProductType = sqlReader.GetString(8);
                                PartDispositionHistory_Part.WOID = sqlReader.GetString(19);
                                PartDispositionHistory_Part.WOIDRH = sqlReader.GetString(20);
                                PartDispositionHistory_Part.PartDefect = partDispositionForm.dispositionPartDefect.ToString().ToUpper();
                                PartDispositionHistory_Part.DPUCount = Convert.ToInt16(partDispositionForm.dispositionDPUNum);
                                PartDispositionHistory_Part.PartDisposition = partDispositionForm.dispositionResult.ToString().ToUpper();
                                PartDispositionHistory_Part.PartDescription = sqlReader.GetString(10);
                                PartDispositionHistory_Part.PartDescriptionRH = sqlReader.GetString(11);
                                PartDispositionHistory_Part.DispositionDate = DateTime.Now;
                            }
                            else
                            {
                                Console.WriteLine("Part does not exist or is inline!");
                            }

                            sqlCommand.Dispose();
                            sqlReader.Close();
                        }

                        //THIS NEEDS A BOUNDARY CHECK
                        using (SqlCommand sqlCommand = new SqlCommand("spInsertDispositionHistory", sqlConnection))
                        {
                            Console.WriteLine(PartDispositionHistory_Part.InspectorName);

                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            sqlCommand.Parameters.AddWithValue("@INSPECTORNAME", PartDispositionHistory_Part.InspectorName);
                            sqlCommand.Parameters.AddWithValue("@JOBNUMBER", PartDispositionHistory_Part.JobNumber);
                            sqlCommand.Parameters.AddWithValue("@PARTNUMBER", PartDispositionHistory_Part.PartNumber);
                            sqlCommand.Parameters.AddWithValue("@PARTNUMBERRH", PartDispositionHistory_Part.PartNumberRH);
                            sqlCommand.Parameters.AddWithValue("@COLORCODE", PartDispositionHistory_Part.ColorCode);
                            sqlCommand.Parameters.AddWithValue("@PRODUCTTYPE", PartDispositionHistory_Part.ProductType);
                            sqlCommand.Parameters.AddWithValue("@INSPECTORID", PartDispositionHistory_Part.InspectorID);
                            sqlCommand.Parameters.AddWithValue("@PAINTSTATION", PartDispositionHistory_Part.PaintStation);
                            sqlCommand.Parameters.AddWithValue("@PAINTDATE", PartDispositionHistory_Part.PaintDate);
                            sqlCommand.Parameters.AddWithValue("@PARTPROCESS", PartDispositionHistory_Part.PartProcess);
                            sqlCommand.Parameters.AddWithValue("@WOID", PartDispositionHistory_Part.WOID);
                            sqlCommand.Parameters.AddWithValue("@WOIDRH", PartDispositionHistory_Part.WOIDRH);
                            sqlCommand.Parameters.AddWithValue("@PARTDEFECT", PartDispositionHistory_Part.PartDefect);
                            sqlCommand.Parameters.AddWithValue("@DPUCOUNT", PartDispositionHistory_Part.DPUCount);
                            sqlCommand.Parameters.AddWithValue("@PARTDISPOSITION", PartDispositionHistory_Part.PartDisposition);
                            sqlCommand.Parameters.AddWithValue("@PARTDESCRIPTION", PartDispositionHistory_Part.PartDescription);
                            sqlCommand.Parameters.AddWithValue("@PARTDESCRIPTIONRH", PartDispositionHistory_Part.PartDescriptionRH);
                            sqlCommand.Parameters.AddWithValue("@DISPOSITIONDATE", PartDispositionHistory_Part.DispositionDate);

                            sqlCommand.ExecuteNonQuery();

                            sqlCommand.Dispose();

                        }


                        sqlConnection.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Print Label OnClick Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine(err);
                    }

                    Cursor.Current = Cursors.Default;

                }
            }

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
