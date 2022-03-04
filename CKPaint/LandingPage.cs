﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;

namespace CKPaint
{
    public partial class LandingPage : Form
    {
        //This connection string is called from App.config file, alternatively it could also be hardcoded into this string var.
        string connStr = ConfigurationManager.ConnectionStrings["PBET"].ConnectionString;

        //Sql Dependency Object
        public SqlTableDependency<SecondarySchedule> secondaryScheduleDependency;

        public LandingPage()
        {
            InitializeComponent();
           
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            //On the start of the program fill the table up from the DB
            //and initialiaze the SQL dependecy functions
            RefreshTable();
            StartSecondaryScheduleTableDependency();
        }

        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {   
            //Stop the dependency when applications is closing
            try
            {
                StopSecondaryScheduleTableDependency();
            } catch(Exception err)
            {
                errLbl.Text = err.ToString();
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
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();


                //Execute the stored procedure for Parts OnFloor
                //and update the data grid view
                using (SqlCommand sqlCommand = new SqlCommand("spGetOnFloorParts", sqlConnection))
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
                using (SqlCommand sqlCommand = new SqlCommand("spGetInlineParts", sqlConnection))
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
        }

        public void ThreadSafe(MethodInvoker method)
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(method);
                }else
                {
                    method();
                }
            } catch (ObjectDisposedException e)
            {
                errLbl.Text = e.ToString();
                Console.WriteLine(e);
            }
        }
      

        private bool StartSecondaryScheduleTableDependency()
        {
            try
            {
                //Init the sql dependency using the connection string
                //after, point to the functions handling the onchanged and 
                //error functions
                secondaryScheduleDependency = new SqlTableDependency<SecondarySchedule>(connStr);
                secondaryScheduleDependency.OnChanged += SecondaryScheduleTableDependency_OnChange;
                secondaryScheduleDependency.OnError += SecondaryScheduleTableDependency_OnError;
                secondaryScheduleDependency.Start();
                return true;
            }
            catch(Exception err)
            {
                errLbl.Text = err.ToString();
                Console.WriteLine(err);
            }

            return false;
        }

        private bool StopSecondaryScheduleTableDependency()
        {
            try
            {
                if(secondaryScheduleDependency != null)
                {
                    secondaryScheduleDependency.Stop();
                    return true;
                }
            } catch(Exception err)
            {
                errLbl.Text = err.ToString();
                Console.WriteLine(err);
            }
            return false;
        }

        private void SecondaryScheduleTableDependency_OnError(object sender, ErrorEventArgs err)
        {
            errLbl.Text = err.ToString();
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

            } catch (Exception err)
            {
                errLbl.Text = err.ToString();
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
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("spGetPartByWOID", sqlConnection))
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
                    }

                    sqlCommand.Dispose();
                    sqlReader.Close();
                }

                //THIS HAS NO BUFFER AND WILL ALWAYS OCCURR
                //PRINTING WILL OCCURR HERE!
                PrintToZebraHelper.PrintToZebra(errLbl, SecondarySchedule_Part);


                //Execute the stored procedure for Parts OnFloor
                using (SqlCommand sqlCommand = new SqlCommand("spSendPartInlineByWOID", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@WOID", WOIDTxtBox.Text.ToString());
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                }

                //Close connection after table is filled
                sqlConnection.Close();
            }
        }

        
        private void WOIDTxtBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}