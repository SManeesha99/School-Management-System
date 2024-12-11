namespace SchoolManagmentSystem
{
    partial class LoginForm
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
            showPass = new CheckBox();
            loginBtn = new Button();
            password = new TextBox();
            label5 = new Label();
            username = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(775, 8);
            label2.Name = "label2";
            label2.Size = new Size(22, 22);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 21);
            label1.TabIndex = 1;
            label1.Text = "School Management System | Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(showPass);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(password);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(233, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 369);
            panel2.TabIndex = 1;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Location = new Point(175, 238);
            showPass.Name = "showPass";
            showPass.RightToLeft = RightToLeft.No;
            showPass.Size = new Size(132, 24);
            showPass.TabIndex = 6;
            showPass.Text = "Show Password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(4, 87, 122);
            loginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            loginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 192);
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(27, 285);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(280, 40);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // password
            // 
            password.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(27, 192);
            password.Multiline = true;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(280, 40);
            password.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 167);
            label5.Name = "label5";
            label5.Size = new Size(96, 22);
            label5.TabIndex = 3;
            label5.Text = "Password :";
            // 
            // username
            // 
            username.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(27, 122);
            username.Multiline = true;
            username.Name = "username";
            username.Size = new Size(280, 40);
            username.TabIndex = 2;
            username.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 97);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 1;
            label4.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 18);
            label3.Name = "label3";
            label3.Size = new Size(126, 41);
            label3.TabIndex = 0;
            label3.Text = "Sign In";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 87, 122);
            ClientSize = new Size(800, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox username;
        private Label label4;
        private Label label3;
        private Button loginBtn;
        private TextBox password;
        private Label label5;
        private CheckBox showPass;
    }
}