namespace BookingSystem_69769
{
    partial class Guests
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            guests_table = new DataGridView();
            panel3 = new Panel();
            guest_searchfield = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            guests_add_btn = new Button();
            guests_surname = new TextBox();
            guests_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guests_table_name = new DataGridViewTextBoxColumn();
            guests_table_surname = new DataGridViewTextBoxColumn();
            bookingsCount = new DataGridViewTextBoxColumn();
            guest_deletecolumn = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guests_table).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(18, 15);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 630);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(guests_table);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(1044, 496);
            panel4.TabIndex = 2;
            // 
            // guests_table
            // 
            guests_table.AllowUserToAddRows = false;
            guests_table.AllowUserToDeleteRows = false;
            guests_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guests_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guests_table.Columns.AddRange(new DataGridViewColumn[] { guests_table_name, guests_table_surname, bookingsCount, guest_deletecolumn });
            guests_table.Dock = DockStyle.Fill;
            guests_table.Location = new Point(0, 0);
            guests_table.Margin = new Padding(3, 2, 3, 2);
            guests_table.Name = "guests_table";
            guests_table.ReadOnly = true;
            guests_table.RowHeadersVisible = false;
            guests_table.RowHeadersWidth = 51;
            guests_table.Size = new Size(1044, 496);
            guests_table.TabIndex = 0;
            guests_table.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(guest_searchfield);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1044, 60);
            panel3.TabIndex = 1;
            // 
            // guest_searchfield
            // 
            guest_searchfield.Location = new Point(0, 18);
            guest_searchfield.Name = "guest_searchfield";
            guest_searchfield.Size = new Size(200, 23);
            guest_searchfield.TabIndex = 1;
            guest_searchfield.TextChanged += guest_searchfield_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Wyszukaj:";
            // 
            // panel2
            // 
            panel2.Controls.Add(guests_add_btn);
            panel2.Controls.Add(guests_surname);
            panel2.Controls.Add(guests_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 556);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 74);
            panel2.TabIndex = 0;
            // 
            // guests_add_btn
            // 
            guests_add_btn.BackColor = Color.FromArgb(255, 102, 1);
            guests_add_btn.FlatStyle = FlatStyle.Flat;
            guests_add_btn.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            guests_add_btn.ForeColor = Color.White;
            guests_add_btn.Location = new Point(280, 27);
            guests_add_btn.Margin = new Padding(3, 2, 3, 2);
            guests_add_btn.Name = "guests_add_btn";
            guests_add_btn.Size = new Size(90, 30);
            guests_add_btn.TabIndex = 4;
            guests_add_btn.Text = "Dodaj";
            guests_add_btn.UseVisualStyleBackColor = false;
            guests_add_btn.Click += guests_add_btn_Click;
            // 
            // guests_surname
            // 
            guests_surname.Location = new Point(140, 32);
            guests_surname.Margin = new Padding(3, 2, 3, 2);
            guests_surname.Name = "guests_surname";
            guests_surname.Size = new Size(110, 23);
            guests_surname.TabIndex = 3;
            // 
            // guests_name
            // 
            guests_name.Location = new Point(1, 32);
            guests_name.Margin = new Padding(3, 2, 3, 2);
            guests_name.Name = "guests_name";
            guests_name.Size = new Size(110, 23);
            guests_name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 14);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 14);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // guests_table_name
            // 
            guests_table_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guests_table_name.DataPropertyName = "Name";
            guests_table_name.FillWeight = 78.25075F;
            guests_table_name.HeaderText = "Imię";
            guests_table_name.MinimumWidth = 6;
            guests_table_name.Name = "guests_table_name";
            guests_table_name.ReadOnly = true;
            // 
            // guests_table_surname
            // 
            guests_table_surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            guests_table_surname.DataPropertyName = "Surname";
            guests_table_surname.FillWeight = 78.25075F;
            guests_table_surname.HeaderText = "Nazwisko";
            guests_table_surname.MinimumWidth = 6;
            guests_table_surname.Name = "guests_table_surname";
            guests_table_surname.ReadOnly = true;
            // 
            // bookingsCount
            // 
            bookingsCount.DataPropertyName = "Bookings";
            bookingsCount.FillWeight = 78.25075F;
            bookingsCount.HeaderText = "Ilość rezerwacji";
            bookingsCount.MinimumWidth = 6;
            bookingsCount.Name = "bookingsCount";
            bookingsCount.ReadOnly = true;
            // 
            // guest_deletecolumn
            // 
            guest_deletecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            guest_deletecolumn.FillWeight = 102.8112F;
            guest_deletecolumn.HeaderText = "";
            guest_deletecolumn.Name = "guest_deletecolumn";
            guest_deletecolumn.ReadOnly = true;
            guest_deletecolumn.Text = "Usuń";
            guest_deletecolumn.UseColumnTextForButtonValue = true;
            guest_deletecolumn.Width = 60;
            // 
            // Guests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Guests";
            Padding = new Padding(18, 15, 18, 15);
            Size = new Size(1080, 660);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guests_table).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button guests_add_btn;
        private TextBox guests_surname;
        private TextBox guests_name;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private DataGridView guests_table;
        private Panel panel3;
        private TextBox guest_searchfield;
        private Label label3;
        private DataGridViewTextBoxColumn guests_table_name;
        private DataGridViewTextBoxColumn guests_table_surname;
        private DataGridViewTextBoxColumn bookingsCount;
        private DataGridViewButtonColumn guest_deletecolumn;
    }
}
