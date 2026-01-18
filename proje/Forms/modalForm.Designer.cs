namespace proje.Forms
{
    partial class modalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modalForm));
            modalEffect_Timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            txtD3_SetCC = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label21 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label33 = new Label();
            textBox13 = new TextBox();
            label32 = new Label();
            textBox12 = new TextBox();
            label31 = new Label();
            label30 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            label29 = new Label();
            textBox9 = new TextBox();
            label28 = new Label();
            textBox8 = new TextBox();
            label27 = new Label();
            textBox7 = new TextBox();
            label26 = new Label();
            textBox6 = new TextBox();
            label25 = new Label();
            textBox5 = new TextBox();
            label24 = new Label();
            textBox4 = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label34 = new Label();
            textBox14 = new TextBox();
            label35 = new Label();
            button2 = new Button();
            label36 = new Label();
            textBox15 = new TextBox();
            label37 = new Label();
            textBox16 = new TextBox();
            label38 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Enabled = true;
            modalEffect_Timer.Interval = 1;
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(86, 81);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 1;
            label1.Text = "Actual total flow:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 236);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "DOSER 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(173, 375);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "FLOW-METER\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(271, 143);
            label4.Name = "label4";
            label4.Size = new Size(222, 20);
            label4.TabIndex = 4;
            label4.Text = "Flow between last two dosages:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(271, 212);
            label5.Name = "label5";
            label5.Size = new Size(202, 20);
            label5.TabIndex = 5;
            label5.Text = "Theoretical last dosage flow:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(271, 178);
            label6.Name = "label6";
            label6.Size = new Size(175, 20);
            label6.TabIndex = 6;
            label6.Text = "Flow during last dosage:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(209, 230, 209);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(295, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 100);
            panel1.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(285, 57);
            label11.Name = "label11";
            label11.Size = new Size(23, 19);
            label11.TabIndex = 12;
            label11.Text = "cc";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(236, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 27);
            textBox3.TabIndex = 11;
            textBox3.Text = "0.2";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(216, 11);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 10;
            button1.Text = "OFF";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(19, 58);
            label8.Name = "label8";
            label8.Size = new Size(192, 17);
            label8.TabIndex = 9;
            label8.Text = "Dosage flow control tolarance:\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(19, 21);
            label7.Name = "label7";
            label7.Size = new Size(176, 17);
            label7.TabIndex = 8;
            label7.Text = "Dosage flow control enable:";
            // 
            // txtD3_SetCC
            // 
            txtD3_SetCC.BackColor = Color.FromArgb(213, 208, 232);
            txtD3_SetCC.BorderStyle = BorderStyle.None;
            txtD3_SetCC.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtD3_SetCC.ForeColor = Color.FromArgb(10, 113, 215);
            txtD3_SetCC.Location = new Point(500, 143);
            txtD3_SetCC.Name = "txtD3_SetCC";
            txtD3_SetCC.Size = new Size(68, 24);
            txtD3_SetCC.TabIndex = 45;
            txtD3_SetCC.Text = "2.97";
            txtD3_SetCC.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(213, 208, 232);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.FromArgb(10, 113, 215);
            textBox1.Location = new Point(500, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 24);
            textBox1.TabIndex = 46;
            textBox1.Text = "2.97";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(213, 208, 232);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.ForeColor = Color.FromArgb(10, 113, 215);
            textBox2.Location = new Point(500, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 24);
            textBox2.TabIndex = 47;
            textBox2.Text = "2.90";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(574, 208);
            label21.Name = "label21";
            label21.Size = new Size(30, 25);
            label21.TabIndex = 63;
            label21.Text = "cc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(574, 175);
            label9.Name = "label9";
            label9.Size = new Size(30, 25);
            label9.TabIndex = 64;
            label9.Text = "cc";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(574, 143);
            label10.Name = "label10";
            label10.Size = new Size(30, 25);
            label10.TabIndex = 65;
            label10.Text = "cc";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(138, 208, 244);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label33);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(label32);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label31);
            panel2.Controls.Add(label30);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label29);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label26);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(621, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 423);
            panel2.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(49, 23);
            label12.Name = "label12";
            label12.Size = new Size(169, 21);
            label12.TabIndex = 30;
            label12.Text = "LAST DOSAGES FLOW";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label33.ForeColor = Color.Black;
            label33.Location = new Point(222, 372);
            label33.Name = "label33";
            label33.Size = new Size(23, 19);
            label33.TabIndex = 29;
            label33.Text = "cc";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(138, 208, 244);
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox13.Location = new Point(172, 370);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(46, 24);
            textBox13.TabIndex = 28;
            textBox13.Text = "2.94";
            textBox13.TextAlign = HorizontalAlignment.Right;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(222, 304);
            label32.Name = "label32";
            label32.Size = new Size(23, 19);
            label32.TabIndex = 27;
            label32.Text = "cc";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(138, 208, 244);
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox12.Location = new Point(172, 302);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(46, 24);
            textBox12.TabIndex = 26;
            textBox12.Text = "2.94";
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(222, 270);
            label31.Name = "label31";
            label31.Size = new Size(23, 19);
            label31.TabIndex = 25;
            label31.Text = "cc";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(223, 338);
            label30.Name = "label30";
            label30.Size = new Size(23, 19);
            label30.TabIndex = 25;
            label30.Text = "cc";
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(138, 208, 244);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox11.Location = new Point(172, 268);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(46, 24);
            textBox11.TabIndex = 24;
            textBox11.Text = "2.94";
            textBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(138, 208, 244);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox10.Location = new Point(172, 336);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(46, 24);
            textBox10.TabIndex = 24;
            textBox10.Text = "2.94";
            textBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(222, 236);
            label29.Name = "label29";
            label29.Size = new Size(23, 19);
            label29.TabIndex = 23;
            label29.Text = "cc";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(138, 208, 244);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox9.Location = new Point(172, 234);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(46, 24);
            textBox9.TabIndex = 22;
            textBox9.Text = "2.94";
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label28.ForeColor = Color.Black;
            label28.Location = new Point(222, 202);
            label28.Name = "label28";
            label28.Size = new Size(23, 19);
            label28.TabIndex = 21;
            label28.Text = "cc";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(138, 208, 244);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox8.Location = new Point(172, 200);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(46, 24);
            textBox8.TabIndex = 20;
            textBox8.Text = "2.94";
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(222, 168);
            label27.Name = "label27";
            label27.Size = new Size(23, 19);
            label27.TabIndex = 19;
            label27.Text = "cc";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(138, 208, 244);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox7.Location = new Point(172, 166);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(46, 24);
            textBox7.TabIndex = 18;
            textBox7.Text = "2.94";
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(222, 134);
            label26.Name = "label26";
            label26.Size = new Size(23, 19);
            label26.TabIndex = 17;
            label26.Text = "cc";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(138, 208, 244);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox6.Location = new Point(172, 132);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(46, 24);
            textBox6.TabIndex = 16;
            textBox6.Text = "2.94";
            textBox6.TextAlign = HorizontalAlignment.Right;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(222, 100);
            label25.Name = "label25";
            label25.Size = new Size(23, 19);
            label25.TabIndex = 15;
            label25.Text = "cc";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(138, 208, 244);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox5.Location = new Point(172, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(46, 24);
            textBox5.TabIndex = 14;
            textBox5.Text = "2.94";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(222, 66);
            label24.Name = "label24";
            label24.Size = new Size(23, 19);
            label24.TabIndex = 13;
            label24.Text = "cc";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(138, 208, 244);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox4.Location = new Point(172, 64);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(46, 24);
            textBox4.TabIndex = 12;
            textBox4.Text = "2.94";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(21, 373);
            label23.Name = "label23";
            label23.Size = new Size(83, 19);
            label23.TabIndex = 8;
            label23.Text = "Control -9:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(21, 339);
            label22.Name = "label22";
            label22.Size = new Size(83, 19);
            label22.TabIndex = 7;
            label22.Text = "Control -8:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(21, 305);
            label20.Name = "label20";
            label20.Size = new Size(83, 19);
            label20.TabIndex = 6;
            label20.Text = "Control -7:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(21, 237);
            label19.Name = "label19";
            label19.Size = new Size(83, 19);
            label19.TabIndex = 5;
            label19.Text = "Control -5:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(21, 271);
            label18.Name = "label18";
            label18.Size = new Size(83, 19);
            label18.TabIndex = 5;
            label18.Text = "Control -6:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(21, 203);
            label17.Name = "label17";
            label17.Size = new Size(83, 19);
            label17.TabIndex = 4;
            label17.Text = "Control -4:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(21, 135);
            label16.Name = "label16";
            label16.Size = new Size(83, 19);
            label16.TabIndex = 3;
            label16.Text = "Control -2:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(21, 169);
            label15.Name = "label15";
            label15.Size = new Size(83, 19);
            label15.TabIndex = 3;
            label15.Text = "Control -3:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(21, 101);
            label14.Name = "label14";
            label14.Size = new Size(83, 19);
            label14.TabIndex = 2;
            label14.Text = "Control -1:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Swis721 BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(21, 67);
            label13.Name = "label13";
            label13.Size = new Size(103, 19);
            label13.TabIndex = 1;
            label13.Text = "Last dosage:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.FlatStyle = FlatStyle.Popup;
            label34.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(289, 12);
            label34.Name = "label34";
            label34.Size = new Size(279, 20);
            label34.TabIndex = 67;
            label34.Text = "DOSER 2 OUTLET FLOW CONTROL";
            // 
            // textBox14
            // 
            textBox14.BackColor = Color.FromArgb(213, 208, 232);
            textBox14.BorderStyle = BorderStyle.None;
            textBox14.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox14.ForeColor = Color.FromArgb(10, 113, 215);
            textBox14.Location = new Point(271, 81);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(68, 24);
            textBox14.TabIndex = 68;
            textBox14.Text = "629.43";
            textBox14.TextAlign = HorizontalAlignment.Right;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(342, 80);
            label35.Name = "label35";
            label35.Size = new Size(30, 25);
            label35.TabIndex = 69;
            label35.Text = "cc";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(213, 208, 232);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(408, 74);
            button2.Name = "button2";
            button2.Size = new Size(98, 41);
            button2.TabIndex = 70;
            button2.Text = "RESET \r\nCOUNT";
            button2.UseVisualStyleBackColor = false;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(315, 249);
            label36.Name = "label36";
            label36.Size = new Size(137, 20);
            label36.TabIndex = 71;
            label36.Text = "Compression ratio:";
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.FromArgb(213, 208, 232);
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox15.ForeColor = Color.FromArgb(10, 113, 215);
            textBox15.Location = new Point(499, 245);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(68, 24);
            textBox15.TabIndex = 72;
            textBox15.Text = "1.1493";
            textBox15.TextAlign = HorizontalAlignment.Right;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10F);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(134, 406);
            label37.Name = "label37";
            label37.Size = new Size(273, 38);
            label37.TabIndex = 73;
            label37.Text = "Tolerance for leaks control\r\n(continuos flow control when no extrusion):";
            // 
            // textBox16
            // 
            textBox16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox16.Location = new Point(413, 424);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(46, 27);
            textBox16.TabIndex = 74;
            textBox16.Text = "5.0";
            textBox16.TextAlign = HorizontalAlignment.Right;
            textBox16.TextChanged += textBox16_TextChanged;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label38.ForeColor = Color.Black;
            label38.Location = new Point(460, 429);
            label38.Name = "label38";
            label38.Size = new Size(23, 19);
            label38.TabIndex = 75;
            label38.Text = "cc";
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 208, 232);
            ClientSize = new Size(889, 460);
            Controls.Add(label38);
            Controls.Add(textBox16);
            Controls.Add(label37);
            Controls.Add(textBox15);
            Controls.Add(label36);
            Controls.Add(button2);
            Controls.Add(label35);
            Controls.Add(textBox14);
            Controls.Add(label34);
            Controls.Add(panel2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label21);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtD3_SetCC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "modalForm";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalForm";
            Load += modalForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer modalEffect_Timer;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private TextBox txtD3_SetCC;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label21;
        private TextBox textBox3;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel2;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label33;
        private TextBox textBox13;
        private Label label32;
        private TextBox textBox12;
        private Label label31;
        private Label label30;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label29;
        private TextBox textBox9;
        private Label label28;
        private TextBox textBox8;
        private Label label27;
        private TextBox textBox7;
        private Label label26;
        private TextBox textBox6;
        private Label label25;
        private TextBox textBox5;
        private Label label24;
        private TextBox textBox4;
        private Label label23;
        private Label label22;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label12;
        private Label label34;
        private TextBox textBox14;
        private Label label35;
        private Button button2;
        private Label label36;
        private TextBox textBox15;
        private Label label37;
        private TextBox textBox16;
        private Label label38;
    }
}