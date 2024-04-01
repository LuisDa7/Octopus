using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Reportes
{
    public partial class FrmReporteVacaciones : Form
    {
        private IColaborador colaborador;
        private List<SolicitudVacaciones> lista;
        public FrmReporteVacaciones(IColaborador colaborador)
        {
            InitializeComponent();
            this.Opacity = 0;
            
            this.colaborador = colaborador;
            dgvSolicitudes.Font = new Font("Roboto", 8, FontStyle.Regular);
            IniciarLista();
            timer1.Start();
        }

        private void IniciarLista()
        {
            try
            {
                lista = SolicitudVacacionesBLL.ListaCompleta();
            }
            catch (Exception)
            {

                throw;
            }
            LlenarDGV(lista);
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

        private void btnCerrarMant_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        public void LlenarDGV(List<SolicitudVacaciones> solicitudes)
        {
            dgvSolicitudes.ClearSelection();
            dgvSolicitudes.Rows.Clear();
            dgvSolicitudes.RowTemplate.Height = 50;

            List<SolicitudVacaciones> soliAprobados = solicitudes.Where((a) => a.observaciones == Observaciones.Aprobada).ToList();
            List<SolicitudVacaciones> soliRechazados = solicitudes.Where((a) => a.observaciones == Observaciones.Rechazada).ToList();
            List<SolicitudVacaciones> soliPendiente = solicitudes.Where((a) => a.observaciones == Observaciones.Pendiente).ToList();
            IColaborador colab;
            foreach (SolicitudVacaciones item in soliAprobados)
            {
                try
                {
                    colab = ColaboradorBLL.ColaboradorPorID(item.colaboradorID);
                }
                catch (Exception)
                {
                    throw;
                }
                dgvSolicitudes.Rows.Add(item.ID,colab.Nombres+" "+colab.Apellidos, item.FechaSolicitud.ToString("dd/MM/yyyy"),
                    item.FechaDesde.ToString("dd/MM/yyyy"), item.FechaHasta.ToString("dd/MM/yyyy"),
                    item.CantidadDias, item.observaciones);
            }
            foreach (SolicitudVacaciones item in soliRechazados)
            {
                try
                {
                    colab = ColaboradorBLL.ColaboradorPorID(item.colaboradorID);
                }
                catch (Exception)
                {
                    throw;
                }
                dgvSolicitudes.Rows.Add(item.ID, colab.Nombres + " " + colab.Apellidos, item.FechaSolicitud.ToString("dd/MM/yyyy"),
                    item.FechaDesde.ToString("dd/MM/yyyy"), item.FechaHasta.ToString("dd/MM/yyyy"),
                    item.CantidadDias, item.observaciones);
            }
            foreach (SolicitudVacaciones item in soliPendiente)
            {
                try
                {
                    colab = ColaboradorBLL.ColaboradorPorID(item.colaboradorID);
                }
                catch (Exception)
                {
                    throw;
                }
                dgvSolicitudes.Rows.Add(item.ID, colab.Nombres + " " + colab.Apellidos, item.FechaSolicitud.ToString("dd/MM/yyyy"),
                    item.FechaDesde.ToString("dd/MM/yyyy"), item.FechaHasta.ToString("dd/MM/yyyy"),
                    item.CantidadDias, item.observaciones);
            }

            foreach (DataGridViewRow row in dgvSolicitudes.Rows)
            {
                Observaciones obs = (Observaciones)row.Cells[6].Value;
                if (obs == Observaciones.Aprobada)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(92, 219, 126);
                }
                else if (obs == Observaciones.Pendiente)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 208, 92);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 92, 92);
                }
                
            }
        }

        private void FrnReporteVacaciones_Load(object sender, EventArgs e)
        {
            
            dgvSolicitudes.ClearSelection();

        }

        private void FrmReporteVacaciones_Click(object sender, EventArgs e)
        {
            dgvSolicitudes.ClearSelection();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dtpDesde.Value;
            DateTime fechaHasta = this.dtpHasta.Value;
            List<SolicitudVacaciones> listaFilt;
            
            listaFilt = lista.Where((a) => a.FechaDesde.Date >= fechaDesde.Date && 
            a.FechaHasta.Date <= fechaHasta.Date).ToList();

            LlenarDGV(listaFilt);
            this.btnFiltrar.Enabled = false;
            this.btnRestablecer.Enabled = true;
            this.dtpDesde.Enabled = false;
            this.dtpHasta.Enabled = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            LlenarDGV(lista);
            this.btnFiltrar.Enabled = true;
            this.btnRestablecer.Enabled = false;
            this.dtpDesde.Enabled = true;
            this.dtpHasta.Enabled = true;
        }
    }
}
