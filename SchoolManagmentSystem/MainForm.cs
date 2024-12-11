using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Comfirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginform = new LoginForm();
                loginform.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dForm = new DashboardForm();
            dForm.displayEnrolleredStudentToday();
            dForm.displayTotalEs();
            dForm.displayTotalGS();
            dForm.displayTotalTT();

            dashboardForm1.Visible = true;
            dashboardForm1.Update();
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = false;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = true;
            addStudentsForm1.Update();
            addTeachersForm1.Visible = false;
        }

        private void addTeachersBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            addStudentsForm1.Visible = false;
            addTeachersForm1.Visible = true;
            addTeachersForm1.Update();
        }
    }
}
