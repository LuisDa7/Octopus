using Octopus.Layers.Entities;
using Octopus.Layers.UI.Consultas;
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

namespace Octopus.Layers.UI.MenuColab
{
    public partial class FrmMenuColab : Form
    {
        private ColaboradorRegular ColaboradorRegular;
        public FrmMenuColab(ColaboradorRegular colaboradorRegular)
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
            this.ColaboradorRegular = colaboradorRegular;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas(ColaboradorRegular);
            frmConsultas.ShowDialog();
        }

        private void btnHacerSolicitud_Click(object sender, EventArgs e)
        {
            FrmSolicitudVacaciones frmSolicitudVacaciones = new FrmSolicitudVacaciones(ColaboradorRegular);
            frmSolicitudVacaciones.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            timer2.Start();
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
                this.timer1.Stop();
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
                this.timer2.Stop();
                this.Close();
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil(ColaboradorRegular);
            frmPerfil.ShowDialog();
        }

        private void btnOctopus_Click(object sender, EventArgs e)
        {
            FrmAcercaOctopus frmAcerca = new FrmAcercaOctopus();
            frmAcerca.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuColab_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = ColaboradorRegular.ToString();
        }
    }
}
