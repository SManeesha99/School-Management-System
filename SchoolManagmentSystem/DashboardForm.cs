using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class DashboardForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        public DashboardForm()
        {
            InitializeComponent();
            displayTotalEs();
            displayTotalGS();
            displayTotalTT();
            displayEnrolleredStudentToday();
        }

        public void displayTotalEs()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Enrolled' AND data_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempEs = 0;
                        if (reader.Read())
                        {
                            tempEs = Convert.ToInt32(reader[0]);
                            total_ES.Text = tempEs.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connecting Error Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalTT()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM teachers WHERE teacher_status = 'Active' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempEs = 0;
                        if (reader.Read())
                        {
                            tempEs = Convert.ToInt32(reader[0]);
                            total_TT.Text = tempEs.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connecting Error Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalGS()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {

                    connect.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_status = 'Graduated' AND data_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempEs = 0;
                        if (reader.Read())
                        {
                            tempEs = Convert.ToInt32(reader[0]);
                            total_GS.Text = tempEs.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connecting Error Database" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayEnrolleredStudentToday()
        {
            AddStudentsData asData = new AddStudentsData();
            dataGridView1.DataSource = asData.dashboardStudentData();
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }


    }
}
