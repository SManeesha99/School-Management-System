namespace SchoolManagmentSystem
{
    partial class AddStudentsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel2 = new Panel();
            student_status = new ComboBox();
            label8 = new Label();
            student_deleteBtn = new Button();
            student_clearBtn = new Button();
            student_updateBtn = new Button();
            student_addBtn = new Button();
            student_addImageBtn = new Button();
            panel3 = new Panel();
            student_image = new PictureBox();
            student_section = new ComboBox();
            label7 = new Label();
            student_grade = new ComboBox();
            label6 = new Label();
            student_address = new TextBox();
            label5 = new Label();
            student_gender = new ComboBox();
            label4 = new Label();
            student_name = new TextBox();
            label3 = new Label();
            student_id = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            student_dataGrid = new DataGridView();
            label1 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_image).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)student_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(student_status);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(student_deleteBtn);
            panel2.Controls.Add(student_clearBtn);
            panel2.Controls.Add(student_updateBtn);
            panel2.Controls.Add(student_addBtn);
            panel2.Controls.Add(student_addImageBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(student_section);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(student_grade);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(student_address);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(student_gender);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(student_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(student_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 416);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 310);
            panel2.TabIndex = 3;
            // 
            // student_status
            // 
            student_status.FormattingEnabled = true;
            student_status.Items.AddRange(new object[] { "Enrolled", "Pending", "Graduated" });
            student_status.Location = new Point(690, 76);
            student_status.Name = "student_status";
            student_status.Size = new Size(182, 28);
            student_status.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(614, 83);
            label8.Name = "label8";
            label8.Size = new Size(63, 21);
            label8.TabIndex = 18;
            label8.Text = "Status:";
            // 
            // student_deleteBtn
            // 
            student_deleteBtn.BackColor = Color.FromArgb(4, 87, 122);
            student_deleteBtn.FlatAppearance.BorderSize = 0;
            student_deleteBtn.FlatStyle = FlatStyle.Flat;
            student_deleteBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            student_deleteBtn.ForeColor = Color.White;
            student_deleteBtn.Location = new Point(690, 224);
            student_deleteBtn.Name = "student_deleteBtn";
            student_deleteBtn.Size = new Size(113, 40);
            student_deleteBtn.TabIndex = 17;
            student_deleteBtn.Text = "Delete";
            student_deleteBtn.UseVisualStyleBackColor = false;
            student_deleteBtn.Click += student_deleteBtn_Click;
            // 
            // student_clearBtn
            // 
            student_clearBtn.BackColor = Color.FromArgb(4, 87, 122);
            student_clearBtn.FlatAppearance.BorderSize = 0;
            student_clearBtn.FlatStyle = FlatStyle.Flat;
            student_clearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            student_clearBtn.ForeColor = Color.White;
            student_clearBtn.Location = new Point(535, 224);
            student_clearBtn.Name = "student_clearBtn";
            student_clearBtn.Size = new Size(113, 40);
            student_clearBtn.TabIndex = 16;
            student_clearBtn.Text = "Clear";
            student_clearBtn.UseVisualStyleBackColor = false;
            student_clearBtn.Click += student_clearBtn_Click;
            // 
            // student_updateBtn
            // 
            student_updateBtn.BackColor = Color.FromArgb(4, 87, 122);
            student_updateBtn.FlatAppearance.BorderSize = 0;
            student_updateBtn.FlatStyle = FlatStyle.Flat;
            student_updateBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            student_updateBtn.ForeColor = Color.White;
            student_updateBtn.Location = new Point(378, 224);
            student_updateBtn.Name = "student_updateBtn";
            student_updateBtn.Size = new Size(113, 40);
            student_updateBtn.TabIndex = 15;
            student_updateBtn.Text = "Update";
            student_updateBtn.UseVisualStyleBackColor = false;
            student_updateBtn.Click += student_updateBtn_Click;
            // 
            // student_addBtn
            // 
            student_addBtn.BackColor = Color.FromArgb(4, 87, 122);
            student_addBtn.FlatAppearance.BorderSize = 0;
            student_addBtn.FlatStyle = FlatStyle.Flat;
            student_addBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            student_addBtn.ForeColor = Color.White;
            student_addBtn.Location = new Point(220, 224);
            student_addBtn.Name = "student_addBtn";
            student_addBtn.Size = new Size(113, 40);
            student_addBtn.TabIndex = 14;
            student_addBtn.Text = "Add";
            student_addBtn.UseVisualStyleBackColor = false;
            student_addBtn.Click += student_addBtn_Click;
            // 
            // student_addImageBtn
            // 
            student_addImageBtn.BackColor = Color.FromArgb(4, 87, 122);
            student_addImageBtn.FlatAppearance.BorderSize = 0;
            student_addImageBtn.FlatStyle = FlatStyle.Flat;
            student_addImageBtn.ForeColor = Color.White;
            student_addImageBtn.Location = new Point(914, 138);
            student_addImageBtn.Name = "student_addImageBtn";
            student_addImageBtn.Size = new Size(113, 30);
            student_addImageBtn.TabIndex = 13;
            student_addImageBtn.Text = "Upload";
            student_addImageBtn.UseVisualStyleBackColor = false;
            student_addImageBtn.Click += student_addImageBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(student_image);
            panel3.Location = new Point(914, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(113, 111);
            panel3.TabIndex = 12;
            // 
            // student_image
            // 
            student_image.Location = new Point(0, 0);
            student_image.Name = "student_image";
            student_image.Size = new Size(113, 111);
            student_image.SizeMode = PictureBoxSizeMode.StretchImage;
            student_image.TabIndex = 0;
            student_image.TabStop = false;
            // 
            // student_section
            // 
            student_section.FormattingEnabled = true;
            student_section.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F" });
            student_section.Location = new Point(690, 26);
            student_section.Name = "student_section";
            student_section.Size = new Size(182, 28);
            student_section.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(614, 33);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 10;
            label7.Text = "Section:";
            // 
            // student_grade
            // 
            student_grade.FormattingEnabled = true;
            student_grade.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            student_grade.Location = new Point(401, 125);
            student_grade.Name = "student_grade";
            student_grade.Size = new Size(182, 28);
            student_grade.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(319, 132);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 8;
            label6.Text = "Grade:";
            // 
            // student_address
            // 
            student_address.Location = new Point(401, 24);
            student_address.Multiline = true;
            student_address.Name = "student_address";
            student_address.Size = new Size(182, 80);
            student_address.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(319, 33);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 6;
            label5.Text = "Address:";
            // 
            // student_gender
            // 
            student_gender.FormattingEnabled = true;
            student_gender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            student_gender.Location = new Point(114, 125);
            student_gender.Name = "student_gender";
            student_gender.Size = new Size(182, 28);
            student_gender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 132);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // student_name
            // 
            student_name.Location = new Point(114, 74);
            student_name.Multiline = true;
            student_name.Name = "student_name";
            student_name.Size = new Size(182, 30);
            student_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 83);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // student_id
            // 
            student_id.Location = new Point(114, 24);
            student_id.Multiline = true;
            student_id.Name = "student_id";
            student_id.Size = new Size(128, 30);
            student_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 0;
            label2.Text = "Student ID:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(student_dataGrid);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 370);
            panel1.TabIndex = 2;
            // 
            // student_dataGrid
            // 
            student_dataGrid.AllowUserToAddRows = false;
            student_dataGrid.AllowUserToDeleteRows = false;
            student_dataGrid.BackgroundColor = SystemColors.ButtonFace;
            student_dataGrid.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            student_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            student_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            student_dataGrid.Location = new Point(22, 57);
            student_dataGrid.Name = "student_dataGrid";
            student_dataGrid.ReadOnly = true;
            student_dataGrid.RowHeadersVisible = false;
            student_dataGrid.RowHeadersWidth = 51;
            student_dataGrid.RowTemplate.Height = 29;
            student_dataGrid.Size = new Size(1005, 291);
            student_dataGrid.TabIndex = 1;
            student_dataGrid.CellClick += student_dataGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "Student's Data";
            // 
            // AddStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddStudentsForm";
            Size = new Size(1080, 750);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)student_image).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)student_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private TextBox student_address;
        private Label label5;
        private ComboBox student_gender;
        private Label label4;
        private TextBox student_name;
        private Label label3;
        private TextBox student_id;
        private Label label2;
        private Panel panel3;
        private ComboBox student_section;
        private Label label7;
        private ComboBox student_grade;
        private Label label6;
        private Button student_addImageBtn;
        private Button student_deleteBtn;
        private Button student_clearBtn;
        private Button student_updateBtn;
        private Button student_addBtn;
        private PictureBox student_image;
        private Label label8;
        private ComboBox student_status;
        private DataGridView student_dataGrid;
    }
}
