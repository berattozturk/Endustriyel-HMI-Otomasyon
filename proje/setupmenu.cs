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
    public partial class setupmenu : Form
    {
        public setupmenu()
        {
            InitializeComponent();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            v.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Oval köşe yarıçapı (Görseldeki gibi hafif bir ovallik için 5-10 idealdir)
            int radius = 8;
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Panelin kenarını maviye boya (Görseldeki o tam mavi tonu)
                using (Pen pen = new Pen(Color.FromArgb(72, 145, 220), 1.5f))
                {
                    v.DrawPath(pen, path);
                }

                // Panelin kendisini bu oval şekle göre kes (Dışarı taşmaları önler)
                panel1.Region = new Region(path);
            }
        }

        private void panel13_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            v.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Oval köşe yarıçapı (Görseldeki gibi hafif bir ovallik için 5-10 idealdir)
            int radius = 8;
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Panelin kenarını maviye boya (Görseldeki o tam mavi tonu)
                using (Pen pen = new Pen(Color.FromArgb(72, 145, 220), 1.5f))
                {
                    v.DrawPath(pen, path);
                }

                // Panelin kendisini bu oval şekle göre kes (Dışarı taşmaları önler)
                panel1.Region = new Region(path);
            }
        }

        private void panel13_Paint_2(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            v.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 10; // Köşe ovalliği
                             // Çizimi 1 piksel içeriden başlatıyoruz ki kenarlar kesilmesin
            Rectangle rect = this.panel1.ClientRectangle;
            rect.Inflate(-1, -1);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Arka planı temizle ve yuvarlatılmış alanı belirle
                this.panel1.Region = new Region(path);

                // Mavi çerçeveyi çiz
                using (Pen pen = new Pen(Color.FromArgb(72, 145, 220), 2f)) // 2f kalınlık daha belirgin yapar
                {
                    v.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_3(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Ayarlar
            int radius = 15; // Köşe ovalliği miktarı
            Color borderColor = Color.FromArgb(72, 145, 220); // Hedef mavi tonu
            float borderThickness = 2f;

            // Çizim alanını 2 piksel içeriden başlatıyoruz (Kesilmeyi önleyen kritik kısım)
            Rectangle rect = new Rectangle(2, 2, panel1.Width - 5, panel1.Height - 5);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Kenarlığı çiz
                using (Pen pen = new Pen(borderColor, borderThickness))
                {
                    g.DrawPath(pen, path);
                }

                // İsteğe bağlı: Panelin dış köşelerini de bu şekle göre kesmek istersen:
                // this.panel1.Region = new Region(path);
            }
        }

        private void panel13_Paint_4(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Çizim ayarları
            int radius = 15; // Köşe ovalliği
            Color borderColor = Color.FromArgb(72, 145, 220); // Hedef mavi tonu
            int thickness = 2; // Çizgi kalınlığı

            // 3. Çizim alanını 2 piksel içeriden başlatıyoruz (Kesilmeyi önleyen kritik hamle)
            // panel1.Width ve Height değerlerinden 5 çıkararak çizgiye nefes alanı bırakıyoruz
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // ÖNEMLİ: Bu sefer Region satırını eklemiyoruz. 
                // Panel dikdörtgen kalsın ama biz içine ovali tam çizelim.

                // 4. Mavi çerçeveyi çiziyoruz
                using (Pen pen = new Pen(borderColor, thickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_5(object sender, PaintEventArgs e)
        {
            // Kenar yumuşatma açık
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Renk ve kalınlık ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Görseldeki o tam mavi
            float thickness = 2f;
            int radius = 12; // 40px yükseklik için 12-15 arası ideal bir ovallik verir

            // Sınırları 80x40'a göre daraltıyoruz (Kesilmeyi önlemek için 2px içeriden çiziyoruz)
            // rect = {X: 1, Y: 1, Width: 77, Height: 37}
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // ÖNEMLİ: Bu boyutta Region kullanma, sadece DrawPath yapıyoruz
                using (Pen pen = new Pen(borderColor, thickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_6(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek seviyeye alıyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.panel1.Parent.BackColor); // Dış köşeleri temizle

            // 2. Ayarlar
            int radius = 15; // 40px yükseklik için ideal ovallik
            Color borderColor = Color.FromArgb(72, 145, 220); // Hedef mavi
            Color innerColor = Color.FromArgb(200, 208, 232); // İç dolgu rengi (Senin label rengin)

            // Çizimi 1 piksel içeriden yapıyoruz ki kenarlar kesilmesin
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 3. İçini boya (Böylece dışarı taşma olmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 4. Mavi çerçeveyi çiz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_7(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek seviyeye alıyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.panel1.Parent.BackColor); // Dış köşeleri temizle

            // 2. Ayarlar
            int radius = 15; // 40px yükseklik için ideal ovallik
            Color borderColor = Color.FromArgb(72, 145, 220); // Hedef mavi
            Color innerColor = Color.FromArgb(200, 208, 232); // İç dolgu rengi (Senin label rengin)

            // Çizimi 1 piksel içeriden yapıyoruz ki kenarlar kesilmesin
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 3. İçini boya (Böylece dışarı taşma olmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 4. Mavi çerçeveyi çiz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_8(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(200, 208, 232);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Paint_9(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(200, 208, 232);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel13_Resize(object sender, EventArgs e)
        {
            panel13.Invalidate();
        }

        private void panel13_Paint_10(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı açıyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerini formun zemin rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk ve Ölçü Ayarları (60x30 için özel)
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.White;                    // İstediğin tam beyaz dolgu
            int radius = 10; // 30px yükseklik için 10-12 arası ovallik en estetik duranıdır

            // 4. Çizim alanını panelden 2-3 piksel küçük tutuyoruz
            // 60x30 panelde çizim alanı 57x27 olacak
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. İçini Beyaz Boya
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Mavi çerçeveyi çiz (1.5f kalınlık 60x30 için daha zarif durur)
                using (Pen pen = new Pen(borderColor, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel22_Paint_1(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel28_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {
            // 1. Kenar yumuşatmayı en yüksek kaliteye çekiyoruz
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Panelin dış köşelerinde kalan artıkları formun rengiyle temizliyoruz
            e.Graphics.Clear(this.panel1.Parent.BackColor);

            // 3. Renk Ayarları
            Color borderColor = Color.FromArgb(72, 145, 220); // Dış mavi çerçeve
            Color innerColor = Color.FromArgb(255, 255, 255);   // İç dolgu rengi
            int radius = 15; // 40px yükseklik için en iyi ovallik

            // 4. Çizim alanını panelden 2 piksel küçük tutuyoruz (Kesilmeyi önleyen kritik ayar)
            Rectangle rect = new Rectangle(1, 1, panel1.Width - 3, panel1.Height - 3);

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Oval yolu oluşturuyoruz
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                // 5. Önce içini boyuyoruz (Taşma yapmaz)
                using (SolidBrush brush = new SolidBrush(innerColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 6. Sonra mavi çerçeveyi üstüne çiziyoruz
                using (Pen pen = new Pen(borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void setupmenu_Load(object sender, EventArgs e)
        {
            // recete formunda hafızaya aldığımız AktifReceteID'yi kullanıyoruz
            if (recete.AktifReceteID == 0)
            {
                MessageBox.Show("Lütfen önce Reçete sayfasından bir reçete seçip 'SEND TO PLC' yapın.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-REBQ8RL\SQLEXPRESS01;Initial Catalog=DolumMakinesiDB;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                // SQL'e eklediğin 16 satırı çekiyoruz
                string sorgu = "SELECT SettingName, ValueMS FROM GasSettings WHERE RecipeID = @rid";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@rid", recete.AktifReceteID);

                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    string ayarAdi = dr["SettingName"].ToString();
                    string deger = dr["ValueMS"].ToString();

                    // SQL'e az önce INSERT ettiğimiz isimlerle birebir eşleşme:
                    if (ayarAdi == "GasFull") label5.Text = deger;
                    if (ayarAdi == "GasEmpty") label6.Text = deger;
                    if (ayarAdi == "TableIn") label7.Text = deger;
                    if (ayarAdi == "TableOut") label8.Text = deger;
                    if (ayarAdi == "NozzleD") label9.Text = deger;
                    if (ayarAdi == "NozzleU") label3.Text = deger;
                    if (ayarAdi == "VacS") label12.Text = deger;
                    if (ayarAdi == "VacE") label11.Text = deger;
                    if (ayarAdi == "FillS") label15.Text = deger;
                    if (ayarAdi == "FillE") label14.Text = deger;
                    if (ayarAdi == "CapS") label17.Text = deger;
                    if (ayarAdi == "CapE") label16.Text = deger;
                    if (ayarAdi == "ConvS") label21.Text = deger;
                    if (ayarAdi == "ConvSt") label20.Text = deger;
                    if (ayarAdi == "Emerg") label19.Text = deger;
                    if (ayarAdi == "Ready") label18.Text = deger;
                }
            }
        }
    }
}
