namespace proje
{
    partial class istatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(istatistik));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel4 = new Panel();
            textBox6 = new TextBox();
            button6 = new Button();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            colSiparis = new DataGridViewTextBoxColumn();
            colTarih = new DataGridViewTextBoxColumn();
            colMalzeme = new DataGridViewTextBoxColumn();
            colUretim = new DataGridViewTextBoxColumn();
            colAgirlik = new DataGridViewTextBoxColumn();
            colDurum = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            dtpEnd = new DateTimePicker();
            label8 = new Label();
            dtpStart = new DateTimePicker();
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            lblActualRecipeInUse = new Label();
            label4 = new Label();
            cmbSelectRecipe = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(12, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(1167, 24);
            panel4.TabIndex = 82;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.DarkGray;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox6.Location = new Point(0, -2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1163, 18);
            textBox6.TabIndex = 0;
            textBox6.Text = "178 DM 171.2 Pigment press 1 commands not inserted!";
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1240, 7);
            button6.Name = "button6";
            button6.Size = new Size(124, 52);
            button6.TabIndex = 81;
            button6.Text = "ALARMS \r\nRESET/ACK";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1185, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 80;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox6);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 17);
            panel3.TabIndex = 79;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(203, 234, 228);
            panel1.Controls.Add(chart1);
            panel1.Location = new Point(17, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 459);
            panel1.TabIndex = 83;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chartArea2.BackColor = Color.White;
            chartArea2.BorderColor = Color.Gray;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            chart1.Dock = DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            series2.BorderColor = Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Color = Color.CadetBlue;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(692, 459);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSiparis, colTarih, colMalzeme, colUretim, colAgirlik, colDurum });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.WhiteSmoke;
            dataGridView1.Location = new Point(793, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 372);
            dataGridView1.TabIndex = 84;
            // 
            // colSiparis
            // 
            colSiparis.HeaderText = "Order ID";
            colSiparis.Name = "colSiparis";
            colSiparis.ReadOnly = true;
            // 
            // colTarih
            // 
            colTarih.HeaderText = "Date";
            colTarih.Name = "colTarih";
            colTarih.ReadOnly = true;
            // 
            // colMalzeme
            // 
            colMalzeme.HeaderText = "Material";
            colMalzeme.Name = "colMalzeme";
            colMalzeme.ReadOnly = true;
            // 
            // colUretim
            // 
            colUretim.HeaderText = "Total Production (cc)";
            colUretim.Name = "colUretim";
            colUretim.ReadOnly = true;
            // 
            // colAgirlik
            // 
            colAgirlik.HeaderText = "Total Weight (kg)";
            colAgirlik.Name = "colAgirlik";
            colAgirlik.ReadOnly = true;
            // 
            // colDurum
            // 
            colDurum.HeaderText = "Status";
            colDurum.Name = "colDurum";
            colDurum.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(203, 234, 228);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dtpEnd);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(dtpStart);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblActualRecipeInUse);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(cmbSelectRecipe);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(804, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 203);
            panel5.TabIndex = 86;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(138, 159);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(110, 23);
            dtpEnd.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(87, 121);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 9;
            label8.Text = "Date range";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(18, 159);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(110, 23);
            dtpStart.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Location = new Point(165, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Facade 310 ml Ral 7022 29/11/2022";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(292, 150);
            button1.Name = "button1";
            button1.Size = new Size(90, 44);
            button1.TabIndex = 6;
            button1.Text = "SHOW DATA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(159, 79);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(149, 81);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 4;
            // 
            // lblActualRecipeInUse
            // 
            lblActualRecipeInUse.AutoSize = true;
            lblActualRecipeInUse.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblActualRecipeInUse.Location = new Point(7, 77);
            lblActualRecipeInUse.Name = "lblActualRecipeInUse";
            lblActualRecipeInUse.Size = new Size(146, 20);
            lblActualRecipeInUse.TabIndex = 3;
            lblActualRecipeInUse.Text = "Actual recipe in use:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(136, 13);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 2;
            label4.Text = "FILTER OPTIONS";
            // 
            // cmbSelectRecipe
            // 
            cmbSelectRecipe.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbSelectRecipe.FormattingEnabled = true;
            cmbSelectRecipe.Location = new Point(110, 41);
            cmbSelectRecipe.Name = "cmbSelectRecipe";
            cmbSelectRecipe.Size = new Size(237, 25);
            cmbSelectRecipe.TabIndex = 1;
            cmbSelectRecipe.Text = "Facade 310 ml Ral 7022 29/11/2022";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(7, 40);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Select Recipe:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(954, 303);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 86;
            label2.Text = "PRODUCTION LOG";
            // 
            // istatistik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(179, 178, 186);
            ClientSize = new Size(1376, 727);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(button6);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Name = "istatistik";
            Text = "istatistik";
            Load += istatistik_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private TextBox textBox6;
        private Button button6;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private DataGridViewTextBoxColumn colSiparis;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewTextBoxColumn colMalzeme;
        private DataGridViewTextBoxColumn colUretim;
        private DataGridViewTextBoxColumn colAgirlik;
        private DataGridViewTextBoxColumn colDurum;
        private Label label2;
        private ComboBox cmbSelectRecipe;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label lblActualRecipeInUse;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private DateTimePicker dtpEnd;
        private Label label8;
        private DateTimePicker dtpStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}