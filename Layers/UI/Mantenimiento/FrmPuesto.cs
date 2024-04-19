using Octopus.Layers.BLL;
using Octopus.Layers.DAL;
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

namespace Octopus.Layers.UI.MenuAdministrador
{
    public partial class FrmPuesto : Form
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmPuesto()
        {
            InitializeComponent();
            dgvTabla.RowTemplate.Height = 40;
            LlenarDGV();
            timer1.Start();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Por favor digite el nombre.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Puesto puesto = new Puesto()
            {
                ID = 0,
                Nombre = txtNombre.Text,
                estado = Enum.Estado.Activo
            };
            PuestoBLL puestoBLL = new PuestoBLL();
            
            try
            {
                puestoBLL.Insert(puesto);
                _MyLogControlEventos.Info("Se insertó un puesto");
                LlenarDGV();
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertó correctamente.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _MyLogControlEventos.Error("No se insertó un puesto");
            }
            

        }

        public void LlenarDGV()
        {

            try
            {
                dgvTabla.DataSource = null;
                dgvTabla.Rows.Clear();
                List<Puesto> lista = PuestoBLL.ListaCompleta();
                dgvTabla.DataSource = lista;
            }
            catch(Exception)
            {
                MessageBox.Show("No se llenó la tabla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            nombre = nombre.Trim();

            if (nombre == "")
            {
                MessageBox.Show("Por favor digite el nombre.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var result = MessageBox.Show("Seguro que desea eliminar el puesto " + nombre + "?"+"\r\n"
                +"primero deberá eliminar todos los colaboradores que tengan este puesto", "Eliminar",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PuestoBLL puestoBLL = new PuestoBLL();
                try
                {
                    puestoBLL.Delete(nombre);
                    _MyLogControlEventos.Info("Se eliminó un puesto");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se eliminó ningún puesto, verifique el nombre y elimine los colaboradores del puesto.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _MyLogControlEventos.Error("No se eliminó un puesto");
                    return;
                }
            }

                MessageBox.Show("Se eliminó el puesto de "+nombre+".", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarDGV();
            

            
        }
    }
}
