using Octopus.Layers.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Reportes
{
    public partial class FrmSeleccionarPlanilla : Form
    {
        private Action<Entities.Planilla> planilla;
        private List<Entities.Planilla> planillas;
        public FrmSeleccionarPlanilla(Action<Entities.Planilla> planilla)
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
            this.planilla = planilla;
            IniciarLista();
            
        }

        private void LlenarDGV(List<Entities.Planilla> lista)
        {
            dgvPlanilla.Rows.Clear();
            dgvPlanilla.Font = new System.Drawing.Font("Roboto", 12, FontStyle.Regular);
            dgvPlanilla.RowTemplate.Height = 40;

            foreach (Entities.Planilla planilla in lista)
            {
                dgvPlanilla.Rows.Add(planilla.ID, planilla.Nombre);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
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
            this.planillas = lista;
            LlenarDGV(this.planillas);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Entities.Planilla planilla;
            try
            {
                planilla = PlanillaBLL.PlanillaByID((int)dgvPlanilla.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona una planilla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (planilla != null)
            {
                this.planilla.Invoke(planilla);
                this.timer2.Start();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarPlanilla frmbuscarplanilla = new FrmBuscarPlanilla((nombre) => {
                List<Entities.Planilla> filtro;
                filtro = this.planillas.Where((a) => a.Nombre == nombre).ToList();
                if (filtro.Count == 0)
                {
                    MessageBox.Show("No existe la planilla", "Opsss", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRestablecer.PerformClick();
                    return;
                }

                LlenarDGV(filtro);
                btnBuscar.Enabled = false;
                btnRestablecer.Enabled = true;
            });
            frmbuscarplanilla.ShowDialog();

            
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            LlenarDGV(this.planillas);
            btnBuscar.Enabled = true;
            btnRestablecer.Enabled = false;
        }

        private void dgvPlanilla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanilla.SelectedRows.Count > 0)
            {
                this.btnSeleccionar.Enabled = true;
            }
            else
            {
                this.btnSeleccionar.Enabled = false;
            }
        }
    }
}
