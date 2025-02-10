namespace BookingSystem_69769
{
    partial class MainView
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
            logout_btn = new Button();
            guests_btn = new Button();
            reservations_btn = new Button();
            dashboard_btn = new Button();
            welcome_text = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 102, 1);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(20, 12);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "System rezerwacji";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(1273, 8);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 102, 1);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(guests_btn);
            panel2.Controls.Add(reservations_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(welcome_text);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 660);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.BorderColor = Color.White;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(20, 610);
            logout_btn.Margin = new Padding(3, 2, 3, 2);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(82, 30);
            logout_btn.TabIndex = 2;
            logout_btn.Text = "Wyloguj";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += button4_Click;
            // 
            // guests_btn
            // 
            guests_btn.BackColor = Color.Transparent;
            guests_btn.Cursor = Cursors.Hand;
            guests_btn.FlatAppearance.BorderColor = Color.White;
            guests_btn.FlatAppearance.BorderSize = 2;
            guests_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
            guests_btn.FlatStyle = FlatStyle.Flat;
            guests_btn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guests_btn.ForeColor = SystemColors.Window;
            guests_btn.Location = new Point(20, 343);
            guests_btn.Margin = new Padding(3, 2, 3, 2);
            guests_btn.Name = "guests_btn";
            guests_btn.Size = new Size(180, 30);
            guests_btn.TabIndex = 1;
            guests_btn.Text = "Goście";
            guests_btn.UseVisualStyleBackColor = false;
            guests_btn.Click += guests_btn_Click;
            // 
            // reservations_btn
            // 
            reservations_btn.BackColor = Color.Transparent;
            reservations_btn.Cursor = Cursors.Hand;
            reservations_btn.FlatAppearance.BorderColor = Color.White;
            reservations_btn.FlatAppearance.BorderSize = 2;
            reservations_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
            reservations_btn.FlatStyle = FlatStyle.Flat;
            reservations_btn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            reservations_btn.ForeColor = SystemColors.Window;
            reservations_btn.Location = new Point(20, 293);
            reservations_btn.Margin = new Padding(3, 2, 3, 2);
            reservations_btn.Name = "reservations_btn";
            reservations_btn.Size = new Size(180, 30);
            reservations_btn.TabIndex = 1;
            reservations_btn.Text = "Rezerwacje";
            reservations_btn.UseVisualStyleBackColor = false;
            reservations_btn.Click += reservations_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.Transparent;
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderColor = Color.White;
            dashboard_btn.FlatAppearance.BorderSize = 2;
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 92, 1);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dashboard_btn.ForeColor = SystemColors.Window;
            dashboard_btn.Location = new Point(20, 243);
            dashboard_btn.Margin = new Padding(3, 2, 3, 2);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(180, 30);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.Text = "Strona główna";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // welcome_text
            // 
            welcome_text.AutoSize = true;
            welcome_text.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            welcome_text.ForeColor = Color.White;
            welcome_text.Location = new Point(74, 99);
            welcome_text.Name = "welcome_text";
            welcome_text.Size = new Size(39, 20);
            welcome_text.TabIndex = 0;
            welcome_text.Text = "Witaj";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1080, 660);
            panel3.TabIndex = 2;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainView";
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
        private Label welcome_text;
        private Button dashboard_btn;
        private Button guests_btn;
        private Button reservations_btn;
        private Button logout_btn;
        private Dashboard dashboard_view;
        private Guests guests_view;
        private Reservations reservations_view;
        private Panel panel3;
    }
}