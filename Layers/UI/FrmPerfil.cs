using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
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

namespace Octopus.Layers.UI
{
    public partial class FrmPerfil : Form
    {
        private IColaborador colaborador;
        public FrmPerfil(IColaborador colaborador)
        {
            InitializeComponent();
            this.colaborador = colaborador;
            this.Opacity = 0;
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

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = colaborador.Nombres;
            this.lblApellidos.Text = colaborador.Apellidos;

            byte[] imageBytes = colaborador.Fotografia;
            Image imagen = Image.FromStream(new MemoryStream(imageBytes));
            Bitmap bitmap = new Bitmap(imagen);
            pbFotografia.Image = bitmap;

            Puesto puesto;
            try
            {
                puesto = PuestoBLL.PuestoPorID(colaborador.puesto);
            }
            catch (Exception)
            {

                throw;
            }
            lblPuesto.Text = puesto.Nombre;
            Departamento departamento;
            try
            {
                departamento = DepartamentoBLL.DepartamentoPorID(colaborador.departamento);
            }
            catch (Exception)
            {

                throw;
            }
            LblDep.Text = departamento.Nombre;
            if (colaborador is Administrador)
            {
                lblRol.Text = Rol.Administrador.ToString();
            }
            else if (colaborador is Supervisor)
            {
                lblRol.Text = Rol.Supervisor.ToString();
            }
            else
            {
                lblRol.Text = Rol.Colaborador.ToString();
            }
        }
    }
}
