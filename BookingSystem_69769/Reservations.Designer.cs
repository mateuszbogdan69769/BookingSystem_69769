namespace BookingSystem_69769
{
    partial class Reservations
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
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            reservations_table = new DataGridView();
            panel3 = new Panel();
            reservations_timeto = new TextBox();
            reservations_timefrom = new TextBox();
            label8 = new Label();
            label5 = new Label();
            reservations_add_btn = new Button();
            reservations_date = new DateTimePicker();
            reservations_note = new RichTextBox();
            reservations_partysize = new TextBox();
            reservations_guest_surname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            reservations_guest_name = new TextBox();
            panel2 = new Panel();
            reservations_dateto_search = new DateTimePicker();
            reservations_datefrom_search = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            reservations_searchquery = new TextBox();
            label9 = new Label();
            date = new DataGridViewTextBoxColumn();
            startTime = new DataGridViewTextBoxColumn();
            endTime = new DataGridViewTextBoxColumn();
            guest = new DataGridViewTextBoxColumn();
            Partysize = new DataGridViewTextBoxColumn();
            note = new DataGridViewTextBoxColumn();
            reservations_deletecolumn = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservations_table).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 178);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Reservations";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(26, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 616);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(reservations_table);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 60);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1028, 294);
            panel4.TabIndex = 2;
            // 
            // reservations_table
            // 
            reservations_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservations_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservations_table.Columns.AddRange(new DataGridViewColumn[] { date, startTime, endTime, guest, Partysize, note, reservations_deletecolumn });
            reservations_table.Dock = DockStyle.Fill;
            reservations_table.Location = new Point(0, 0);
            reservations_table.Margin = new Padding(3, 2, 3, 2);
            reservations_table.Name = "reservations_table";
            reservations_table.ReadOnly = true;
            reservations_table.RowHeadersVisible = false;
            reservations_table.RowHeadersWidth = 51;
            reservations_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservations_table.Size = new Size(1028, 294);
            reservations_table.TabIndex = 0;
            reservations_table.CellContentClick += reservations_table_CellContentClick_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(reservations_timeto);
            panel3.Controls.Add(reservations_timefrom);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(reservations_add_btn);
            panel3.Controls.Add(reservations_date);
            panel3.Controls.Add(reservations_note);
            panel3.Controls.Add(reservations_partysize);
            panel3.Controls.Add(reservations_guest_surname);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(reservations_guest_name);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 354);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1028, 262);
            panel3.TabIndex = 1;
            // 
            // reservations_timeto
            // 
            reservations_timeto.Location = new Point(420, 44);
            reservations_timeto.Margin = new Padding(3, 2, 3, 2);
            reservations_timeto.Name = "reservations_timeto";
            reservations_timeto.Size = new Size(154, 23);
            reservations_timeto.TabIndex = 19;
            // 
            // reservations_timefrom
            // 
            reservations_timefrom.Location = new Point(241, 44);
            reservations_timefrom.Margin = new Padding(3, 2, 3, 2);
            reservations_timefrom.Name = "reservations_timefrom";
            reservations_timefrom.Size = new Size(154, 23);
            reservations_timefrom.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(420, 27);
            label8.Name = "label8";
            label8.Size = new Size(155, 15);
            label8.TabIndex = 17;
            label8.Text = "Koniec rezerwacji (HH:mm):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 27);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 16;
            label5.Text = "Start rezerwacji (HH:mm):";
            // 
            // reservations_add_btn
            // 
            reservations_add_btn.BackColor = Color.FromArgb(255, 102, 1);
            reservations_add_btn.FlatStyle = FlatStyle.Flat;
            reservations_add_btn.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            reservations_add_btn.ForeColor = Color.White;
            reservations_add_btn.Location = new Point(264, 232);
            reservations_add_btn.Margin = new Padding(3, 2, 3, 2);
            reservations_add_btn.Name = "reservations_add_btn";
            reservations_add_btn.Size = new Size(170, 30);
            reservations_add_btn.TabIndex = 15;
            reservations_add_btn.Text = "Dodaj rezerwacje";
            reservations_add_btn.UseVisualStyleBackColor = false;
            reservations_add_btn.Click += reservations_add_btn_Click;
            // 
            // reservations_date
            // 
            reservations_date.Location = new Point(0, 44);
            reservations_date.Margin = new Padding(3, 2, 3, 2);
            reservations_date.Name = "reservations_date";
            reservations_date.Size = new Size(217, 23);
            reservations_date.TabIndex = 13;
            // 
            // reservations_note
            // 
            reservations_note.Location = new Point(0, 170);
            reservations_note.Margin = new Padding(3, 2, 3, 2);
            reservations_note.Name = "reservations_note";
            reservations_note.Size = new Size(236, 92);
            reservations_note.TabIndex = 12;
            reservations_note.Text = "";
            // 
            // reservations_partysize
            // 
            reservations_partysize.Location = new Point(371, 103);
            reservations_partysize.Margin = new Padding(3, 2, 3, 2);
            reservations_partysize.Name = "reservations_partysize";
            reservations_partysize.Size = new Size(110, 23);
            reservations_partysize.TabIndex = 10;
            // 
            // reservations_guest_surname
            // 
            reservations_guest_surname.Location = new Point(183, 103);
            reservations_guest_surname.Margin = new Padding(3, 2, 3, 2);
            reservations_guest_surname.Name = "reservations_guest_surname";
            reservations_guest_surname.Size = new Size(150, 23);
            reservations_guest_surname.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 86);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 6;
            label7.Text = "Ilość osób:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 153);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 5;
            label6.Text = "Notatka:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 27);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Data rezerwacji:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 86);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Nazwisko gościa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 86);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Imię gościa:";
            // 
            // reservations_guest_name
            // 
            reservations_guest_name.Location = new Point(0, 103);
            reservations_guest_name.Margin = new Padding(3, 2, 3, 2);
            reservations_guest_name.Name = "reservations_guest_name";
            reservations_guest_name.Size = new Size(150, 23);
            reservations_guest_name.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(reservations_dateto_search);
            panel2.Controls.Add(reservations_datefrom_search);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(reservations_searchquery);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 60);
            panel2.TabIndex = 0;
            // 
            // reservations_dateto_search
            // 
            reservations_dateto_search.Location = new Point(494, 17);
            reservations_dateto_search.Margin = new Padding(3, 2, 3, 2);
            reservations_dateto_search.Name = "reservations_dateto_search";
            reservations_dateto_search.Size = new Size(219, 23);
            reservations_dateto_search.TabIndex = 5;
            reservations_dateto_search.ValueChanged += reservations_dateto_search_ValueChanged;
            // 
            // reservations_datefrom_search
            // 
            reservations_datefrom_search.Location = new Point(241, 17);
            reservations_datefrom_search.Margin = new Padding(3, 2, 3, 2);
            reservations_datefrom_search.Name = "reservations_datefrom_search";
            reservations_datefrom_search.Size = new Size(200, 23);
            reservations_datefrom_search.TabIndex = 4;
            reservations_datefrom_search.ValueChanged += reservations_datefrom_search_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(494, 0);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 3;
            label11.Text = "Date do:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 0);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 2;
            label10.Text = "Data od:";
            // 
            // reservations_searchquery
            // 
            reservations_searchquery.Location = new Point(0, 17);
            reservations_searchquery.Margin = new Padding(3, 2, 3, 2);
            reservations_searchquery.Name = "reservations_searchquery";
            reservations_searchquery.Size = new Size(200, 23);
            reservations_searchquery.TabIndex = 1;
            reservations_searchquery.TextChanged += reservations_searchquery_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 0;
            label9.Text = "Wyszukaj:";
            // 
            // date
            // 
            date.DataPropertyName = "StartDate";
            date.HeaderText = "Data rezerwacji";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // startTime
            // 
            startTime.DataPropertyName = "StartDate";
            startTime.HeaderText = "Start";
            startTime.MinimumWidth = 6;
            startTime.Name = "startTime";
            startTime.ReadOnly = true;
            // 
            // endTime
            // 
            endTime.DataPropertyName = "EndDate";
            endTime.HeaderText = "Koniec";
            endTime.MinimumWidth = 6;
            endTime.Name = "endTime";
            endTime.ReadOnly = true;
            // 
            // guest
            // 
            guest.DataPropertyName = "Guest";
            guest.HeaderText = "Gość";
            guest.MinimumWidth = 6;
            guest.Name = "guest";
            guest.ReadOnly = true;
            // 
            // Partysize
            // 
            Partysize.DataPropertyName = "PartySize";
            Partysize.HeaderText = "Ilość osób";
            Partysize.MinimumWidth = 6;
            Partysize.Name = "Partysize";
            Partysize.ReadOnly = true;
            // 
            // note
            // 
            note.DataPropertyName = "Note";
            note.HeaderText = "Notatka";
            note.MinimumWidth = 6;
            note.Name = "note";
            note.ReadOnly = true;
            // 
            // reservations_deletecolumn
            // 
            reservations_deletecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            reservations_deletecolumn.HeaderText = "";
            reservations_deletecolumn.Name = "reservations_deletecolumn";
            reservations_deletecolumn.ReadOnly = true;
            reservations_deletecolumn.Text = "Usuń";
            reservations_deletecolumn.UseColumnTextForButtonValue = true;
            reservations_deletecolumn.Width = 60;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reservations";
            Padding = new Padding(26, 22, 26, 22);
            Size = new Size(1080, 660);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservations_table).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private TextBox textBox2;
        private TextBox reservations_partysize;
        private TextBox textBox3;
        private TextBox reservations_guest_surname;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox reservations_guest_name;
        private RichTextBox reservations_note;
        private DateTimePicker reservations_date;
        private Button reservations_add_btn;
        private TextBox reservations_timeto;
        private TextBox reservations_timefrom;
        private Label label8;
        private Label label5;
        private DateTimePicker reservations_dateto_search;
        private DateTimePicker reservations_datefrom_search;
        private Label label11;
        private Label label10;
        private TextBox reservations_searchquery;
        private Label label9;
        private DataGridView reservations_table;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn startTime;
        private DataGridViewTextBoxColumn endTime;
        private DataGridViewTextBoxColumn guest;
        private DataGridViewTextBoxColumn Partysize;
        private DataGridViewTextBoxColumn note;
        private DataGridViewButtonColumn reservations_deletecolumn;
    }
}
