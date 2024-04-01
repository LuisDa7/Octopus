using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using Octopus.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmSolicitudVacaciones : Form
    {
        private int cantidadDias = 0;
        private IColaborador colaborador;
        private DateTime fechaAhora  = DateTime.Now;
        private SolicitudVacaciones solicitudActiva;
        
        public FrmSolicitudVacaciones(IColaborador colaborador)
        {
            InitializeComponent();
            this.colaborador = colaborador;
            this.Opacity = 0;
            this.dtpDesde.MinDate = fechaAhora;
            this.dtpHasta.MinDate = fechaAhora;
            dgvSolicitudes.Font = new Font("Roboto", 10, FontStyle.Regular);
            LlenarDGV();
            timer1.Start();
        }

        public void LlenarDGV()
        {
            dgvSolicitudes.ClearSelection();
            dgvSolicitudes.Rows.Clear();
            List<SolicitudVacaciones> solicitudes;
            try
            {
                solicitudes = SolicitudVacacionesBLL.ListaPorColaborador(colaborador.ID);
            }
            catch (Exception)
            {
                MessageBox.Show("La lista de solicitudes no se cargó", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvSolicitudes.RowTemplate.Height = 50;

            foreach (SolicitudVacaciones item in solicitudes)
            {
                dgvSolicitudes.Rows.Add(item.ID,item.FechaSolicitud.ToString("dd/MM/yyyy"),
                    item.FechaDesde.ToString("dd/MM/yyyy"), item.FechaHasta.ToString("dd/MM/yyyy"),
                    item.CantidadDias, item.observaciones);
            }

            foreach (DataGridViewRow row in dgvSolicitudes.Rows)
            {
                Observaciones obs = (Observaciones)row.Cells[5].Value;
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

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            DateTime hasta = dtpHasta.Value;
            DateTime desde= dtpDesde.Value;
            if (hasta > desde)
            {
                TimeSpan diferencia = hasta.Subtract(desde);
                int cantidadDias = diferencia.Days + 1;
                this.lblCant.Text = cantidadDias.ToString();
            }
            else
            {
                this.cantidadDias = 0;
                this.lblCant.Text = this.cantidadDias + "";
            }
            
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            DateTime hasta = dtpHasta.Value;
            DateTime desde = dtpDesde.Value;
            if (hasta > desde)
            {
                TimeSpan diferencia = hasta.Subtract(desde);
                cantidadDias = diferencia.Days + 1;
                this.lblCant.Text = cantidadDias.ToString();
            }
            else
            {
                this.lblCant.Text = 0 + "";
            }
        }

        private void btnCerrarMant_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime hasta = dtpHasta.Value;
            DateTime desde = dtpDesde.Value;

            if (hasta < desde)
            {
                MessageBox.Show("La fecha hasta debe ser mayor que la fecha desde", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SolicitudVacacionesFactory solicitudVacacionesFactory = new SolicitudVacacionesFactory();
            SolicitudVacaciones soli = solicitudVacacionesFactory.Crear(colaborador.ID, fechaAhora, 
                desde, hasta, cantidadDias, Enum.Estado.Activo, Enum.Observaciones.Pendiente);

            try
            {
                SolicitudVacacionesBLL.Insert(soli);
            }
            catch (Exception)
            {
                MessageBox.Show("No se realizó la acción correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LlenarDGV();

        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                int idSoli = (int) dgvSolicitudes.SelectedRows[0].Cells[0].Value;
                try
                {
                    solicitudActiva = SolicitudVacacionesBLL.SolicitudPorID(idSoli);
                    this.btnEliminar.Enabled = true;
                }
                catch (Exception )
                {
                    MessageBox.Show("No se realizó la acción de carga correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                this.btnEliminar.Enabled = false;
            }
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudVacacionesBLL.Delete(solicitudActiva.ID);
                LlenarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("No se realizó la acción de borrado correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmSolicitudVacaciones_Click(object sender, EventArgs e)
        {
            dgvSolicitudes.ClearSelection();
        }
    }
}
