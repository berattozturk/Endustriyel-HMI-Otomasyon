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
    public partial class Formyslyr : Form
    {
        public Formyslyr()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Formsonatamalar, senin Tank/Piston sayfanın olduğu form
            Formsonatamalar tankSayfasi = new Formsonatamalar();
            tankSayfasi.Show(); // Sayfayı açar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // 1. Ana formu gizle (Kapatma değil, görünmez yap)

            Formnbtsrglm receteSayfasi = new Formnbtsrglm();
            receteSayfasi.ShowDialog(); // 2. Sayfayı aç ve kapanana kadar bekle

            this.Show(); // 3. O sayfa kapandığın/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formnbtgrs dosersayfasi = new Formnbtgrs();
            dosersayfasi.Show(); 
        }
    }
}
