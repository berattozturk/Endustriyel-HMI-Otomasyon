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
using System.Windows.Forms.DataVisualization.Charting;

namespace proje
{
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenRecete = cmbSelectRecipe.Text;
            DateTime baslangic = dtpStart.Value.Date;
            DateTime bitis = dtpEnd.Value.Date.AddDays(1); // Bitiş gününü de dahil etmek için +1 gün

            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True"))
            {
                baglanti.Open();

                // SQL Sorgusu
                string sorgu = "SELECT OrderID as 'Sipariş No', LogDate as 'Tarih', Material as 'Malzeme', " +
                               "TotalProductionCC as 'Üretim (cc)', TotalWeightKG as 'Ağırlık (kg)', Status as 'Durum' " +
                               "FROM ProductionLog WHERE Material = @material AND LogDate BETWEEN @start AND @end ORDER BY LogDate ASC"; // Tarihe göre sırala

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@material", secilenRecete);
                da.SelectCommand.Parameters.AddWithValue("@start", baslangic);
                da.SelectCommand.Parameters.AddWithValue("@end", bitis);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // --- 1. TABLO (DATAGRID) AYARLARI ---
                dataGridView1.DataSource = null; // Önce bağlantıyı kopar
                dataGridView1.Columns.Clear();   // Temizle
                dataGridView1.DataSource = dt;   // Yeniden bağla

                // Sütunları ekrana yay (Otomatik Genişlik)
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // --- 2. GRAFİK (CHART) AYARLARI ---
                // --- 2. GRAFİK (CHART) AYARLARI ---
                chart1.Series.Clear();
                var seri = chart1.Series.Add("Production");
                seri.ChartType = SeriesChartType.Column; // Sütun Grafik

                // ÖNEMLİ: Grafiğin sıkışmasını önleyen sihirli ayar
                seri.IsXValueIndexed = true; // Her sütunu tane tane diz, tarih gibi algılayıp sıkıştırma
                seri.Color = System.Drawing.Color.SteelBlue;

                // Döngüyle verileri ekle
                foreach (DataRow row in dt.Rows)
                {
                    // Tarihi gün/ay olarak al
                    string tarihEtiketi = Convert.ToDateTime(row["Tarih"]).ToString("dd/MM");
                    seri.Points.AddXY(tarihEtiketi, row["Üretim (cc)"]);
                }

                // --- ZOOM ve SCROLL AYARLARI (Görüntüyü Düzeltme) ---
                var chartArea = chart1.ChartAreas[0];

                // X eksenindeki yazılar (Tarihler)
                chartArea.AxisX.Interval = 1; // Her günü yaz
                chartArea.AxisX.LabelStyle.Angle = -45; // Yazıları çapraz yap (Sığması için)
                chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray; // Arkadaki çizgileri silik yap

                // Zoom Özelliklerini Aç
                chartArea.CursorX.IsUserEnabled = true;
                chartArea.CursorX.IsUserSelectionEnabled = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScrollBar.IsPositionedInside = true;

                // *** EN ÖNEMLİ KISIM: ***
                // 200 veri olsa bile başlangıçta sadece SON 20 TANESİNİ göster!
                int veriSayisi = dt.Rows.Count;
                if (veriSayisi > 20)
                {
                    // Son 20 veriye zoom yap
                    chartArea.AxisX.ScaleView.Zoom(veriSayisi - 20, veriSayisi);
                }
                else
                {
                    // Veri azsa hepsini göster
                    chartArea.AxisX.ScaleView.ZoomReset();
                }
            }
        }


        private void istatistik_Load(object sender, EventArgs e)
        {
            FiltreListesiniDoldur();

            // Eğer ana sayfadan gelen bir reçete varsa onu da otomatik seçtirelim
            if (!string.IsNullOrEmpty(recete.AktifReceteIsmi))
            {
                lblActualRecipeInUse.Text = recete.AktifReceteIsmi;
                // Listede varsa seç
                int index = cmbSelectRecipe.FindStringExact(recete.AktifReceteIsmi);
                if (index != -1) cmbSelectRecipe.SelectedIndex = index;
            }
        }
        private void FiltreListesiniDoldur()
        {
            using (SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True"))
            {
                try
                {
                    baglanti.Open();

                    // DÜZELTME: 'ReceteAdi' yerine SQL'de gördüğümüz 'RecipeName' yazıyoruz
                    string sorgu = "SELECT RecipeName FROM Recipes ORDER BY RecipeName ASC";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader dr = komut.ExecuteReader();

                    cmbSelectRecipe.Items.Clear();
                    while (dr.Read())
                    {
                        // Burası da çok önemli, okurken de doğru ismi kullanmalıyız
                        cmbSelectRecipe.Items.Add(dr["RecipeName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
