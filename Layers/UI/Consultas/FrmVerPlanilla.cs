using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Consultas
{
    public partial class FrmVerPlanilla : Form
    {
        private IColaborador colab;
        private EncPlanillaColab encabezado;
        public FrmVerPlanilla(IColaborador colab, EncPlanillaColab encabezado)
        {
            InitializeComponent();
            dgvDetalles.RowTemplate.Height = 40;
            this.colab = colab;
            this.encabezado = encabezado;
            CargarDatos();
            this.Opacity = 0;
            timer1.Start();
        }

        private void CargarDatos()
        {
            try
            {
                Entities.Planilla planilla = new Entities.Planilla();
                planilla = PlanillaBLL.PlanillaByID(encabezado.PlanillaPagoID);

                this.lblNombrePlanilla.Text = "Planilla del " +planilla.Nombre;
                this.lblColab.Text = "Colaborador " + colab.Nombres + " " + colab.Apellidos;
                this.lblHoras.Text = "Horas trabajadas: " + encabezado.HorasTrabajadas +
                                    ", horas de vacaciones: " + encabezado.HorasVacaciones;
                this.lblSalIni.Text = "₡" + encabezado.SalarioInicial.ToString("N2");
                this.lblTotPercep.Text = "₡" + encabezado.TotalPercep.ToString("N2");
                this.lblTotDeduc.Text = "₡" + encabezado.TotalDeduc.ToString("N2");
                this.lblFinal.Text = "₡" + encabezado.Salario.ToString("N2");
                this.lblTipoCambio.Text = "₡" + encabezado.TipoCambio.ToString("N2");
                this.lblFinalDol.Text = "$" + encabezado.SalarioDolares.ToString("N2");

                List<DetPlanillaColab> detalles = DetPlanillaColabBLL.SelectByEnc(encabezado.ID);
                List<DeducPercep> deducperceps = DeducPercepBLL.ListaCompleta();
                foreach (DetPlanillaColab item in detalles)
                {
                    DeducPercep deducPercep = deducperceps.FirstOrDefault((a) => a.ID == item.DeducPercepID);
                    dgvDetalles.Rows.Add(item.Descripcion, deducPercep.tipo, "₡" + item.Monto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar datos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }
    }
}
