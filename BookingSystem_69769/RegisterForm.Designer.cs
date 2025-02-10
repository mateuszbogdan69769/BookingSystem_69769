namespace BookingSystem_69769
{
    partial class RegisterForm
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
            register_showPassword = new CheckBox();
            register_btn = new Button();
            register_password = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            register_login_btn = new Button();
            label5 = new Label();
            register_nameSurname = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // register_showPassword
            // 
            register_showPassword.AutoSize = true;
            register_showPassword.Cursor = Cursors.Hand;
            register_showPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            register_showPassword.Location = new Point(432, 279);
            register_showPassword.Name = "register_showPassword";
            register_showPassword.Size = new Size(98, 20);
            register_showPassword.TabIndex = 19;
            register_showPassword.Text = "Pokaż hasło";
            register_showPassword.UseVisualStyleBackColor = true;
            register_showPassword.CheckedChanged += register_showPassword_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(255, 102, 1);
            register_btn.Cursor = Cursors.Hand;
            register_btn.FlatAppearance.BorderColor = Color.White;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(340, 320);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(120, 30);
            register_btn.TabIndex = 4;
            register_btn.Text = "Zarejestruj się";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Cursor = Cursors.Hand;
            register_password.Font = new Font("Arial", 12F);
            register_password.Location = new Point(270, 243);
            register_password.Multiline = true;
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(260, 30);
            register_password.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(270, 222);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 16;
            label4.Text = "Hasło:";
            // 
            // register_username
            // 
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Cursor = Cursors.Hand;
            register_username.Font = new Font("Arial", 12F);
            register_username.Location = new Point(270, 180);
            register_username.Multiline = true;
            register_username.Name = "register_username";
            register_username.Size = new Size(260, 30);
            register_username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(270, 159);
            label3.Name = "label3";
            label3.Size = new Size(146, 18);
            label3.TabIndex = 14;
            label3.Text = "Nazwa użytkownika:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(270, 50);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 13;
            label2.Text = "Zarejestruj się";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Dock = DockStyle.Right;
            exit.Location = new Point(536, 0);
            exit.Name = "exit";
            exit.Size = new Size(14, 15);
            exit.TabIndex = 12;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 102, 1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(register_login_btn);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 420);
            panel1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.ForeColor = Color.White;
            label7.Location = new Point(65, 50);
            label7.Name = "label7";
            label7.Size = new Size(134, 18);
            label7.TabIndex = 12;
            label7.Text = "System rezerwacji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 80);
            label6.Name = "label6";
            label6.Size = new Size(185, 18);
            label6.TabIndex = 12;
            label6.Text = "Mateusz Bogdan w69769";
            // 
            // register_login_btn
            // 
            register_login_btn.BackColor = Color.FromArgb(229, 92, 1);
            register_login_btn.Cursor = Cursors.Hand;
            register_login_btn.FlatAppearance.BorderColor = Color.White;
            register_login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
            register_login_btn.FlatStyle = FlatStyle.Flat;
            register_login_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            register_login_btn.ForeColor = Color.White;
            register_login_btn.Location = new Point(20, 370);
            register_login_btn.Name = "register_login_btn";
            register_login_btn.Size = new Size(210, 30);
            register_login_btn.TabIndex = 11;
            register_login_btn.Text = "Zaloguj się";
            register_login_btn.UseVisualStyleBackColor = false;
            register_login_btn.Click += register_login_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 346);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 11;
            label5.Text = "Masz juz konto?";
            // 
            // register_nameSurname
            // 
            register_nameSurname.BorderStyle = BorderStyle.FixedSingle;
            register_nameSurname.Cursor = Cursors.Hand;
            register_nameSurname.Font = new Font("Arial", 12F);
            register_nameSurname.Location = new Point(270, 118);
            register_nameSurname.Multiline = true;
            register_nameSurname.Name = "register_nameSurname";
            register_nameSurname.Size = new Size(260, 30);
            register_nameSurname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(270, 97);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 20;
            label1.Text = "Imię i nazwisko:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 420);
            Controls.Add(register_nameSurname);
            Controls.Add(label1);
            Controls.Add(register_showPassword);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox register_showPassword;
        private Button register_btn;
        private TextBox register_password;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Button register_login_btn;
        private Label label5;
        private TextBox register_nameSurname;
        private Label label1;
    }
}