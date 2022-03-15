﻿using System;
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


        void RefreshTable()
        {
            //This function fills the datagridview from the current data in the
            //db, because the table is using SQL dependency multi-threading needs
            //to be called in order to properly execute commands
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
                    using (SqlCommand sqlCommand = new SqlCommand("spGetInlineParts", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDataAdapter.Fill(floorPartsDataSet, "SecondarySchedule");
                        }

                        ThreadSafe(() => dataGridView1.DataSource = floorPartsDataSet);
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
                            sqlDataAdapter.Fill(inlinePartsDataSet, "SecondarySchedule");
                        }

                        ThreadSafe(() => dataGridView2.DataSource = inlinePartsDataSet);
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
                        sqlCommand.Parameters.AddWithValue("@WOID", WOIDTxtBox.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@DISPOSITION", dispositionCombo.SelectedItem.ToString().ToUpper());
                        var sqlReader = sqlCommand.ExecuteReader();

                        sqlReader.Read();
                        if (sqlReader.HasRows)
                        {
                            PartDispositionHistory_Part.InspectorName = InspectorTxtBox.Text.ToString().ToUpper();
                            PartDispositionHistory_Part.JobNumber = sqlReader.GetString(1);
                            PartDispositionHistory_Part.PartNumber = sqlReader.GetString(3);
                            PartDispositionHistory_Part.PartColor = sqlReader.GetString(5);
                            PartDispositionHistory_Part.InspectorID = "000000";
                            PartDispositionHistory_Part.Machine = "Mainline";
                            PartDispositionHistory_Part.PartProcess = "Placeholder";
                            PartDispositionHistory_Part.PartType = sqlReader.GetString(9);
                            PartDispositionHistory_Part.WOID = sqlReader.GetString(17);
                            PartDispositionHistory_Part.PartDefect = defectCombo.SelectedItem.ToString().ToUpper();
                            PartDispositionHistory_Part.DPUCount = Convert.ToInt16(dpuNumBox.Value);
                            PartDispositionHistory_Part.PartDisposition = dispositionCombo.SelectedItem.ToString().ToUpper();
                            PartDispositionHistory_Part.PartDescription = "Placeholder";
                            PartDispositionHistory_Part.DispositionDate = DateTime.Now;

                            Console.WriteLine(PartDispositionHistory_Part.DispositionDate);
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
                        sqlCommand.Parameters.AddWithValue("@PARTCOLOR", PartDispositionHistory_Part.PartColor);
                        sqlCommand.Parameters.AddWithValue("@PARTTYPE", PartDispositionHistory_Part.PartColor);
                        sqlCommand.Parameters.AddWithValue("@INSPECTORID", PartDispositionHistory_Part.InspectorID);
                        sqlCommand.Parameters.AddWithValue("@MACHINE", PartDispositionHistory_Part.Machine);
                        sqlCommand.Parameters.AddWithValue("@PARTPROCESS", PartDispositionHistory_Part.PartProcess);
                        sqlCommand.Parameters.AddWithValue("@WOID", PartDispositionHistory_Part.WOID);
                        sqlCommand.Parameters.AddWithValue("@PARTDEFECT", PartDispositionHistory_Part.PartDefect);
                        sqlCommand.Parameters.AddWithValue("@DPUCOUNT", PartDispositionHistory_Part.DPUCount);
                        sqlCommand.Parameters.AddWithValue("@PARTDISPOSITION", PartDispositionHistory_Part.PartDisposition);
                        sqlCommand.Parameters.AddWithValue("@PARTDESCRIPTION", PartDispositionHistory_Part.PartDescription);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DISPOSITION DOUBLE CLICK
            string arg = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            Console.WriteLine(arg);
        }
    }
}
