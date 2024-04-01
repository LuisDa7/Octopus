using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmRevisarSolicitudes : Form
    {
        private IColaborador colaborador;
        public FrmRevisarSolicitudes(IColaborador colaborador)
        {
            InitializeComponent();
            this.colaborador = colaborador;
            this.Opacity = 0;
            dgvSolicitudes.Font = new Font("Roboto", 10, FontStyle.Regular);
            timer1.Start();
            LlenarDGV();
            
        }

        public void LlenarDGV()
        {
            dgvSolicitudes.Rows.Clear();
            List<SolicitudVacaciones> solicitudes;
            IColaborador colaborador;
            
            if (this.colaborador is Supervisor)
            {
                try
                {
                    solicitudes = SolicitudVacacionesBLL.ListaBySupervisor(this.colaborador.ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("La lista de solicitudes no se cargó", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                try
                {
                    solicitudes = SolicitudVacacionesBLL.ListaCompleta();

                }
                catch (Exception)
                {
                    MessageBox.Show("La lista de solicitudes no se cargó", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            dgvSolicitudes.RowTemplate.Height = 50;

            foreach (SolicitudVacaciones item in solicitudes)
            {
                try
                {
                    colaborador = ColaboradorBLL.ColaboradorPorID(item.colaboradorID);

                }
                catch (Exception)
                {
                    MessageBox.Show("La lista de solicitudes no se cargó", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvSolicitudes.Rows.Add(item.ID, colaborador.ToString(),item.FechaSolicitud.ToString("dd/MM/yyyy"),
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
            timer2.Start();
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                int idSoli = (int)dgvSolicitudes.SelectedRows[0].Cells[0].Value;

                SolicitudVacaciones solicitud;
                try
                {
                    solicitud = SolicitudVacacionesBLL.SolicitudPorID(idSoli);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se realizó la acción de cargar correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                solicitud.observaciones = Observaciones.Aprobada;
                string asunto = "Tu solicitud de vacaciones ha sido aprobada";
                string cuerpo = "La solicitud código "+idSoli+", del "+
                    solicitud.FechaDesde.ToString("dd/MM/yy")+" al "+
                    solicitud.FechaHasta.ToString("dd/MM/yy") +" ya está aprobada, ¡felices vacaciones!";
                try
                {
                    SolicitudVacacionesBLL solicitudVacacionesBLL = new SolicitudVacacionesBLL();
                    solicitudVacacionesBLL.Update(solicitud);
                    EnviarCorreoElectronico(colaborador.Correo, asunto, cuerpo);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se realizó la acción de aprobar correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LlenarDGV();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Se ha notificado al colaborador", "Listo" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void EnviarCorreoElectronico(string destinatarioCorreo, string asunto, string cuerpo)
        {
            string remitenteCorreo = "SoftwareS.AOficial@gmail.com";
            string remitenteContraseña = "tehi maam corn iuej";
           

            // Asunto y cuerpo del correo electrónico
            

            // Configuración del cliente SMTP
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.Port = 587;
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential(remitenteCorreo, remitenteContraseña);

            // Creación del mensaje de correo electrónico
            MailMessage mensaje = new MailMessage(remitenteCorreo, destinatarioCorreo, asunto, cuerpo);

            try
            {
                // Envío del correo electrónico
                clienteSmtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // Liberar recursos
                mensaje.Dispose();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                int idSoli = (int)dgvSolicitudes.SelectedRows[0].Cells[0].Value;
                SolicitudVacaciones solicitud;
                try
                {
                    solicitud = SolicitudVacacionesBLL.SolicitudPorID(idSoli);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se realizó la acción de cargar correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                solicitud.observaciones = Observaciones.Rechazada;
                string asunto = "Tu solicitud de vacaciones ha sido rechazada";
                string cuerpo = "La solicitud código " + idSoli + ", del " +
                    solicitud.FechaDesde.ToString("dd/MM/yy") + " al " +
                    solicitud.FechaHasta.ToString("dd/MM/yy") + " ha sido rechazada.";
                try
                {
                    SolicitudVacacionesBLL solicitudVacacionesBLL = new SolicitudVacacionesBLL();
                    solicitudVacacionesBLL.Update(solicitud);
                    EnviarCorreoElectronico(colaborador.Correo, asunto, cuerpo);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se realizó la acción de aprobar correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LlenarDGV();
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Se ha notificado al colaborador", "Listo" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void FrmRevisarSolicitudes_Load(object sender, EventArgs e)
        {
            this.dgvSolicitudes.ClearSelection();
        }

        private void FrmRevisarSolicitudes_Click(object sender, EventArgs e)
        {
            this.dgvSolicitudes.ClearSelection();
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                string obs = dgvSolicitudes.SelectedRows[0].Cells[6].Value.ToString();
                if (obs == "Aprobada")
                {
                    this.btnAprobar.Enabled = false;
                    this.btnBorrar.Enabled = true;
                }
                else if (obs == "Rechazada")
                {
                    this.btnAprobar.Enabled = true;
                    this.btnBorrar.Enabled = false;
                }
                else
                {
                    this.btnAprobar.Enabled = true;
                    this.btnBorrar.Enabled = true;
                }
            }
            else
            {
                this.btnAprobar.Enabled = false;
                this.btnBorrar.Enabled = false;
            }
        }
    }
}
