using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using Octopus.Layers.UI.Mantenimiento.Colaborador;
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

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmColaborador : Form
    {
        private string id;
        private List<IColaborador> lista;
        public FrmColaborador()
        {
            InitializeComponent();
            LlenarTabla();
            this.Opacity= 0;
            this.timer1.Start();
            btnAgregar.Focus();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarColab frmAgregarColab = new FrmAgregarColab();
            frmAgregarColab.Opacity = 0;
            frmAgregarColab.ShowDialog();
            LlenarTabla();
        }

        public void LlenarTabla()
        {
            dgvTabla.Rows.Clear();
            lista = new List<IColaborador>();
            try
            {
                lista = ColaboradorBLL.ListaCompleta();
            }
            catch (Exception)
            {
                MessageBox.Show("No se llenó la tabla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvTabla.RowTemplate.Height = 100;

            foreach (IColaborador item in lista)
            {
                string nombre = item.Nombres + " " + item.Apellidos;
                string rol = "";
                if (item is Supervisor)
                {
                    rol = "Supervisor";
                }else if (item is ColaboradorRegular)
                {
                    rol = "Colaborador";
                }
                else
                {
                    rol = "Administrador";
                }

                byte[] imageBytes = item.Fotografia;
                Image imagen = Image.FromStream(new MemoryStream(imageBytes));
                Bitmap bitmap = new Bitmap(imagen);
                dgvTabla.Rows.Add(bitmap, item.ID, nombre, rol);
                
            }

            
        }

        private void dgvTabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                id = dgvTabla.Rows[e.RowIndex].Cells[1].Value.ToString();
            }   
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmModificarColab frmModificarColab = new FrmModificarColab();
            frmModificarColab.setID(id);
            frmModificarColab.ShowDialog();
            LlenarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            IColaborador colab = null ;
            if (dgvTabla.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.id); 
                var result = MessageBox.Show("Seguro que desea eliminar el colaborador "+id,"Eliminar",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        colab = ColaboradorBLL.ColaboradorPorID(id);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    colab.estado = Enum.Estado.Inactivo;
                    try
                    {
                        ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
                        colaboradorBLL.UpdateColaborador(colab);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show("El colaborador ahora está inactivo", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                LlenarTabla();
            }
            

        }

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {
                id = dgvTabla.SelectedRows[0].Cells[1].Value.ToString();
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarColaborador frmBuscarColab = new FrmBuscarColaborador(this, (colaborador) =>
            {
                this.dgvTabla.Rows.Clear();
                string nombre = colaborador.Nombres + " " + colaborador.Apellidos;
                string rol = "";
                if (colaborador is Supervisor)
                {
                    rol = "Supervisor";
                }
                else if (colaborador is ColaboradorRegular)
                {
                    rol = "Colaborador";
                }
                else
                {
                    rol = "Administrador";
                }

                byte[] imageBytes = colaborador.Fotografia;
                Image imagen = Image.FromStream(new MemoryStream(imageBytes));
                Bitmap bitmap = new Bitmap(imagen);
                dgvTabla.Rows.Add(bitmap, colaborador.ID, nombre, rol);
                this.btnRestablecer.Enabled = true;

            });
            frmBuscarColab.ShowDialog();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            this.btnRestablecer.Enabled = false;
            LlenarTabla();
        }
    }
}
