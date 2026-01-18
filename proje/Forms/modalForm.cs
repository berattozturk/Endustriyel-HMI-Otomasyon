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
    public partial class modalForm : Form
    {
        public modalForm()
        {
            InitializeComponent();
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.03;
            }


            int y = Formsonatamalar.parentY + 3;
            this.Location = new Point(Formsonatamalar.parentX + 600, y);


            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
            else
            {

                Formsonatamalar.parentY = y;
            }
        }
        int i;
        private void modalForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Formsonatamalar.parentX + 600, Formsonatamalar.parentY + 300);


            i = Formsonatamalar.parentY + 200;


            Opacity = 0;
            modalEffect_Timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
