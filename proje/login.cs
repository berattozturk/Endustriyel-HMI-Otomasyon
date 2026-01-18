using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class login : Form
    {
        public static string OturumYetkisi = "";
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True");
            try
            {
                baglanti.Open();
                // SORGUNU GÜNCELLE: UserRole sütununu da çekmeliyiz ki kim olduğunu bilelim
                string sorgu = "SELECT * FROM Users WHERE Username = @user AND Password = @pass";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@user", cmbUserRole.Text);
                komut.Parameters.AddWithValue("@pass", txtPassword.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    // --- YENİ EKLENEN SATIRLAR ---
                    // 1. Yetkiyi hafızaya alıyoruz (dr["UserRole"] veritabanındaki sütun adın olmalı)
                    login.OturumYetkisi = dr["UserRole"].ToString();

                    // 2. LogKaydet fonksiyonunu çağırıyoruz
                    LogKaydet(cmbUserRole.Text, "Sisteme giriş yapıldı.");
                    // -----------------------------

                    Form1 anaSayfa = new Form1();
                    anaSayfa.Show();
                    this.Hide();
                }
                else
                {
                    // --- YENİ EKLENEN SATIR ---
                    // Hatalı girişi de loglayalım
                    LogKaydet(cmbUserRole.Text, "Hatalı şifre denemesi yapıldı!");
                    // --------------------------

                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
                if (baglanti.State == System.Data.ConnectionState.Open) baglanti.Close();
            }
        }
        public static void LogKaydet(string kullanıcıAdı, string aciklama)
        {
            string baglantiAdresi = @"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True";
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                baglanti.Open();
                string sorgu = "INSERT INTO SystemLogs (Username, UserRole, ActionDescription) VALUES (@user, @role, @action)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // Şimdi altındaki kırmızı çizgi gidecek
                komut.Parameters.AddWithValue("@user", kullanıcıAdı); // Artık altı çizili olmayacak!
                komut.Parameters.AddWithValue("@role", login.OturumYetkisi);
                komut.Parameters.AddWithValue("@action", aciklama);

                komut.ExecuteNonQuery(); 
            }
        }


        private void login_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Bağlantıyı kur
                SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True");
                baglanti.Open();

                // 2. Kullanıcıları çek
                SqlCommand komut = new SqlCommand("SELECT Username FROM Users", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                // 3. ComboBox'ı doldur
                cmbUserRole.Items.Clear();
                while (dr.Read())
                {
                    cmbUserRole.Items.Add(dr["Username"].ToString());
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı listesi yüklenemedi: " + ex.Message);
            }
        }
    }
}
