using Octopus.Layers.UI.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.MenuAdministrador
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.10;
            }
            else
            {
                this.Opacity = 1;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.10;
            }
            else
            {
                this.Opacity = 0;
                timer2.Stop();
                this.Close();
            }
        }

        private void btnCerrarMant_Click(object sender, EventArgs e)
        {
            timer2.Start();
            
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            FrmPuesto frmPuesto = new FrmPuesto();
            frmPuesto.Opacity = 0;
            timer3.Start();
            
            frmPuesto.ShowDialog();
            this.Visible = true;
            timer1.Start();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.10;
            }
            else
            {
                this.Opacity = 0;
                this.Visible = false;
                timer3.Stop();
                
            }
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            FrmColaborador frmColaborador = new FrmColaborador();
            frmColaborador.ShowDialog();
        }

        private void btnDeducPercep_Click(object sender, EventArgs e)
        {
            FrmDeducPercep frmDeducPercep = new FrmDeducPercep();
            frmDeducPercep.ShowDialog();
        }
    }
}
