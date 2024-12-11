namespace SchoolManagmentSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            addTeachersBtn = new Button();
            addStudentBtn = new Button();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboardForm1 = new DashboardForm();
            addStudentsForm1 = new AddStudentsForm();
            addTeachersForm1 = new AddTeachersForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1390, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1356, 9);
            label2.Name = "label2";
            label2.Size = new Size(22, 23);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 23);
            label1.TabIndex = 0;
            label1.Text = "School Management System | Main";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 87, 122);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(addTeachersBtn);
            panel2.Controls.Add(addStudentBtn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 750);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Image = Properties.Resources.account_logout_24;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(21, 688);
            button4.Name = "button4";
            button4.Size = new Size(140, 50);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // addTeachersBtn
            // 
            addTeachersBtn.Cursor = Cursors.Hand;
            addTeachersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 45, 64);
            addTeachersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 45, 64);
            addTeachersBtn.FlatStyle = FlatStyle.Flat;
            addTeachersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addTeachersBtn.ForeColor = Color.White;
            addTeachersBtn.Image = Properties.Resources.teacher_32;
            addTeachersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addTeachersBtn.Location = new Point(21, 338);
            addTeachersBtn.Name = "addTeachersBtn";
            addTeachersBtn.Size = new Size(267, 50);
            addTeachersBtn.TabIndex = 4;
            addTeachersBtn.Text = "Add Teachers";
            addTeachersBtn.UseVisualStyleBackColor = true;
            addTeachersBtn.Click += addTeachersBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Cursor = Cursors.Hand;
            addStudentBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 45, 64);
            addStudentBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 45, 64);
            addStudentBtn.FlatStyle = FlatStyle.Flat;
            addStudentBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addStudentBtn.ForeColor = Color.White;
            addStudentBtn.Image = Properties.Resources.student_32;
            addStudentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addStudentBtn.Location = new Point(21, 282);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(267, 50);
            addStudentBtn.TabIndex = 3;
            addStudentBtn.Text = "Add Sudent";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 45, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 45, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.dashboard_2_32;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(21, 226);
            button1.Name = "button1";
            button1.Size = new Size(267, 50);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 162);
            label3.Name = "label3";
            label3.Size = new Size(187, 31);
            label3.TabIndex = 1;
            label3.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo2;
            pictureBox1.Location = new Point(100, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(addStudentsForm1);
            panel3.Controls.Add(addTeachersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(310, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 750);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Dock = DockStyle.Fill;
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1080, 750);
            dashboardForm1.TabIndex = 2;
            // 
            // addStudentsForm1
            // 
            addStudentsForm1.Dock = DockStyle.Fill;
            addStudentsForm1.Location = new Point(0, 0);
            addStudentsForm1.Name = "addStudentsForm1";
            addStudentsForm1.Size = new Size(1080, 750);
            addStudentsForm1.TabIndex = 1;
            // 
            // addTeachersForm1
            // 
            addTeachersForm1.Dock = DockStyle.Fill;
            addTeachersForm1.Location = new Point(0, 0);
            addTeachersForm1.Name = "addTeachersForm1";
            addTeachersForm1.Size = new Size(1080, 750);
            addTeachersForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 790);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button addTeachersBtn;
        private Button addStudentBtn;
        private Button button4;
        private Panel panel3;
        private AddTeachersForm addTeachersForm1;
        private AddStudentsForm addStudentsForm1;
        private DashboardForm dashboardForm1;
    }
}