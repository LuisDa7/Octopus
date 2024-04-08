using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Planilla
{
    public partial class FrmPlanilla : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private List<Entities.Marcas> listaMarcas;
        private List<EncPlanillaColab> encabezados;
        private Action<List<EncPlanillaColab>> Callback;
        private Action<Entities.Planilla> Callback2;
        private bool bandera;
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmPlanilla(List<Entities.Marcas> listaMarcas, List<EncPlanillaColab> encabezados, 
            Action<List<EncPlanillaColab>> Callback, Action<Entities.Planilla> Callback2)
        {
            InitializeComponent();
            this.Opacity = 0;
            dgvPlanilla.Font = new Font("Roboto", 10, FontStyle.Regular);
            timer1.Start();
            this.listaMarcas = listaMarcas;
            fechaInicio = listaMarcas[0].Fecha;
            fechaFinal = listaMarcas[listaMarcas.Count - 1].Fecha;
            this.encabezados = encabezados;
            LlenarDGV();
            this.Callback = Callback;
            this.Callback2 = Callback2;
        }

       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string nombrePlanilla = fechaInicio.Day.ToString() + fechaInicio.ToString("MMMM") + 
                fechaFinal.Day.ToString()+ fechaFinal.ToString("MMMM");

            Entities.Planilla planilla = new Entities.Planilla()
            {
                Nombre = nombrePlanilla,
                FechaDesde = fechaInicio,
                FechaHasta = fechaFinal,
                FechaPago = fechaFinal,
                estado = Enum.Estado.PorEnviar
            };

            try
            {
                PlanillaBLL planillaBLL = new PlanillaBLL();
                planillaBLL.Insert(planilla);
                _MyLogControlEventos.Info("Se creó una planilla");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar la planilla", "Cuidado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _MyLogControlEventos.Info("Error al crear una planilla");
                return;
            }
            try
            {
                planilla.ID = PlanillaBLL.GetID();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar ID a la planilla", "Cuidado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            planilla.CrearFacturas(listaMarcas);
            encabezados = planilla.encabezados;
            LlenarDGV();
            Callback?.Invoke(encabezados);
            Callback2?.Invoke(planilla);
            this.btnCalcular.Enabled = false;
            this.btnOrdenar.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void LlenarDGV()
        {
            dgvPlanilla.Rows.Clear();
            foreach (EncPlanillaColab enc in encabezados)
            {
                IColaborador colaborador;
                try
                {
                    colaborador = ColaboradorBLL.ColaboradorPorID(enc.ColaboradorID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al cargar la tabla", "Cuidado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string colaboradorNombre = colaborador.Nombres + " " + colaborador.Apellidos;
                dgvPlanilla.Rows.Add(colaboradorNombre,enc.HorasTrabajadas ,enc.HorasVacaciones,
                    "₡" + enc.SalarioInicial.ToString("N2") ,
                    "₡" + enc.TotalPercep.ToString("N2"),
                    "₡" + enc.TotalDeduc.ToString("N2"), "₡" + enc.Salario.ToString("N2"),
                    "₡" + enc.TipoCambio, "$" + enc.SalarioDolares.ToString("N2"));
            }
        }

        private void FrmPlanilla_Load(object sender, EventArgs e)
        {
            this.lblFechaDesde.Text = "Fecha desde "+fechaInicio.ToString("dd-MM-yyyy");
            this.lblFechaHasta.Text = "Fecha hasta "+fechaFinal.ToString("dd-MM-yyyy");
            if (encabezados.Count > 0)
            {
                this.btnCalcular.Enabled = false;
                this.btnOrdenar.Enabled = true;
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                this.encabezados = encabezados.OrderBy((a) => a.Salario).ToList();
                bandera = false;
            }
            else
            {
                this.encabezados = encabezados.OrderByDescending((a) => a.Salario).ToList();
                bandera = true;
            }
            LlenarDGV();
        }
    }
}
