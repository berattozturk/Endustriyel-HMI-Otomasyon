using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje.Forms
{
    public partial class Formnbtsrglm : Form
    {
        public static string SecilenReceteIsmi = "";

       
        public Formnbtsrglm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // panelbilgi.Visible = true;
            // panel3.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {// 1. Kenar yumuşatmayı kapatalım ki çizgiler net (keskin) olsun
         // ADIM 1: Orijinal çerçeveyi KODLA ZORLA kapatıyoruz.
         // e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

            // 2. Kalem Ayarları
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                // Kesikli Çizgi Deseni
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                pen.DashPattern = new float[] { 4, 4 }; // 4 dolu, 4 boş

                // 3. SİHİRLİ KOMUT: Hizalama
                // Bu komut, kalemi çerçevenin "İÇİNE" doğru çizer. 
                // Dışarı taşma ihtimalini %0'a indirir.
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                // 4. Çizim
                // BorderStyle = None olduğu için tüm alanı (ClientRectangle) kullanıyoruz.
                // Genişlik ve Yükseklikten 1 piksel dahi kısmaya gerek yok, Inset bunu halleder.
                e.Graphics.DrawRectangle(pen, panel1.ClientRectangle);
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Formnbtsrglm_Load(object sender, EventArgs e)
        {

            panel2.BorderStyle = BorderStyle.None;
            this.ActiveControl = button1;

            // Reçeteleri getir emrini veriyoruz
            ReceteleriGetir();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True");

        void ReceteleriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                SqlCommand komut = new SqlCommand("SELECT RecipeName FROM Recipes", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                cmbReceteSecimi.Items.Clear();

                while (dr.Read())
                {
                    cmbReceteSecimi.Items.Add(dr[0].ToString());
                }

                if (cmbReceteSecimi.Items.Count > 0)
                {
                    cmbReceteSecimi.SelectedIndex = 0;
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
        private void panel2_Paint_1(object sender, PaintEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Doser 2 detayını açar
            Formnbtgrs git = new Formnbtgrs();
            // DİKKAT: Eğer formun adı "Formnbtgrs" ise yukarıya "new Formnbtgrs()" yaz.
            git.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close(); // Bu sayfayı kapatır, arkadaki ana ekran görünür.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ana ekranı geçici olarak gizle

            // Reçete Seçim Listesini (Tablolu Sayfayı) aç
            Formsonatamalar git = new Formsonatamalar();
            git.ShowDialog();

            this.Show(); // O kapanınca ana ekran geri gelsin
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbReceteSecimi.SelectedItem == null) return;

            // --- BU SATIRI EKLE ---
            // Seçilen ismi, diğer sayfa da görsün diye global değişkene atıyoruz
            SecilenReceteIsmi = cmbReceteSecimi.SelectedItem.ToString();




            // 1. Seçili reçetenin ismini alalım
            if (cmbReceteSecimi.SelectedItem == null) return; // Hiçbir şey seçilmemişse dur

            string secilenRecete = cmbReceteSecimi.SelectedItem.ToString();

            // 2. Bağlantıyı açıp verileri çekelim
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                // Seçilen isme göre o reçetenin TÜM detaylarını getir
                SqlCommand komut = new SqlCommand("SELECT * FROM Recipes WHERE RecipeName = @isim", baglanti);
                komut.Parameters.AddWithValue("@isim", secilenRecete);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {// 1. ÜST BAŞLIK
                    textactual.Text = dr["RecipeName"].ToString();

                    // 2. DOSER 1 (Gerçek Veri)
                    txtD1_SetCC.Text = dr["D1_Volume"].ToString();
                    txtD1_SetMM.Text = dr["D1_Speed"].ToString();

                    // 3. DOSER 2 (Gerçek Veri)
                    txtD2_SetCC.Text = dr["D2_Volume"].ToString();
                    txtD2_SetMM.Text = dr["D2_Speed"].ToString();

                    // 4. DOSER 3 (ARTIK VERİTABANINDAN GELİYOR!)
                    // Formdaki Textbox ismin txtD3_SetCC değilse düzeltmeyi unutma
                    txtD3_SetCC.Text = dr["D3_Volume"].ToString();
                    txtD3_SetMM.Text = dr["D3_Speed"].ToString();

                    // 5. DOSER 4 (ARTIK VERİTABANINDAN GELİYOR!)
                    txtD4_SetCC.Text = dr["D4_Volume"].ToString();
                    txtD4_SetMM.Text = dr["D4_Speed"].ToString();
                    // 5. TOTAL VOLUME HESAPLAMA (Otomatik Toplama)
                    // Veritabanından gelen 4 değeri sayıya çevirip topluyoruz
                    double d1 = Convert.ToDouble(dr["D1_Volume"]);
                    double d2 = Convert.ToDouble(dr["D2_Volume"]);
                    double d3 = Convert.ToDouble(dr["D3_Volume"]);
                    double d4 = Convert.ToDouble(dr["D4_Volume"]);

                    double toplamHacim = d1 + d2 + d3 + d4;

                    // Formdaki "288.0" yazan yere sonucu yazdırıyoruz
                    // DİKKAT: 'lblTotalVolume' yerine senin formundaki o kutunun ismini yaz!
                    texttotal.Text = toplamHacim.ToString("0.0");
                    // Doser 1 Basıncı (Örn: Giriş valfinin oradaki yazı)
                    textBox8.Text = dr["D1_Pressure"].ToString();

                    // Doser 2 Basıncı
                    textBox9.Text = dr["D2_Pressure"].ToString();

                    // Doser 3 ve 4 için de veritabanından veri çekebilirsin
                    textBox10.Text = dr["D3_Pressure"].ToString();
                    textBox11.Text = dr["D4_Pressure"].ToString();

                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            Random rastgele = new Random();
            // EĞER "SEND RECIPE" BUTONUNA BASILMADIYSA VE KUTULAR BOŞSA HATA VERMESİN DİYE KONTROL:
            if (txtD1_SetMM.Text == "" || txtD2_SetMM.Text == "") return;

            if (txtD2_SetCC.Text != "")
            {
                double d2Vol = Convert.ToDouble(txtD2_SetCC.Text);
                // Buna da hafif titreme ekliyoruz (Sanki sensör okuyormuş gibi)
                double d2Simulated = d2Vol + ((rastgele.NextDouble() * 0.2) - 0.1);

                // "D2 outlet last flow" etiketine yazdır
                // DİKKAT: 'lblD2Flow' yerine senin formundaki o etiketin adını yaz!
                textBox1.Text = d2Simulated.ToString("0.00 ") ;


                // --- EKSTRA: 2 DOSAGES (Doser 2 + Doser 4 Toplamı) ---
                // Doser 4'ü de alalım
                double d4Vol = 0;
                if (txtD4_SetCC.Text != "")
                    d4Vol = Convert.ToDouble(txtD4_SetCC.Text);

                // D2 ve D4'ü toplayıp titreme ekleyelim
                double totalCat = (d2Vol + d4Vol) + ((rastgele.NextDouble() * 0.3) - 0.15);

                // "2 dosages" etiketine yazdır
                // DİKKAT: 'lbl2Dosages' yerine senin formundaki etiketin adını yaz!
                textBox2.Text = totalCat.ToString("0.00 ") ;
            }
            try
            {
                // --- DOSER 1 SİMÜLASYONU ---
                // 1. Hedef değeri (SET) alıyoruz (Örn: 12 mm)
                double setDeger1 = Convert.ToDouble(txtD1_SetMM.Text);

                // 2. Ufak bir sapma (Gürültü) ekliyoruz (+/- 0.2 mm oynasın)
                double sapma1 = (rastgele.NextDouble() * 0.4) - 0.2;

                // 3. Actual etiketine yazdırıyoruz (Örn: 12.14 mm)
                // NOT: 'lblActual1' yerine senin formundaki etiketin adını yaz!
               textBox3.Text = (setDeger1 + sapma1).ToString("0.00") ;


                // --- DOSER 2 SİMÜLASYONU ---
                double setDeger2 = Convert.ToDouble(txtD2_SetMM.Text);
                double sapma2 = (rastgele.NextDouble() * 0.4) - 0.2;
                textBox13.Text = (setDeger2 + sapma2).ToString("0.00") ;


                // --- DOSER 3 SİMÜLASYONU ---
                double setDeger3 = Convert.ToDouble(txtD3_SetMM.Text);
                double sapma3 = (rastgele.NextDouble() * 0.4) - 0.2;
                textBox4.Text = (setDeger3 + sapma3).ToString("0.00") ;


                // --- DOSER 4 SİMÜLASYONU ---
                double setDeger4 = Convert.ToDouble(txtD4_SetMM.Text);
                double sapma4 = (rastgele.NextDouble() * 0.4) - 0.2;
               textBox7.Text = (setDeger4 + sapma4).ToString("0.00")  ;
            }
            catch
            {
                // Sayı formatında hata olursa program patlamasın diye sessizce geçiyoruz
            }
        }
    }
}
