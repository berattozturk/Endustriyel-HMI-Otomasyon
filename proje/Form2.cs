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
using MaterialSkin;
using MaterialSkin.Controls;

namespace proje
{
    public partial class Form2 : MaterialForm
    {
        // Sidebar animasyon değişkenlerini SİLDİM (sidebarExpand vs.)

        public Form2()
        {
            // MaterialSkin Ayarları (Renk vb.)
            MaterialSkinManager materialSkinManager;
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                ColorTranslator.FromHtml("#1E1E1E"),
                ColorTranslator.FromHtml("#161616"),
                ColorTranslator.FromHtml("#2A2A2A"),
                ColorTranslator.FromHtml("#333333"),
                TextShade.WHITE
            );
        }

        // Timer_Tick olayını SİLDİM (Artık animasyon yok)
        // MenuButton_Click olayını SİLDİM (Artık menü aç/kapa yok)
        // OpenChildForm olayını SİLDİM (Artık panel içine gömme yok)

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form açıldığında yapılacak özel bir işlem varsa buraya yazabilirsin.
            // Şu an için boş kalabilir.
        }

        // --- SAYFA GEÇİŞ BUTONLARI ---

        // 1. Son Atamalar Sayfasına Git
        private void buttonSonAtamalar_Click(object sender, EventArgs e)
        {
            Formsonatamalar yeniForm = new Formsonatamalar();
            yeniForm.Show(); // Yeni pencereyi aç
            this.Hide();     // Bu pencereyi gizle
        }

        // 2. Nöbet Giriş Sayfasına Git
        private void button2_Click(object sender, EventArgs e)
        {
            Formnbtgrs yeniForm = new Formnbtgrs();
            yeniForm.Show();
            this.Hide();
        }

        // 3. Nöbet Sorgulama Sayfasına Git
        private void button3_Click(object sender, EventArgs e)
        {
            Formnbtsrglm yeniForm = new Formnbtsrglm();
            yeniForm.Show();
            this.Hide();
        }

        // 4. Yasal Uyarı Sayfasına Git
        private void button5_Click(object sender, EventArgs e)
        {
            Formyslyr yeniForm = new Formyslyr();
            yeniForm.Show();
            this.Hide();
        }

        // 5. Şifre Güncelleme Sayfasına Git
        private void button4_Click(object sender, EventArgs e)
        {
            Formsfrgncllm yeniForm = new Formsfrgncllm();
            yeniForm.Show();
            this.Hide();
        }

        // Logo veya Başlık Tıklaması (Gerekirse Ana Sayfayı yeniler)
        private void label1_Click(object sender, EventArgs e)
        {
            // Zaten bu sayfadasın, bir şey yapmasına gerek yok.
            // İstersen burayı tamamen silebilirsin.
        }
    }
}