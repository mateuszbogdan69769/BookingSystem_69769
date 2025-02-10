namespace BookingSystem_69769
{
    partial class Dashboard
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
            dashboard_peoplestoday = new Label();
            label4 = new Label();
            dashboard_totalguests = new Label();
            dashboard_bookingstoday = new Label();
            dashboard_totalbookings = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dashboard_peoplestoday);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dashboard_totalguests);
            panel1.Controls.Add(dashboard_bookingstoday);
            panel1.Controls.Add(dashboard_totalbookings);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(31, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 608);
            panel1.TabIndex = 0;
            // 
            // dashboard_peoplestoday
            // 
            dashboard_peoplestoday.AutoSize = true;
            dashboard_peoplestoday.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            dashboard_peoplestoday.Location = new Point(296, 451);
            dashboard_peoplestoday.Name = "dashboard_peoplestoday";
            dashboard_peoplestoday.Size = new Size(92, 32);
            dashboard_peoplestoday.TabIndex = 7;
            dashboard_peoplestoday.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label4.Location = new Point(0, 451);
            label4.Name = "label4";
            label4.Size = new Size(254, 32);
            label4.TabIndex = 6;
            label4.Text = "Ilość osób dzisiaj:";
            // 
            // dashboard_totalguests
            // 
            dashboard_totalguests.AutoSize = true;
            dashboard_totalguests.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            dashboard_totalguests.Location = new Point(306, 151);
            dashboard_totalguests.Name = "dashboard_totalguests";
            dashboard_totalguests.Size = new Size(92, 32);
            dashboard_totalguests.TabIndex = 5;
            dashboard_totalguests.Text = "label4";
            // 
            // dashboard_bookingstoday
            // 
            dashboard_bookingstoday.AutoSize = true;
            dashboard_bookingstoday.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            dashboard_bookingstoday.Location = new Point(359, 308);
            dashboard_bookingstoday.Name = "dashboard_bookingstoday";
            dashboard_bookingstoday.Size = new Size(92, 32);
            dashboard_bookingstoday.TabIndex = 4;
            dashboard_bookingstoday.Text = "label4";
            // 
            // dashboard_totalbookings
            // 
            dashboard_totalbookings.AutoSize = true;
            dashboard_totalbookings.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            dashboard_totalbookings.Location = new Point(359, 0);
            dashboard_totalbookings.Name = "dashboard_totalbookings";
            dashboard_totalbookings.Size = new Size(92, 32);
            dashboard_totalbookings.TabIndex = 3;
            dashboard_totalbookings.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label3.Location = new Point(0, 308);
            label3.Name = "label3";
            label3.Size = new Size(321, 32);
            label3.TabIndex = 2;
            label3.Text = "Ilość rezerwacji dzisiaj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label2.Location = new Point(0, 151);
            label2.Name = "label2";
            label2.Size = new Size(282, 32);
            label2.TabIndex = 1;
            label2.Text = "Łączna liczba gości:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(343, 32);
            label1.TabIndex = 0;
            label1.Text = "Łączna liczba rezerwacji:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Padding = new Padding(31, 26, 31, 26);
            Size = new Size(1080, 660);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label dashboard_totalbookings;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label dashboard_peoplestoday;
        private Label label4;
        private Label dashboard_totalguests;
        private Label dashboard_bookingstoday;
    }
}
