using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using Octopus.Layers.UI.Mantenimiento.Colaborador;
using System;
using System.Collections;
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
    public partial class FrmSeleccionarColab : Form
    {
        private Action<IColaborador> action;
        private IColaborador colaborador;
        public FrmSeleccionarColab( Action<IColaborador> action)
        {
            InitializeComponent();
            this.Opacity = 0;
            this.action = action;
            LlenarTabla();
            timer1.Start();
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
            this.timer2.Start();
        }

        public void LlenarTabla()
        {
            dgvTabla.Rows.Clear();
            List<IColaborador> lista = new List<IColaborador>();
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
                }
                else if (item is ColaboradorRegular)
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

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvTabla.SelectedRows[0].Cells[1].Value);
                colaborador = ColaboradorBLL.ColaboradorPorID(id);
               
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        { 
            action?.Invoke(colaborador);
            timer2.Start(); 
        }
    }
}
