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
using System.IO;

namespace SchoolManagmentSystem
{
    public partial class AddStudentsForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudentsForm()
        {
            InitializeComponent();
            displayStudentData();
        }

        public void displayStudentData()
        {
            AddStudentsData addSD = new AddStudentsData();
            student_dataGrid.DataSource = addSD.studentData();
        }

        private void student_addBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_grade.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || imagePath == null
                )
            {
                MessageBox.Show("Please fill all blanck fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        //check if teacher id is already existing
                        string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                        using (SqlCommand checkSID = new SqlCommand(checkStudentID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();


                            if (count >= 1)
                            {
                                MessageBox.Show("Student ID : " + student_id + " is already exist",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertQuery = "INSERT INTO students " +
                               "(student_id,student_name,student_gender,student_address,student_grade,student_section,student_image,student_status,data_insert)" +
                               "VALUES(@studentID, @studentName, @studentGender, @studentAddress, @studentGrade, @studentSection, @studentImage, @studentStatus, @dateInsert)";

                                //save in directory
                                string path = Path.Combine(@"D:\Projects\C#\SchoolManagmentSystem\SchoolManagmentSystem\Student_Directory\", student_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePath, path, true);


                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                    cmd.Parameters.AddWithValue("@studentImage", path);
                                    cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();
                                    displayStudentData();
                                    MessageBox.Show("Student Records Add Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearfields();

                                }
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
        }

        private void clearfields()
        {
            student_id.Text = "";
            student_name.Text = "";
            student_gender.SelectedIndex = -1;
            student_address.Text = "";
            student_grade.SelectedIndex = -1;
            student_section.SelectedIndex = -1;
            student_image.Image = null;
            student_status.SelectedIndex = -1;
            imagePath = "";

        }

        private String imagePath;
        private void student_addImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                student_image.ImageLocation = imagePath;
            }
        }

        private void student_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = student_dataGrid.Rows[e.RowIndex];
                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_gender.Text = row.Cells[3].Value.ToString();
                student_address.Text = row.Cells[4].Value.ToString();
                student_grade.Text = row.Cells[5].Value.ToString();
                student_section.Text = row.Cells[6].Value.ToString();
                //teacher_image.Image = (Image)row.Cells[5].Value;

                imagePath = row.Cells[7].Value.ToString();
                string imageData = row.Cells[7].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    student_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    student_image.Image = null;
                }


                student_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void student_clearBtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == ""
                || student_name.Text == ""
                || student_gender.Text == ""
                || student_address.Text == ""
                || student_grade.Text == ""
                || student_section.Text == ""
                || student_status.Text == ""
                || student_image.Image == null
                || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to update Student ID " +
                             student_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today; // Current date and time
                            string updateQuery = "UPDATE students SET student_name = @studentName ,student_gender = @studentGender ,student_address = @studentAddress ,student_grade = @studentGrade ,student_section = @studentSection ,student_status = @studentStatus, data_update = @dateUpdate WHERE student_id = @studentID";

                            // Save the image in the directory
                            //string path = Path.Combine(@"D:\Projects\C#\SchoolManagmentSystem\SchoolManagmentSystem\Teacher_Directory\", teacher_id.Text.Trim() + ".jpg");

                            //string directoryPath = Path.GetDirectoryName(path);

                            //if (!Directory.Exists(directoryPath))
                            //{
                            //    Directory.CreateDirectory(directoryPath);
                            //}

                            //if (File.Exists(path))
                            //{
                            //    File.Delete(path); // Delete the existing file
                            //}

                            //if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                            //{
                            //    MessageBox.Show("Invalid image path. Please re-upload the image.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    return;
                            //}

                            //File.Copy(imagePath, path);

                            using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                //cmd.Parameters.AddWithValue("@studentImage", path);
                                cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();
                                displayStudentData();
                                MessageBox.Show("Student Records Updated Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to the database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select an item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to delete Student ID: " + student_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteQuery = "UPDATE students SET data_delete = @dateDelete WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                cmd.ExecuteNonQuery();
                                displayStudentData ();
                                MessageBox.Show("Student Records Delete Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearfields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error connecting to the database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
        }
    }
}
