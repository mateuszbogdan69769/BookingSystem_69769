namespace BookingSystem_69769;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        label7 = new Label();
        label6 = new Label();
        login_register_btn = new Button();
        label5 = new Label();
        exit = new Label();
        label2 = new Label();
        label3 = new Label();
        login_password = new TextBox();
        label4 = new Label();
        login_btn = new Button();
        login_showPassword = new CheckBox();
        login_username = new TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(255, 102, 1);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(login_register_btn);
        panel1.Controls.Add(label5);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(250, 420);
        panel1.TabIndex = 0;
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
        // login_register_btn
        // 
        login_register_btn.BackColor = Color.FromArgb(229, 92, 1);
        login_register_btn.Cursor = Cursors.Hand;
        login_register_btn.FlatAppearance.BorderColor = Color.White;
        login_register_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
        login_register_btn.FlatStyle = FlatStyle.Flat;
        login_register_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        login_register_btn.ForeColor = Color.White;
        login_register_btn.Location = new Point(20, 370);
        login_register_btn.Name = "login_register_btn";
        login_register_btn.Size = new Size(210, 30);
        login_register_btn.TabIndex = 11;
        login_register_btn.Text = "Zarejestruj się";
        login_register_btn.UseVisualStyleBackColor = false;
        login_register_btn.Click += login_register_btn_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        label5.ForeColor = Color.White;
        label5.Location = new Point(64, 346);
        label5.Name = "label5";
        label5.Size = new Size(124, 18);
        label5.TabIndex = 11;
        label5.Text = "Nie masz konta?";
        // 
        // exit
        // 
        exit.AutoSize = true;
        exit.Cursor = Cursors.Hand;
        exit.Dock = DockStyle.Right;
        exit.Location = new Point(536, 0);
        exit.Name = "exit";
        exit.Size = new Size(14, 15);
        exit.TabIndex = 1;
        exit.Text = "X";
        exit.Click += exit_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
        label2.Location = new Point(270, 50);
        label2.Name = "label2";
        label2.Size = new Size(110, 22);
        label2.TabIndex = 2;
        label2.Text = "Zaloguj się";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        label3.Location = new Point(270, 128);
        label3.Name = "label3";
        label3.Size = new Size(146, 18);
        label3.TabIndex = 5;
        label3.Text = "Nazwa użytkownika:";
        // 
        // login_password
        // 
        login_password.BorderStyle = BorderStyle.FixedSingle;
        login_password.Cursor = Cursors.Hand;
        login_password.Font = new Font("Arial", 12F);
        login_password.Location = new Point(270, 212);
        login_password.Multiline = true;
        login_password.Name = "login_password";
        login_password.PasswordChar = '*';
        login_password.Size = new Size(260, 30);
        login_password.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
        label4.Location = new Point(270, 191);
        label4.Name = "label4";
        label4.Size = new Size(52, 18);
        label4.TabIndex = 7;
        label4.Text = "Hasło:";
        // 
        // login_btn
        // 
        login_btn.BackColor = Color.FromArgb(255, 102, 1);
        login_btn.Cursor = Cursors.Hand;
        login_btn.FlatAppearance.BorderColor = Color.White;
        login_btn.FlatAppearance.BorderSize = 0;
        login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
        login_btn.FlatStyle = FlatStyle.Flat;
        login_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
        login_btn.ForeColor = Color.White;
        login_btn.Location = new Point(340, 320);
        login_btn.Name = "login_btn";
        login_btn.Size = new Size(120, 30);
        login_btn.TabIndex = 3;
        login_btn.Text = "Zaloguj się";
        login_btn.UseVisualStyleBackColor = false;
        login_btn.Click += login_btn_Click;
        // 
        // login_showPassword
        // 
        login_showPassword.AutoSize = true;
        login_showPassword.Cursor = Cursors.Hand;
        login_showPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
        login_showPassword.Location = new Point(432, 248);
        login_showPassword.Name = "login_showPassword";
        login_showPassword.Size = new Size(98, 20);
        login_showPassword.TabIndex = 10;
        login_showPassword.Text = "Pokaż hasło";
        login_showPassword.UseVisualStyleBackColor = true;
        login_showPassword.CheckedChanged += login_showPassword_CheckedChanged;
        // 
        // login_username
        // 
        login_username.BorderStyle = BorderStyle.FixedSingle;
        login_username.Cursor = Cursors.Hand;
        login_username.Font = new Font("Arial", 12F);
        login_username.Location = new Point(270, 149);
        login_username.Multiline = true;
        login_username.Name = "login_username";
        login_username.Size = new Size(260, 30);
        login_username.TabIndex = 1;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(550, 420);
        Controls.Add(login_showPassword);
        Controls.Add(login_btn);
        Controls.Add(login_password);
        Controls.Add(label4);
        Controls.Add(login_username);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(exit);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label exit;
    private Label label2;
    private Label label3;
    private TextBox login_password;
    private Label label4;
    private Button login_btn;
    private CheckBox login_showPassword;
    private Label label6;
    private Button login_register_btn;
    private Label label5;
    private Label label7;
    private TextBox login_username;
}
