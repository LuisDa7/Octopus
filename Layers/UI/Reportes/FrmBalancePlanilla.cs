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
using System.Windows.Forms.DataVisualization.Charting;

namespace Octopus.Layers.UI.Reportes
{
    public partial class FrmBalancePlanilla : Form
    {
        private List<Entities.Planilla> listaTodas;
        public FrmBalancePlanilla()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
            IniciarLista();
            ActualizarChart();
        }

        private void IniciarLista()
        {
            List<Entities.Planilla> lista;
            try
            {
                lista = PlanillaBLL.PlanillaAll();
            }
            catch (Exception)
            {
                throw;
            }
            listaTodas = lista;
            LlenarDGV(listaTodas);
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dtpDesde.Value;
            DateTime fechaHasta = this.dtpHasta.Value;
            List<Entities.Planilla> lista = this.listaTodas;
            lista = lista.Where((a) => a.FechaPago.Value.Date >= fechaDesde.Date &&
            a.FechaPago.Value.Date <= fechaHasta.Date).ToList();

            LlenarDGV(lista);
            ActualizarChart();
        }

        private void LlenarDGV(List<Entities.Planilla> lista)
        {
            dgvPlanilla.Font = new System.Drawing.Font("Roboto", 12, FontStyle.Regular);
            dgvPlanilla.RowTemplate.Height = 30;
            dgvPlanilla.Rows.Clear();

            foreach (Entities.Planilla planilla in lista)
            {
                dgvPlanilla.Rows.Add(planilla.ID,planilla.Nombre, planilla.FechaPago.Value.ToString("dd/MM/yy"));
            }
        }

        private void ActualizarChart()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            chrGrafico.Series.Clear();
            Series serie = new Series();

            serie.ChartType = SeriesChartType.Pie;
            chrGrafico.Series.Add(serie);

            List<EncPlanillaColab> encTodos;
            List<EncPlanillaColab> filtro;
            List<EncPlanillaColab> encSeleccionados = new List<EncPlanillaColab>();
            List<int> ids = new List<int>();
            try
            {
                encTodos = EncPlanillaColabBLL.ListaCompleta();
            }
            catch (Exception)
            {
                throw;
            }
            //recorre las planillas
            foreach (DataGridViewRow row in dgvPlanilla.Rows)
            {
                int id = (int)row.Cells[0].Value;
                //del todos los enc selecciona los de la planilla actual
                filtro = encTodos.Where((a) => a.PlanillaPagoID == id).ToList();
                //agrega los seleccionados
                foreach (EncPlanillaColab enc in filtro)
                {
                    encSeleccionados.Add(enc);
                }
            }

            double totalDeduc = 0;
            double totalPercep = 0;
            double totalSalarios = 0;
            foreach (EncPlanillaColab item in encSeleccionados)
            {
                totalDeduc += item.TotalDeduc;
                totalPercep += item.TotalPercep;
                totalSalarios += item.Salario;
            }

            chrGrafico.Series[0].Points.AddXY("Total Deducciones \n₡" + totalDeduc.ToString("N2"), totalDeduc);
            chrGrafico.Series[0].Points.AddXY("Total Percepciones \n₡" + totalPercep.ToString("N2"), totalPercep);
            chrGrafico.Series[0].Points.AddXY("Total Salarios \n₡" + totalSalarios.ToString("N2"), totalSalarios);

            chrGrafico.Series[0]["PieLabelStyle"] = "Outside";

            ChartArea chartArea = chrGrafico.ChartAreas[0];

            // Aumentar el tamaño del área del gráfico
            chartArea.Position.Width = 100; 
            chartArea.Position.Height = 100;

            // Actualizar el gráfico
            chrGrafico.DataBind();

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void btnCerrarMant_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
