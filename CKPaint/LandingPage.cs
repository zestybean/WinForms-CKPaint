using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Base.Enums;
using System.Configuration;

namespace CKPaint
{
    public partial class LandingPage : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["PBET"].ConnectionString;


        public SqlTableDependency<SecondarySchedule> secondaryScheduleDependency;

        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            RefreshTable();
            StartSecondaryScheduleTableDependency();
        }

        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            DataSet dataSet = new DataSet();

           

            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("spGetAllSchedule", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataSet, "SecondarySchedule");
                    }

                    ThreadSafe(() => dataGridView1.DataSource = dataSet );
                    ThreadSafe(() => dataGridView1.DataMember = "SecondarySchedule");
                    
                }

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

       
    }
}
