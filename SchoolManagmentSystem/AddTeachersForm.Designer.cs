namespace SchoolManagmentSystem
{
    partial class AddTeachersForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            teacher_gridData = new DataGridView();
            panel2 = new Panel();
            teacher_status = new ComboBox();
            label5 = new Label();
            teacher_deleteBtn = new Button();
            teacher_clearBtn = new Button();
            teacher_updateBtn = new Button();
            teacher_addBtn = new Button();
            teacher_imageUploadBtn = new Button();
            panel3 = new Panel();
            teacher_image = new PictureBox();
            teacher_gender = new ComboBox();
            teacher_address = new TextBox();
            teacher_name = new TextBox();
            teacher_id = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_image).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teacher_gridData);
            panel1.Location = new Point(17, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 370);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 1;
            label1.Text = "Teacher's Data";
            // 
            // teacher_gridData
            // 
            teacher_gridData.AllowUserToAddRows = false;
            teacher_gridData.AllowUserToDeleteRows = false;
            teacher_gridData.AllowUserToResizeRows = false;
            teacher_gridData.BackgroundColor = SystemColors.ButtonFace;
            teacher_gridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teacher_gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teacher_gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacher_gridData.Location = new Point(22, 65);
            teacher_gridData.Name = "teacher_gridData";
            teacher_gridData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            teacher_gridData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            teacher_gridData.RowHeadersVisible = false;
            teacher_gridData.RowHeadersWidth = 51;
            teacher_gridData.RowTemplate.Height = 29;
            teacher_gridData.Size = new Size(1005, 291);
            teacher_gridData.TabIndex = 0;
            teacher_gridData.CellClick += teacher_gridData_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(teacher_status);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(teacher_deleteBtn);
            panel2.Controls.Add(teacher_clearBtn);
            panel2.Controls.Add(teacher_updateBtn);
            panel2.Controls.Add(teacher_addBtn);
            panel2.Controls.Add(teacher_imageUploadBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(teacher_gender);
            panel2.Controls.Add(teacher_address);
            panel2.Controls.Add(teacher_name);
            panel2.Controls.Add(teacher_id);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 310);
            panel2.TabIndex = 1;
            // 
            // teacher_status
            // 
            teacher_status.FormattingEnabled = true;
            teacher_status.Items.AddRange(new object[] { "Active", "Inactive" });
            teacher_status.Location = new Point(690, 35);
            teacher_status.Name = "teacher_status";
            teacher_status.Size = new Size(182, 28);
            teacher_status.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(621, 42);
            label5.Name = "label5";
            label5.Size = new Size(63, 21);
            label5.TabIndex = 18;
            label5.Text = "Status:";
            // 
            // teacher_deleteBtn
            // 
            teacher_deleteBtn.BackColor = Color.FromArgb(4, 87, 122);
            teacher_deleteBtn.FlatAppearance.BorderSize = 0;
            teacher_deleteBtn.FlatStyle = FlatStyle.Flat;
            teacher_deleteBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_deleteBtn.ForeColor = Color.White;
            teacher_deleteBtn.Location = new Point(687, 218);
            teacher_deleteBtn.Name = "teacher_deleteBtn";
            teacher_deleteBtn.Size = new Size(117, 40);
            teacher_deleteBtn.TabIndex = 17;
            teacher_deleteBtn.Text = "Delete";
            teacher_deleteBtn.UseVisualStyleBackColor = false;
            teacher_deleteBtn.Click += teacher_deleteBtn_Click;
            // 
            // teacher_clearBtn
            // 
            teacher_clearBtn.BackColor = Color.FromArgb(4, 87, 122);
            teacher_clearBtn.FlatAppearance.BorderSize = 0;
            teacher_clearBtn.FlatStyle = FlatStyle.Flat;
            teacher_clearBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_clearBtn.ForeColor = Color.White;
            teacher_clearBtn.Location = new Point(536, 218);
            teacher_clearBtn.Name = "teacher_clearBtn";
            teacher_clearBtn.Size = new Size(117, 40);
            teacher_clearBtn.TabIndex = 16;
            teacher_clearBtn.Text = "Clear";
            teacher_clearBtn.UseVisualStyleBackColor = false;
            teacher_clearBtn.Click += teacher_clearBtn_Click;
            // 
            // teacher_updateBtn
            // 
            teacher_updateBtn.BackColor = Color.FromArgb(4, 87, 122);
            teacher_updateBtn.FlatAppearance.BorderSize = 0;
            teacher_updateBtn.FlatStyle = FlatStyle.Flat;
            teacher_updateBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_updateBtn.ForeColor = Color.White;
            teacher_updateBtn.Location = new Point(379, 218);
            teacher_updateBtn.Name = "teacher_updateBtn";
            teacher_updateBtn.Size = new Size(117, 40);
            teacher_updateBtn.TabIndex = 15;
            teacher_updateBtn.Text = "Update";
            teacher_updateBtn.UseVisualStyleBackColor = false;
            teacher_updateBtn.Click += teacher_updateBtn_Click;
            // 
            // teacher_addBtn
            // 
            teacher_addBtn.BackColor = Color.FromArgb(4, 87, 122);
            teacher_addBtn.FlatAppearance.BorderSize = 0;
            teacher_addBtn.FlatStyle = FlatStyle.Flat;
            teacher_addBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_addBtn.ForeColor = Color.White;
            teacher_addBtn.Location = new Point(228, 218);
            teacher_addBtn.Name = "teacher_addBtn";
            teacher_addBtn.Size = new Size(117, 40);
            teacher_addBtn.TabIndex = 14;
            teacher_addBtn.Text = "Add";
            teacher_addBtn.UseVisualStyleBackColor = false;
            teacher_addBtn.Click += teacher_addBtn_Click;
            // 
            // teacher_imageUploadBtn
            // 
            teacher_imageUploadBtn.BackColor = Color.FromArgb(4, 87, 122);
            teacher_imageUploadBtn.FlatAppearance.BorderSize = 0;
            teacher_imageUploadBtn.FlatStyle = FlatStyle.Flat;
            teacher_imageUploadBtn.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            teacher_imageUploadBtn.ForeColor = Color.White;
            teacher_imageUploadBtn.Location = new Point(910, 152);
            teacher_imageUploadBtn.Name = "teacher_imageUploadBtn";
            teacher_imageUploadBtn.Size = new Size(117, 30);
            teacher_imageUploadBtn.TabIndex = 13;
            teacher_imageUploadBtn.Text = "Upload";
            teacher_imageUploadBtn.UseVisualStyleBackColor = false;
            teacher_imageUploadBtn.Click += teacher_imageUploadBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(teacher_image);
            panel3.Location = new Point(910, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 125);
            panel3.TabIndex = 12;
            // 
            // teacher_image
            // 
            teacher_image.Location = new Point(0, 0);
            teacher_image.Name = "teacher_image";
            teacher_image.Size = new Size(117, 125);
            teacher_image.SizeMode = PictureBoxSizeMode.StretchImage;
            teacher_image.TabIndex = 0;
            teacher_image.TabStop = false;
            // 
            // teacher_gender
            // 
            teacher_gender.FormattingEnabled = true;
            teacher_gender.Items.AddRange(new object[] { "Male", "Female" });
            teacher_gender.Location = new Point(137, 140);
            teacher_gender.Name = "teacher_gender";
            teacher_gender.Size = new Size(182, 28);
            teacher_gender.TabIndex = 9;
            // 
            // teacher_address
            // 
            teacher_address.Location = new Point(420, 29);
            teacher_address.Multiline = true;
            teacher_address.Name = "teacher_address";
            teacher_address.Size = new Size(182, 100);
            teacher_address.TabIndex = 8;
            teacher_address.TextChanged += textBox3_TextChanged;
            // 
            // teacher_name
            // 
            teacher_name.Location = new Point(137, 82);
            teacher_name.Multiline = true;
            teacher_name.Name = "teacher_name";
            teacher_name.Size = new Size(182, 34);
            teacher_name.TabIndex = 7;
            // 
            // teacher_id
            // 
            teacher_id.Location = new Point(137, 29);
            teacher_id.Multiline = true;
            teacher_id.Name = "teacher_id";
            teacher_id.Size = new Size(146, 34);
            teacher_id.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(338, 42);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 3;
            label7.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 147);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 2;
            label4.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 1;
            label3.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 42);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 0;
            label2.Text = "Teacher ID:";
            // 
            // AddTeachersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddTeachersForm";
            Size = new Size(1080, 750);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacher_gridData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacher_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView teacher_gridData;
        private Panel panel2;
        private Label label1;
        private TextBox teacher_id;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox teacher_gender;
        private TextBox teacher_address;
        private TextBox teacher_name;
        private Button teacher_deleteBtn;
        private Button teacher_clearBtn;
        private Button teacher_updateBtn;
        private Button teacher_addBtn;
        private Button teacher_imageUploadBtn;
        private Panel panel3;
        private ComboBox teacher_status;
        private Label label5;
        private PictureBox teacher_image;
    }
}
