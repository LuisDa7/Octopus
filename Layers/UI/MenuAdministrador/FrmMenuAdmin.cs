using Octopus.Layers.Entities;
using Octopus.Layers.UI.Mantenimiento;
using Octopus.Layers.UI.Marcas;
using Octopus.Layers.UI.MenuAdministrador;
using Octopus.Layers.UI.Planilla;
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
using QRCoder;
using iTextSharp;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Mail;
using System.Net;
using Octopus.Layers.UI.Consultas;

namespace Octopus.Layers.UI
{
    public partial class FrmMenuAdmin : Form
    {
        private Administrador administrador;
        private List<Entities.Marcas> listaMarcas = new List<Entities.Marcas>();
        private List<EncPlanillaColab> encabezados = new List<EncPlanillaColab>();
        private Entities.Planilla planilla = new Entities.Planilla();
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMenuAdmin()
        {
            InitializeComponent();
            this.Opacity = 0;
            timerVentana.Start();

        }

        public void SetAdmin(Administrador administrador)
        {
            this.administrador = administrador;
        }
        private void btnMantenimento_Click(object sender, EventArgs e)
        {
            FrmMantenimiento frmMantenimiento = new FrmMantenimiento();
            frmMantenimiento.ShowDialog();
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            FrmPuesto frmPuesto = new FrmPuesto();
            frmPuesto.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.planilla.estado == Enum.Estado.PorEnviar)
            {
                try
                {
                    EncPlanillaColab enc = encabezados.FirstOrDefault();

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        DetPlanillaColabBLL detPlanillaColabBLL = new DetPlanillaColabBLL();
                        detPlanillaColabBLL.DeleteByEnc(item.ID);
                    }

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        EncPlanillaColabBLL encPlanillaColabBLL = new EncPlanillaColabBLL();
                        encPlanillaColabBLL.Delete(item.ID);
                    }

                    PlanillaBLL planillaBLL = new PlanillaBLL();
                    planillaBLL.Delete(planilla.ID);
                    _MyLogControlEventos.Info("El administrador salió");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar planilla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            timerVentanaCerrar.Start();
        }

        private void timerVentana_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                this.Opacity = 1;
                timerVentana.Stop();

            }
        }

        private void timerVentanaCerrar_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                this.Opacity = 0;
                timerVentana.Stop();
                this.Close();
            }

        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = "Bienvenido " + administrador.Nombres;
        }

        private void btnHacerSolicitud_Click(object sender, EventArgs e)
        {
            FrmSolicitudVacaciones frmSolicitudVacaciones = new FrmSolicitudVacaciones(administrador);
            frmSolicitudVacaciones.ShowDialog();
        }

        private void btnSolicitudes_Click(object sender, EventArgs e)
        {
            FrmRevisarSolicitudes frmRevisarSolicitudes = new FrmRevisarSolicitudes(this.administrador);
            frmRevisarSolicitudes.ShowDialog();
        }

        private void btnReporteSolicitudes_Click(object sender, EventArgs e)
        {
            FrmReporteVacaciones frmReporteVacaciones = new FrmReporteVacaciones(this.administrador);
            frmReporteVacaciones.ShowDialog();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frmMarcas = new FrmMarcas(listaMarcas, (lista) =>
            {
                this.listaMarcas = lista;

            });
            frmMarcas.ShowDialog();
            if (this.listaMarcas != null)
            {
                if (this.listaMarcas.Count > 0)
                {
                    this.btnPlanilla.Enabled = true;
                }
                else
                {
                    this.btnPlanilla.Enabled = false;
                }
            }

        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            if (listaMarcas.Count == 0)
            {
                MessageBox.Show("Primero debe cargar las marcas", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmPlanilla frmPlanilla = new FrmPlanilla(listaMarcas, encabezados, (lista) =>
            {
                this.encabezados = lista;
            }, (planilla) =>
                {
                    this.planilla = planilla;
                });
            frmPlanilla.ShowDialog();
            if (planilla != null)
            {
                this.btnEnviarComp.Enabled = true;
                this.btnAnular.Enabled = true;
            }
        }

        private void btnEnviarComp_Click(object sender, EventArgs e)
        {
            if (this.planilla.estado == Enum.Estado.PorEnviar)
            {
                FrmEnvioComp frmEnvioComp = new FrmEnvioComp(encabezados, planilla, (planilla) => 
                {
                    this.planilla = planilla;
                    try
                    {
                        PlanillaBLL planillaBLL = new PlanillaBLL();
                        planillaBLL.Update(planilla.ID, planilla.estado);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    this.encabezados.Clear();
                    this.btnAnular.Enabled = false;
                    this.btnEnviarComp.Enabled = false;
                    this.btnPlanilla.Enabled = false;
                    this.listaMarcas.Clear();

                });
                frmEnvioComp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ninguna planilla por enviar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        

        private void FrmMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.planilla.estado == Enum.Estado.PorEnviar)
            {
                try
                {
                    EncPlanillaColab enc = encabezados.FirstOrDefault();

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        DetPlanillaColabBLL detPlanillaColabBLL = new DetPlanillaColabBLL();
                        detPlanillaColabBLL.DeleteByEnc(item.ID);
                    }

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        EncPlanillaColabBLL encPlanillaColabBLL = new EncPlanillaColabBLL();
                        encPlanillaColabBLL.Delete(item.ID);
                    }

                    PlanillaBLL planillaBLL = new PlanillaBLL();
                    planillaBLL.Delete(planilla.ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar planilla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (this.planilla.estado == Enum.Estado.PorEnviar)
            {
                try
                {
                    EncPlanillaColab enc = encabezados.FirstOrDefault();

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        DetPlanillaColabBLL detPlanillaColabBLL = new DetPlanillaColabBLL();
                        detPlanillaColabBLL.DeleteByEnc(item.ID);
                    }

                    foreach (EncPlanillaColab item in encabezados)
                    {
                        EncPlanillaColabBLL encPlanillaColabBLL = new EncPlanillaColabBLL();
                        encPlanillaColabBLL.Delete(item.ID);
                    }

                    PlanillaBLL planillaBLL = new PlanillaBLL();
                    planillaBLL.Delete(planilla.ID);
                    _MyLogControlEventos.Error("Se eliminó una planilla");
                    MessageBox.Show("Se anuló la planilla", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btnAnular.Enabled = false;
                    this.btnEnviarComp.Enabled = false;
                    this.btnPlanilla.Enabled = false;
                    this.listaMarcas.Clear();
                    this.encabezados.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al borrar planilla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna planilla por enviar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas(administrador);
            frmConsultas.ShowDialog();
        }

        private void btnReporteFecha_Click(object sender, EventArgs e)
        {
            FrmBalancePlanilla frmBalancePlanilla = new FrmBalancePlanilla();
            frmBalancePlanilla.ShowDialog();
        }

        private void btnReporteComp_Click(object sender, EventArgs e)
        {
            FrmComprobantes frmComprobantes = new FrmComprobantes();
            frmComprobantes.ShowDialog();
        }
    }


}
