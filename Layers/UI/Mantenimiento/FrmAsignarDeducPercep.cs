using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using Octopus.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmAsignarDeducPercep : Form
    {
        private IColaborador colaborador;
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmAsignarDeducPercep()
        {
            InitializeComponent();
            this.Opacity = 0;
            dgvTodas.Font = new Font("Roboto", 10, FontStyle.Regular);
            dgvPercep.Font = new Font("Roboto", 10, FontStyle.Regular);
            dgvDeduc.Font = new Font("Roboto", 10, FontStyle.Regular);
            timer1.Start();
        }


        private void pbFotografia_Click(object sender, EventArgs e)
        {
            FrmSeleccionarColab frmSeleccionarColab = new FrmSeleccionarColab( (colaborador) => 
            {
                this.colaborador = colaborador;
                this.lblNombre.Text = colaborador.Nombres;
                this.lblApellidos.Text = colaborador.Apellidos;
                
                byte[] imageBytes = colaborador.Fotografia;
                Image imagen = Image.FromStream(new MemoryStream(imageBytes));
                Bitmap bitmap = new Bitmap(imagen);
                pbFotografia.Image = bitmap;

                LlenarDGVs();
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = false;


            });
            frmSeleccionarColab.ShowDialog();
        }

        private void LlenarDGVs()
        {
            dgvTodas.ClearSelection();

            dgvTodas.DataSource = null;

            dgvTodas.Rows.Clear();
            dgvPercep.Rows.Clear();
            dgvDeduc.Rows.Clear();
            List<DeducPercep> listaCompleta;
            try
            {
                listaCompleta = DeducPercepBLL.ListaCompleta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            dgvTodas.RowTemplate.Height = 50;
            dgvDeduc.RowTemplate.Height = 50;
            dgvPercep.RowTemplate.Height = 50;

            List<DeducPercepColab> listaDeduc;
            List<DeducPercepColab> listaPercep;
            try
            {
                listaDeduc = DeducPercepColabBLL.ListaDeducColab(colaborador.ID);
                listaPercep = DeducPercepColabBLL.ListaPercepColab(colaborador.ID);
            }
            catch (Exception)
            {
                throw;
            }

            foreach (DeducPercepColab deduc in listaDeduc)
            {
                listaCompleta.RemoveAll((a) => a.ID == deduc.DeducPercepID);
            }
            foreach (DeducPercepColab percep in listaPercep)
            {
                listaCompleta.RemoveAll((a) => a.ID == percep.DeducPercepID);
            }

            dgvTodas.DataSource = listaCompleta;

            foreach (DeducPercepColab item in listaDeduc)
            {
                DeducPercep deduc;
                try
                {
                    deduc = DeducPercepDAL.DeducPercepPorID(item.DeducPercepID);   
                }
                catch (Exception)
                {

                    throw;
                }
                dgvDeduc.Rows.Add(deduc.Nombre, deduc.tipoValor.ToString(),deduc.Valor,item.prioridad.ToString());
            }

            foreach (DeducPercepColab item in listaPercep)
            {
                DeducPercep percep;
                try
                {
                    percep = DeducPercepDAL.DeducPercepPorID(item.DeducPercepID);
                }
                catch (Exception)
                {

                    throw;
                }
                dgvPercep.Rows.Add(percep.Nombre, percep.tipoValor.ToString(), percep.Valor, item.prioridad);
            }


            foreach (DataGridViewRow row in dgvDeduc.Rows)
            {
                string prioridad = row.Cells[3].Value.ToString();
                if (prioridad == "Baja")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(92, 219, 126);
                }
                else if (prioridad == "Media")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 208, 92);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 92, 92);
                }
            }

            foreach (DataGridViewRow row in dgvPercep.Rows)
            {
                string prioridad = row.Cells[3].Value.ToString();
                if (prioridad == "Baja")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(92, 219, 126);
                }
                else if (prioridad == "Media")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 208, 92);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(219, 92, 92);
                }
            }
            dgvDeduc.ClearSelection();
            dgvPercep.ClearSelection();
            dgvTodas.Rows[0].Selected = true;
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

        private void dgvPercep_SelectionChanged(object sender, EventArgs e)
        {
            dgvDeduc.ClearSelection();
            dgvTodas.ClearSelection();
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            if (dgvPercep.SelectedRows.Count == 0 )
            {
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
            }
        }

        private void dgvDeduc_SelectionChanged(object sender, EventArgs e)
        {
            dgvPercep.ClearSelection();
            dgvTodas.ClearSelection();
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            if (dgvDeduc.SelectedRows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
            }
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvTodas.SelectedRows.Count > 0)
            {
                DeducPercep dp = dgvTodas.SelectedRows[0].DataBoundItem as DeducPercep;
                Estado estado = Estado.Activo;
                FrmPrioridad frmPrioridad = new FrmPrioridad(this, (prioridad) =>
                {
                    DeducPercepColabFactory deducPercepColabFactory = new DeducPercepColabFactory();
                    DeducPercepColab dpc = deducPercepColabFactory.Crear
                    (colaborador.ID, dp.ID, prioridad, estado);
                    try
                    {
                        DeducPercepColabBLL deducPercepColabBLL = new DeducPercepColabBLL();
                        deducPercepColabBLL.Insert(dpc);
                        _MyLogControlEventos.Info("Se insertó un deducpercepcolab");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lo sentimos, no se completó la acción correctamente", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        _MyLogControlEventos.Error("Se eliminó un deducpercepcolab");
                        return;
                    }

                });
                frmPrioridad.ShowDialog();

                LlenarDGVs();

            }
        }

        private void dgvTodas_SelectionChanged(object sender, EventArgs e)
        {
            dgvDeduc.ClearSelection();
            dgvPercep.ClearSelection();
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            if (dgvTodas.SelectedRows.Count == 0)
            {
                btnEliminar.Enabled = false;
                btnAgregar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPercep.SelectedRows.Count > 0)
            {
                string nombre = dgvPercep.SelectedRows[0].Cells[0].Value.ToString();
                DeducPercep deducPercep ;
                try
                {
                    deducPercep = DeducPercepBLL.DeducPercepPorNombre(nombre);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lo sentimos, no se completó la acción correctamente", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    DeducPercepColabBLL deducPercepColabBLL = new DeducPercepColabBLL();
                    deducPercepColabBLL.Delete(colaborador.ID, deducPercep.ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lo sentimos, no se completó la acción correctamente", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LlenarDGVs();
            }
            else if (dgvDeduc.SelectedRows.Count > 0)
            {
                string nombre = dgvDeduc.SelectedRows[0].Cells[0].Value.ToString();
                DeducPercep deducPercep;
                try
                {
                    deducPercep = DeducPercepBLL.DeducPercepPorNombre(nombre);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lo sentimos, no se completó la acción correctamente", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    DeducPercepColabBLL deducPercepColabBLL = new DeducPercepColabBLL();
                    deducPercepColabBLL.Delete(colaborador.ID, deducPercep.ID);
                    _MyLogControlEventos.Info("Se eliminó una deducpercepcolab");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lo sentimos, no se completó la acción correctamente", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _MyLogControlEventos.Error("No se eliminó un deducpercepcolab");
                    return;
                }
                LlenarDGVs();
            }
        }

        private void FrmAsignarDeducPercep_Click(object sender, EventArgs e)
        {
            dgvDeduc.ClearSelection();
            dgvTodas.ClearSelection();
            dgvPercep.ClearSelection();
        }
    }
}
