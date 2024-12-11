using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem
{
    internal class AddStudentsData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string StudentID { set; get; }
        public string StudentName { set; get; }
        public string StudentGender { set; get; }
        public string StudentAddress { set; get; }
        public string StudentGrade { set; get; }
        public string StudentSection { set; get; }
        public string StudentImage { set; get; }
        public string StudentStatus { set; get; }
        public string DateInsert { set; get; }

        public List<AddStudentsData> studentData()
        {
            List<AddStudentsData> listData = new List<AddStudentsData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM students WHERE data_delete IS NULL";

                    using(SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddStudentsData addSdata = new AddStudentsData();
                            addSdata.ID = (int)reader["id"];
                            addSdata.StudentID = reader["student_id"].ToString();
                            addSdata.StudentName = reader["student_name"].ToString();
                            addSdata.StudentGender = reader["student_gender"].ToString();
                            addSdata.StudentAddress = reader["student_address"].ToString();
                            addSdata.StudentGrade = reader["student_grade"].ToString();
                            addSdata.StudentSection = reader["student_section"].ToString();
                            addSdata.StudentImage = reader["student_image"].ToString();
                            addSdata.StudentStatus = reader["student_status"].ToString();
                            addSdata.DateInsert = reader["data_insert"].ToString();

                            listData.Add(addSdata);
                        }
                        reader.Close();
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error connecting Database : " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            
            return listData;
        }

        public List<AddStudentsData> dashboardStudentData()
        {
            List<AddStudentsData> listData = new List<AddStudentsData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM students WHERE data_insert = '" + today.ToString() + "' AND data_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddStudentsData addSdata = new AddStudentsData();
                            addSdata.ID = (int)reader["id"];
                            addSdata.StudentID = reader["student_id"].ToString();
                            addSdata.StudentName = reader["student_name"].ToString();
                            addSdata.StudentGender = reader["student_gender"].ToString();
                            addSdata.StudentAddress = reader["student_address"].ToString();
                            addSdata.StudentGrade = reader["student_grade"].ToString();
                            addSdata.StudentSection = reader["student_section"].ToString();
                            addSdata.StudentImage = reader["student_image"].ToString();
                            addSdata.StudentStatus = reader["student_status"].ToString();
                            addSdata.DateInsert = reader["data_insert"].ToString();

                            listData.Add(addSdata);
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error connecting Database : " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
