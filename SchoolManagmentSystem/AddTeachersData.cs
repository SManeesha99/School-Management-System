using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagmentSystem
{
    internal class AddTeachersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string TechaerID { set; get; }
        public string TeacherName { set; get; }
        public string TeacherGender { set; get; }
        public string TeacherAddress { set; get; }
        public string TeacherImage {  set; get; }
        public string Status { set; get; }
        public string DateInsert { set; get; }
        public string DateUpdate { set; get; }
        public string DateDelete { set; get; }

        public List<AddTeachersData> teacherData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddTeachersData addTdata = new AddTeachersData();
                            addTdata.ID = (int)reader["id"];
                            addTdata.TechaerID = reader["teacher_id"].ToString();
                            addTdata.TeacherName = reader["teacher_name"].ToString();
                            addTdata.TeacherGender = reader["teacher_gender"].ToString();
                            addTdata.TeacherAddress = reader["teacher_address"].ToString();
                            addTdata.TeacherImage = reader["teacher_image"].ToString();
                            addTdata.Status = reader["teacher_status"].ToString();
                            addTdata.DateInsert = reader["date_insert"].ToString();


                            listData.Add(addTdata);

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
