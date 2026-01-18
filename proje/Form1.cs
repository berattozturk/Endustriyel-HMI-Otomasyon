using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proje.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ana ekranı geçici olarak gizle

            // Reçete Seçim Listesini (Tablolu Sayfayı) aç
            recete git = new recete();
            git.ShowDialog();

            this.Show(); // O kapanınca ana ekran geri gelsin
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Genel Tank/Piston Görünümünü aç
            Formnbtsrglm git = new Formnbtsrglm();
            git.ShowDialog();

            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // setupmenu.cs formundan bir nesne türetiyoruz
            setupmenu setupSayfasi = new setupmenu();

            // Formu ekranda gösteriyoruz
            setupSayfasi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // setupmenu.cs formundan bir nesne türetiyoruz
            istatistik istatistiksayfasi = new istatistik();

            // Formu ekranda gösteriyoruz
            istatistiksayfasi.Show();
        }
    }
}
