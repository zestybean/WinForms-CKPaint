using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace CKPaint
{
    public partial class PartLoader : Form
    {
        //This connection string is called from App.config file, alternatively it could also be hardcoded into this string var.
        string connStr_PBET = ConfigurationManager.ConnectionStrings["PBET"].ConnectionString;
        //string connStr_MODS = ConfigurationManager.ConnectionStrings["MODS"].ConnectionString;

        //This function fills the datagridview from the current data in the
        //db, because the table is using SQL dependency multi-threading needs
        //to be called in order to properly execute commands
        

        //Sql Dependency Object
        public SqlTableDependency<SecondarySchedule> secondaryScheduleDependency;

        public PartLoader()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            //On the start of the program fill the table up from the DB
            //and initialiaze the SQL dependecy functions
           
            RefreshTable();
            StartSecondaryScheduleTableDependency();
            AdjustColumnOrder(dataGridView1);
            AdjustColumnOrder(dataGridView2);
        }

        private void AdjustColumnOrder(DataGridView dv)
        {
            //Rearrange data grid view columns columns
            
            dv.Columns["WOID"].DisplayIndex = 0;
            dv.Columns["WOIDRH"].DisplayIndex = 1;
            dv.Columns["JobNumber"].DisplayIndex = 2;
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

        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
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

        DataSet RefreshTable()
        {
            DataSet floorPartsDataSet = new DataSet();
            DataSet inlinePartsDataSet = new DataSet();

            //Series of sql calls to gather data
            using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    sqlConnection.Open();

                    //Execute the stored procedure for Parts OnFloor
                    //and update the data grid view
                    using (SqlCommand sqlCommand = new SqlCommand("spGetOnFloorParts", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(floorPartsDataSet, "SecondaryScheduleFloorParts");
                        }

                        ThreadSafe(() => dataGridView1.DataSource = floorPartsDataSet);
                        ThreadSafe(() => dataGridView1.DataMember = "SecondaryScheduleFloorParts");

                    }

                    //Execute the stored procedure for Parts Inline
                    //and update the data grid view
                    using (SqlCommand sqlCommand = new SqlCommand("spGetInlineParts", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(inlinePartsDataSet, "SecondaryScheduleInlineParts");
                        }

                        ThreadSafe(() => dataGridView2.DataSource = inlinePartsDataSet);
                        ThreadSafe(() => dataGridView2.DataMember = "SecondaryScheduleInlineParts");

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

            
            return floorPartsDataSet;
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

        private void printLabelButton_Click(object sender, EventArgs e)
        {
            //Check textfield for user input
            if (string.IsNullOrEmpty(WOIDTxtBox.Text))
            {
                errorLabel.Text = "WOID cannot be empty.";
                return;
            }

            SecondarySchedule SecondarySchedule_Part = new SecondarySchedule();

            //Series of sql calls to gather data
            using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
            {

                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("spGetPartAndUpdateToInline", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@WOID", WOIDTxtBox.Text.ToString());
                        var sqlReader = sqlCommand.ExecuteReader();

                        sqlReader.Read();
                        if (sqlReader.HasRows)
                        {
                            SecondarySchedule_Part.JobNumber = sqlReader.GetString(1);
                            SecondarySchedule_Part.SetNumber = sqlReader.GetString(2);
                            SecondarySchedule_Part.PartNumber = sqlReader.GetString(3);
                            SecondarySchedule_Part.ColorCode = sqlReader.GetString(5);
                            SecondarySchedule_Part.Description = sqlReader.GetString(9);
                            SecondarySchedule_Part.RackCode = sqlReader.GetString(11);
                            SecondarySchedule_Part.RackPosition = sqlReader.GetString(12);
                            SecondarySchedule_Part.PaintBlock = sqlReader.GetString(16);
                            SecondarySchedule_Part.WOID = sqlReader.GetString(17);


                            //PRINTING WILL OCCURR HERE!
                            //PrintToZebraHelper.PrintToZebra(SecondarySchedule_Part);
                        }
                        else
                        {
                            debugLabel.Text = "Part does not exist or is inline!";
                        }

                        sqlCommand.Dispose();
                        sqlReader.Close();
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Print Label OnClick Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(err);
                }

                Cursor.Current = Cursors.Default;
                WOIDTxtBox.Clear();
            }
        }


        private void WOIDTxtBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshTable();
            StartSecondaryScheduleTableDependency();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (row.Cells[22].Value != System.DBNull.Value)
            //    {
            //        if (Convert.ToInt32(row.Cells[22].Value) == 1)
            //        {
            //            row.DefaultCellStyle.BackColor = Color.Yellow;
            //        }
            //        else
            //        {
            //            row.DefaultCellStyle.BackColor = Color.White;
            //        }
            //    }

            //}
            
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {

            filterDataGrid();
        }

        private void searchWOIDRb_CheckedChanged(object sender, EventArgs e)
        {
            SearchTxtBox.Clear();
        }

        private void searchJobNumRb_CheckedChanged(object sender, EventArgs e)
        {
            SearchTxtBox.Clear();
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SearchTxtBox.Text);
           (dataGridView1.DataSource as DataSet).Tables[0].DefaultView.RowFilter = string.Format("JobNumber LIKE '{0}'", "JobNumber", SearchTxtBox.Text);
           /////FIX THISSSSSSS
            
        }

        private void filterDataGrid()
        {
            

            
            //if (searchWOIDRb.Checked)
            //{
            //    DataView dv = floorPartsDataSet.Tables[0].DefaultView;
            //    dv.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "WOID", SearchTxtBox.Text);

            //    dataGridView1.DataSource = dv;


            //}

            //if (searchJobNumRb.Checked)
            //{
            //    DataView dv = floorPartsDataSet.Tables[0].DefaultView;
            //    dv.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "JobNumber", SearchTxtBox.Text);
            //    dataGridView1.DataSource = dv;

            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //LOAD DOUBLE CLICK
            string arg = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();

            Console.WriteLine(arg);
            debugLabel.Text = arg;

            SecondarySchedule SecondarySchedule_Part = new SecondarySchedule();

            //Series of sql calls to gather data
            using (SqlConnection sqlConnection = new SqlConnection(connStr_PBET))
            {

                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("spGetPartAndUpdateToInline", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@WOID", arg);
                        var sqlReader = sqlCommand.ExecuteReader();

                        sqlReader.Read();
                        if (sqlReader.HasRows)
                        {
                            SecondarySchedule_Part.JobNumber = sqlReader.GetString(1);
                            SecondarySchedule_Part.SetNumber = sqlReader.GetString(2);
                            SecondarySchedule_Part.PartNumber = sqlReader.GetString(3);
                            SecondarySchedule_Part.ColorCode = sqlReader.GetString(5);
                            SecondarySchedule_Part.Description = sqlReader.GetString(9);
                            SecondarySchedule_Part.RackCode = sqlReader.GetString(11);
                            SecondarySchedule_Part.RackPosition = sqlReader.GetString(12);
                            SecondarySchedule_Part.PaintBlock = sqlReader.GetString(16);
                            SecondarySchedule_Part.WOID = sqlReader.GetString(17);


                            //PRINTING WILL OCCURR HERE!
                            PrintToZebraHelper.PrintToZebra(SecondarySchedule_Part);
                          
                        }
                        else
                        {
                            debugLabel.Text = "Part does not exist or is inline!";
                        }

                        sqlCommand.Dispose();
                        sqlReader.Close();
                    }

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
}
