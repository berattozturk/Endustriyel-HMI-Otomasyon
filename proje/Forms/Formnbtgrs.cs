using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.Forms
{
    public partial class Formnbtgrs : Form
    {
        public Formnbtgrs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToastForm toast = new ToastForm();
            toast.Show();
            //panel14.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // 1. Panelin toplam alanını belirle
            Rectangle disAlan = new Rectangle(0, 0, panel1.Width, panel1.Height);

            // 2. İçeride boşaltılacak alanı belirle (Örn: 2 piksel kenar kalınlığı bırak)
            int kenarKalinligi = 2;
            Rectangle icAlan = new Rectangle(kenarKalinligi, kenarKalinligi,
                                             panel1.Width - (kenarKalinligi * 2),
                                             panel1.Height - (kenarKalinligi * 2));

            // 3. Bölge (Region) oluştur ve içini çıkar
            Region panelBolgesi = new Region(disAlan);
            panelBolgesi.Exclude(icAlan); // Orta kısmı kesip atar

            // 4. Paneli bu yeni bölgeye göre şekillendir
            panel1.Region = panelBolgesi;

            // 5. Kesik çizgili çerçeveyi çiz (İsteğe bağlı)
            using (Pen p = new Pen(Color.Black, 1))
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, 0, 0, panel1.Width - 1, panel1.Height - 1);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;

            // Kenar yumuşatma kapat (Net çizgi için)
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            using (Pen pen = new Pen(Color.Gray, 2))
            {
                // Kesikli Çizgi Modeli
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                pen.DashPattern = new float[] { 5, 5 }; // 5 dolu, 5 boş

                // Çizgiyi tam içeri hapset
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                // Çerçeveyi çiz
                e.Graphics.DrawRectangle(pen, pnl.ClientRectangle);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // En derin detay sayfasını (Popup) açar
            modalForm git = new modalForm();
            // DİKKAT: Eğer formun adı "modalForm" ise yukarıya "new modalForm()" yaz.
            git.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close(); // Bu sayfayı kapatır, Ana Ekrana döner
        }
    }
}
