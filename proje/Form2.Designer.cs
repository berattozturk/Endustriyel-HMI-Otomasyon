namespace proje
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menubutton = new PictureBox();
            panel2 = new Panel();
            buttonSonAtamalar = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            amblem = new PictureBox();
            lblTitle = new Label();
            sidebartimer = new System.Windows.Forms.Timer(components);
            panelContainer = new Panel();
            panel9 = new Panel();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amblem).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(41, 41, 41);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(3, 48);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.MaximumSize = new Size(192, 1125);
            sidebar.MinimumSize = new Size(59, 1125);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(192, 1125);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 52, 52);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubutton);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menü";
            label1.Click += label1_Click;
            // 
            // menubutton
            // 
            menubutton.Cursor = Cursors.Hand;
            menubutton.Image = Properties.Resources.Menu;
            menubutton.Location = new Point(8, 14);
            menubutton.Margin = new Padding(3, 2, 3, 2);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(44, 35);
            menubutton.TabIndex = 0;
            menubutton.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonSonAtamalar);
            panel2.Location = new Point(3, 74);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 48);
            panel2.TabIndex = 1;
            // 
            // buttonSonAtamalar
            // 
            buttonSonAtamalar.FlatAppearance.BorderSize = 0;
            buttonSonAtamalar.FlatStyle = FlatStyle.Flat;
            buttonSonAtamalar.ForeColor = Color.White;
            buttonSonAtamalar.Image = (Image)resources.GetObject("buttonSonAtamalar.Image");
            buttonSonAtamalar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSonAtamalar.Location = new Point(-23, -8);
            buttonSonAtamalar.Margin = new Padding(3, 2, 3, 2);
            buttonSonAtamalar.Name = "buttonSonAtamalar";
            buttonSonAtamalar.Padding = new Padding(22, 0, 0, 0);
            buttonSonAtamalar.Size = new Size(235, 62);
            buttonSonAtamalar.TabIndex = 2;
            buttonSonAtamalar.Text = "               Son Atamalar";
            buttonSonAtamalar.TextAlign = ContentAlignment.MiddleLeft;
            buttonSonAtamalar.UseVisualStyleBackColor = true;
            buttonSonAtamalar.Click += buttonSonAtamalar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 126);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(192, 48);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-23, -8);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(22, 0, 0, 0);
            button2.Size = new Size(235, 62);
            button2.TabIndex = 2;
            button2.Text = "               Nöbet Giriş";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 178);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 48);
            panel4.TabIndex = 3;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-23, -8);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(22, 0, 0, 0);
            button3.Size = new Size(235, 62);
            button3.TabIndex = 2;
            button3.Text = "               Nöbet Sorgulama";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 230);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(192, 48);
            panel5.TabIndex = 4;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-23, -8);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(22, 0, 0, 0);
            button4.Size = new Size(235, 62);
            button4.TabIndex = 2;
            button4.Text = "               Şifre Güncelleme ";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 282);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(192, 48);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-23, -8);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(22, 0, 0, 0);
            button5.Size = new Size(235, 62);
            button5.TabIndex = 2;
            button5.Text = "               Yasal Uyarı";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 334);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(192, 48);
            panel7.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(41, 41, 41);
            panel8.Controls.Add(amblem);
            panel8.Controls.Add(lblTitle);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(195, 48);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(1480, 68);
            panel8.TabIndex = 1;
            // 
            // amblem
            // 
            amblem.Anchor = AnchorStyles.None;
            amblem.Image = Properties.Resources.ikonb;
            amblem.Location = new Point(697, 0);
            amblem.Margin = new Padding(3, 2, 3, 2);
            amblem.Name = "amblem";
            amblem.Size = new Size(85, 63);
            amblem.SizeMode = PictureBoxSizeMode.Zoom;
            amblem.TabIndex = 1;
            amblem.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Swis721 Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(614, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "OAAS";
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(195, 116);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1480, 642);
            panelContainer.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(41, 41, 41);
            panel9.Location = new Point(-1, 48);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(9, 1125);
            panel9.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 760);
            Controls.Add(panel9);
            Controls.Add(panelContainer);
            Controls.Add(panel8);
            Controls.Add(sidebar);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1678, 760);
            Name = "Form2";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amblem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button buttonSonAtamalar;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private PictureBox menubutton;
        private Label label1;
        private Panel panel8;
        private Label lblTitle;
        private PictureBox amblem;
        public System.Windows.Forms.Timer sidebartimer;
        private Panel panelContainer;
        private Panel panel9;
    }
}