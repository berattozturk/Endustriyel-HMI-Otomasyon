using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje
{
    public partial class recete : Form
    {
        public static int AktifReceteID = 0;
        public static string AktifReceteIsmi = "";
        public recete()
        {
            InitializeComponent();
        }

        // --- GLOBAL TANIMLAR ---
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True");

        // Makinenin Piston Çapları (Sabit donanım bilgisi)
        // D1 ve D3 genelde Ana Malzeme (Büyük), D2 ve D4 Katalizör (Küçük) olur.
        const int DIA_MAIN = 100; // mm
        const int DIA_CAT = 16;   // mm

        private void recete_Load(object sender, EventArgs e)
        {
            // 1. Sayfa açılınca ComboBox'a reçeteleri doldur
            ReceteListesiniGetir();

            // 2. Mavi yanmayı engelle
            this.ActiveControl = label1; // Odaklanacak rastgele bir label
        }

        void ReceteListesiniGetir()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT RecipeName FROM Recipes", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                // ComboBox ismini kontrol et: cmbReceteSecimi
                cmbReceteSecimi.Items.Clear();
                while (dr.Read())
                {
                    cmbReceteSecimi.Items.Add(dr[0].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenirken hata: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close(); // Sayfayı kapatthis.Close(); // Bu sayfayı kapatır, Ana Ekrana döner
        }
        void VerileriGetirVeHesapla(string receteAdi)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM Recipes WHERE RecipeName = @isim", baglanti);
                komut.Parameters.AddWithValue("@isim", receteAdi);
                SqlDataReader dr = komut.ExecuteReader();

                // VerileriGetirVeHesapla metodunun içine ekle
               

                if (dr.Read())
                {
                   
                    AktifReceteID = Convert.ToInt32(dr["RecipeID"]);
                    MessageBox.Show("Aktif ID Kaydedildi: " + AktifReceteID);
                    // --- 1. VERİLERİ ÇEK ---
                    double d1_vol = Convert.ToDouble(dr["D1_Volume"]);
                    double d2_vol = Convert.ToDouble(dr["D2_Volume"]);
                    double d3_vol = Convert.ToDouble(dr["D3_Volume"]);
                    double d4_vol = Convert.ToDouble(dr["D4_Volume"]);

                    // Hızları "h set" (mm) olarak kullanıyoruz
                    string d1_h = dr["D1_Speed"].ToString();
                    string d2_h = dr["D2_Speed"].ToString();
                    string d3_h = dr["D3_Speed"].ToString();
                    string d4_h = dr["D4_Speed"].ToString();

                    // --- 2. HESAPLAMALAR ---
                    double totalVol = d1_vol + d2_vol + d3_vol + d4_vol;

                    // Yüzdeler (Sıfıra bölünme hatası olmasın diye kontrol ediyoruz)
                    double d1_pct = totalVol > 0 ? (d1_vol / totalVol) * 100 : 0;
                    double d2_pct = totalVol > 0 ? (d2_vol / totalVol) * 100 : 0;
                    double d3_pct = totalVol > 0 ? (d3_vol / totalVol) * 100 : 0;
                    double d4_pct = totalVol > 0 ? (d4_vol / totalVol) * 100 : 0;

                    // --- 3. EKRANA YAZDIRMA ---

                    // Üst Bilgiler
                    lblActualRecipe.Text = receteAdi;
                    lblTotalVolume.Text = totalVol.ToString("0.0") + " cc";

                    // === DOSER 1 SATIRI ===
                    lblD1_Dia.Text = DIA_MAIN.ToString();     // Çap (100)
                    lblD1_Yuzde.Text = d1_pct.ToString("0.00"); // %
                    lblD1_Vol.Text = d1_vol.ToString("0.00");   // cc
                    lblD1_Hset.Text = d1_h;                   // mm
                    // Durum Kontrolü: Hacim 0 ise "not used", yoksa "working"
                    lblD1_Status.Text = d1_vol > 0 ? "working (auto)" : "not used";

                    // === DOSER 2 SATIRI ===
                    lblD2_Dia.Text = DIA_CAT.ToString();      // Çap (16)
                    lblD2_Yuzde.Text = d2_pct.ToString("0.00");
                    lblD2_Vol.Text = d2_vol.ToString("0.00");
                    lblD2_Hset.Text = d2_h;
                    lblD2_Status.Text = d2_vol > 0 ? "working (auto)" : "not used";

                    // === DOSER 3 SATIRI ===
                    lblD3_Dia.Text = d3_vol > 0 ? DIA_MAIN.ToString() : "0"; // Kullanılmıyorsa çap 0 görünsün
                    lblD3_Yuzde.Text = d3_pct.ToString("0.00");
                    lblD3_Vol.Text = d3_vol.ToString("0.00");
                    lblD3_Hset.Text = d3_h;
                    lblD3_Status.Text = d3_vol > 0 ? "working (auto)" : "not used";

                    // === DOSER 4 SATIRI ===
                    lblD4_Dia.Text = d4_vol > 0 ? DIA_CAT.ToString() : "0";
                    lblD4_Yuzde.Text = d4_pct.ToString("0.00");
                    lblD4_Vol.Text = d4_vol.ToString("0.00");
                    lblD4_Hset.Text = d4_h;
                    lblD4_Status.Text = d4_vol > 0 ? "working (auto)" : "not used";

                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (cmbReceteSecimi.SelectedItem == null) return;

            string secilen = cmbReceteSecimi.SelectedItem.ToString();
            VerileriGetirVeHesapla(secilen);
            login.LogKaydet(login.OturumYetkisi, secilen + " reçetesi PLC'ye gönderildi.");
        }

        private void recete_Load_1(object sender, EventArgs e)
        {
            // 1. ÖNCE listeyi veritabanından doldurmalısın (Kritik!)
            ReceteListesiniGetir();

            // 2. SONRA hafızadaki ID'yi seçtirmelisin
            if (AktifReceteID != 0)
            {
                // ComboBox'ın ValueMember özelliğinin "RecipeID" olarak ayarlandığından emin ol
                cmbReceteSecimi.SelectedValue = AktifReceteID;

                // Eğer SelectedValue ile seçilmiyorsa alternatif (Metin üzerinden):
                // cmbReceteSecimi.Text = lblActualRecipe.Text; 

                string secilenAd = cmbReceteSecimi.Text;
                VerileriGetirVeHesapla(secilenAd);
            }

            this.ActiveControl = label1;
        }
    }
}
