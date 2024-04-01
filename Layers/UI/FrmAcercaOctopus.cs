using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI
{
    public partial class FrmAcercaOctopus : Form
    {
        public FrmAcercaOctopus()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                this.Opacity = 1;
                this.timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                this.Opacity = 0;
                this.timer2.Stop();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
