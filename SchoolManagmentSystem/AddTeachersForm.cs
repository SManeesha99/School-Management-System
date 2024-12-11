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
    public partial class AddTeachersForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        public AddTeachersForm()
        {
            InitializeComponent();

            displayTeacherData();
        }

        public void displayTeacherData()
        {
            AddTeachersData addTD = new AddTeachersData();
            teacher_gridData.DataSource = addTD.teacherData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacher_addBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_address.Text == ""
                || teacher_status.Text == ""
                || teacher_image.Image == null
                || imagePath == null)
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
                        string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacherID";

                        using (SqlCommand checkTID = new SqlCommand(checkTeacherID, connect))
                        {
                            checkTID.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                            int count = (int)checkTID.ExecuteScalar();


                            if (count >= 1)
                            {
                                MessageBox.Show("Teacher ID : " + teacher_id + " is already exist",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertQuery = "INSERT INTO teachers " +
                               "(teacher_id,teacher_name,teacher_gender,teacher_address,teacher_image,teacher_status,date_insert)" +
                               "VALUES(@teacherID, @teacherName, @teacherGender, @teacherAddress, @teacherImage, @teacherStatus, @dateInsert)";

                                //save in directory
                                string path = Path.Combine(@"D:\Projects\C#\SchoolManagmentSystem\SchoolManagmentSystem\Teacher_Directory\", teacher_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(imagePath, path, true);


                                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                                {
                                    cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherAddress", teacher_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@teacherImage", path);
                                    cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString());

                                    cmd.ExecuteNonQuery();
                                    displayTeacherData();
                                    MessageBox.Show("Teacher Records Add Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void clearfields()
        {
            teacher_id.Text = "";
            teacher_name.Text = "";
            teacher_address.Text = "";
            teacher_gender.SelectedIndex = -1;
            teacher_image.Image = null;
            teacher_status.SelectedIndex = -1;
            imagePath = "";
        }

        private String imagePath;
        private void teacher_imageUploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                teacher_image.ImageLocation = imagePath;
            }

        }

        private void teacher_clearBtn_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void teacher_updateBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == ""
                || teacher_name.Text == ""
                || teacher_gender.Text == ""
                || teacher_address.Text == ""
                || teacher_status.Text == ""
                || teacher_image.Image == null
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

                        DialogResult check = MessageBox.Show("Are you sure you want to update Teacher ID " +
                             teacher_id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today; // Current date and time
                            string updateQuery = "UPDATE teachers SET teacher_name = @teacherName, teacher_gender = @teacherGender, teacher_address = @teacherAddress, teacher_status = @teacherStatus, date_update = @dateUpdate WHERE teacher_id = @teacherID";

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
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherName", teacher_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherGender", teacher_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherAddress", teacher_address.Text.Trim());
                                //cmd.Parameters.AddWithValue("@teacherImage", path);
                                cmd.Parameters.AddWithValue("@teacherStatus", teacher_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();
                                displayTeacherData();
                                MessageBox.Show("Teacher Records Updated Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void teacher_gridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = teacher_gridData.Rows[e.RowIndex];
                teacher_id.Text = row.Cells[1].Value.ToString();
                teacher_name.Text = row.Cells[2].Value.ToString();
                teacher_gender.Text = row.Cells[3].Value.ToString();
                teacher_address.Text = row.Cells[4].Value.ToString();
                //teacher_image.Image = (Image)row.Cells[5].Value;

                imagePath = row.Cells[5].Value.ToString();
                string imageData = row.Cells[5].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    teacher_image.Image = Image.FromFile(imageData);
                }
                else
                {
                    teacher_image.Image = null;
                }


                teacher_status.Text = row.Cells[6].Value.ToString();
            }
        }

        private void teacher_deleteBtn_Click(object sender, EventArgs e)
        {
            if (teacher_id.Text == "")
            {
                MessageBox.Show("Please select an item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to delete Teacher ID: " + teacher_id.Text + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteQuery = "UPDATE teachers SET date_delete = @dateDelete WHERE teacher_id = @teacherID";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString());
                                cmd.Parameters.AddWithValue("@teacherID", teacher_id.Text.Trim());

                                cmd.ExecuteNonQuery();
                                displayTeacherData();
                                MessageBox.Show("Teacher Records Delete Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
