using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje.Forms
{
    public partial class Formsonatamalar : Form
    {
        public Formsonatamalar()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;
        private void button37_MouseClick(object sender, MouseEventArgs e)
        {
            Form modalBackground = new Form();
            using (modalForm modal = new modalForm()) // ModalForm sınıfınız doğru şekilde tanımlandıysa
            {
                // modalBackground formunun ayarlarını yap
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.BackColor = Color.Magenta;
                modalBackground.TransparencyKey = Color.Magenta;
                modalBackground.Opacity = 0.50d; // Yarı şeffaf
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.TopMost = true; // Her zaman üstte göster
                modalBackground.Show();

                // Modal formun sahibini (owner) modalBackground olarak ayarla
                modal.Owner = modalBackground;
                parentX = this.Location.X;
                parentY = this.Location.Y;

                // Modal formu göster
                modal.ShowDialog();

                // ModalBackground formunu temizle
                modalBackground.Dispose();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formsonatamalar_Load(object sender, EventArgs e)
        {
            // Veritabanından verileri çek ve kutulara doldur
            TankAyarlariniGetir();

            // Mavi odaklanma sorununu çöz
            this.ActiveControl = label1; // Odaklanacak zararsız bir label bulup onun adını yazabilirsin

        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True");

        void TankAyarlariniGetir()
        {
            try
            {
                baglanti.Open();

                // 1. SORGUYU HAZIRLA
                // Ana sayfada (Formnbtsrglm) seçilen reçetenin ismini alıyoruz
                // NOT: Formnbtsrglm içindeki 'SecilenReceteIsmi' değişkenini public static yaptığından emin ol!
                string gelenIsim = Formnbtsrglm.SecilenReceteIsmi;

                string sorgu = "";

                if (gelenIsim != "")
                {
                    // Eğer bir reçete seçildiyse onun vakum değerini getir
                    sorgu = "SELECT Tank_VacuumLevel FROM Recipes WHERE RecipeName = @isim";
                }
                else
                {
                    // Seçilmediyse en son eklenen reçeteyi getir (Hata vermesin diye)
                    sorgu = "SELECT TOP 1 Tank_VacuumLevel FROM Recipes ORDER BY RecipeID DESC";
                }

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                if (gelenIsim != "")
                {
                    komut.Parameters.AddWithValue("@isim", gelenIsim);
                }

                // 2. VERİYİ OKU VE KUTULARA YAZ
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    string vakumDegeri = dr["Tank_VacuumLevel"].ToString();

                    // --- BURAYI KENDİ KUTU İSİMLERİNE GÖRE DÜZELT ---
                    // "Set vacuum - normal work" kutusu:
                    textBox1.Text = vakumDegeri;

                    // "Set vacuum - loading phase" kutusu:
                    textBox2.Text = vakumDegeri;
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tank verisi çekilemedi: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// 1. BU SATIRI EKLE (Bilgisayar artık "rastgele"nin ne olduğunu biliyor)
            Random rastgele = new Random();

            // --- BASINÇ SİMÜLASYONU ---

            // 38 ile 42 arasında sayı üret
            double anlikBasinc = 38 + (rastgele.NextDouble() * 4);

            // Etikete yazdır
            // DİKKAT: 'label5' yazan yere senin mavi etiketin ismini yaz! (Örn: lblActualPressure)
            label7.Text = anlikBasinc.ToString("0") + " mbar";

            // Renk Efekti
            if (anlikBasinc > 41.5)
            {
                label7.ForeColor = Color.Red;
            }
            else
            {
                label7.ForeColor = Color.Blue;
            }
        }
    }
}