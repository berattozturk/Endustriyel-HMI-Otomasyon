namespace proje.Forms
{
    partial class ToastForm
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
            toastBorder = new Panel();
            lbType = new Label();
            lbMessage = new Label();
            picIcon = new PictureBox();
            toastTimer = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.FromArgb(57, 155, 53);
            toastBorder.Dock = DockStyle.Left;
            toastBorder.Location = new Point(0, 0);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(10, 59);
            toastBorder.TabIndex = 0;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbType.Location = new Point(71, 9);
            lbType.Name = "lbType";
            lbType.Size = new Size(52, 23);
            lbType.TabIndex = 1;
            lbType.Text = "BİLGİ";
            // 
            // lbMessage
            // 
            lbMessage.AutoSize = true;
            lbMessage.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbMessage.Location = new Point(71, 29);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(176, 23);
            lbMessage.TabIndex = 2;
            lbMessage.Text = "Kayıt İşlemi Başarılı !";
            // 
            // picIcon
            // 
            picIcon.Image = Properties.Resources.Checkmark;
            picIcon.Location = new Point(21, 9);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(30, 35);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 3;
            picIcon.TabStop = false;
            // 
            // toastTimer
            // 
            toastTimer.Enabled = true;
            toastTimer.Interval = 10;
            toastTimer.Tick += toastTimer_Tick;
            // 
            // toastHide
            // 
            toastHide.Interval = 25;
            toastHide.Tick += toastHide_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(picIcon);
            Controls.Add(lbMessage);
            Controls.Add(lbType);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toastBorder;
        private Label lbType;
        private Label lbMessage;
        private PictureBox picIcon;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
      
    }
}