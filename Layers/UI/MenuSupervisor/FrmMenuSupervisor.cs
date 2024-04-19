using Octopus.Interfaces;
using Octopus.Layers.Entities;
using Octopus.Layers.UI.Consultas;
using Octopus.Layers.UI.Mantenimiento;
using Octopus.Layers.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.MenuSupervisor
{
    public partial class FrmMenuSupervisor : Form
    {
        private Supervisor supervisor;
        public FrmMenuSupervisor()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
        }

        public void SetSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnHacerSolicitud_Click(object sender, EventArgs e)
        {
            FrmSolicitudVacaciones frmSolicitudVacaciones = new FrmSolicitudVacaciones(this.supervisor);
            frmSolicitudVacaciones.ShowDialog();
        }

        private void btnReporteSolicitudes_Click(object sender, EventArgs e)
        {
            FrmReporteVacaciones frmReporteVacaciones = new FrmReporteVacaciones(this.supervisor);
            frmReporteVacaciones.ShowDialog();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmRevisarSolicitudes frmRevisarSolicitudes = new FrmRevisarSolicitudes(this.supervisor);
            frmRevisarSolicitudes.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas(this.supervisor);
            frmConsultas.ShowDialog();
        }

        private void btnReporteComp_Click(object sender, EventArgs e)
        {
            FrmComprobantes frmComprobantes = new FrmComprobantes();
            frmComprobantes.ShowDialog();
        }

        private void btnReporteFecha_Click(object sender, EventArgs e)
        {
            FrmBalancePlanilla frmBalancePlanilla = new FrmBalancePlanilla();
            frmBalancePlanilla.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil(supervisor);
            frmPerfil.ShowDialog();
        }

        private void btnOctopus_Click(object sender, EventArgs e)
        {
            FrmAcercaOctopus frmAcercaOctopus = new FrmAcercaOctopus();
            frmAcercaOctopus.ShowDialog();
        }

        private void FrmMenuSupervisor_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = supervisor.ToString();
        }
    }
}
