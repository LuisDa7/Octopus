using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using Octopus.Layers.UI;
using Octopus.Layers.UI.MenuColab;
using Octopus.Layers.UI.MenuSupervisor;
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

namespace Octopus
{
    public partial class FrmLogin : Form
    {
        private Empresa empresa;
        public FrmLogin()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();

            
        }

        private void chkVerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkVerContra.Checked)
                this.txtContrasena.UseSystemPasswordChar = false;
            else
                this.txtContrasena.UseSystemPasswordChar = true;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    Marcas.GenerarJSONs();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            
            try
            {
                empresa = EmpresaBLL.EmpresaByID(1);
            }
            catch (Exception)
            {

                throw;
            }
            this.pbLogoEmpresa.Image = Image.FromStream(new MemoryStream(empresa.Logo));
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor digite el usuario.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor digite la contraseña.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IColaborador colaborador = ColaboradorBLL.LogIn(this.txtUsuario.Text, this.txtContrasena.Text);
            if (colaborador == null)
            {
                MessageBox.Show("el usuario y la contraseña no concuerdan", "Lo sentimos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (colaborador is Administrador)
            {
                timer2.Start();
                FrmMenuAdmin frmMenuAdmin = new FrmMenuAdmin();
                frmMenuAdmin.SetAdmin((Administrador)colaborador);
                frmMenuAdmin.ShowDialog();
                this.Visible = true;
                timer1.Start();
            }
            else if (colaborador is Supervisor)
            {
                timer2.Start();
                FrmMenuSupervisor frmMenuSupervisor = new FrmMenuSupervisor();
                frmMenuSupervisor.SetSupervisor((Supervisor)colaborador);
                frmMenuSupervisor.ShowDialog();
                this.Visible = true;
                timer1.Start();
            }
            else if(colaborador is ColaboradorRegular)
            {
                timer2.Start();
                FrmMenuColab frmMenuColab = new FrmMenuColab((ColaboradorRegular)colaborador);
                frmMenuColab.ShowDialog();
                this.Visible = true;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("el usuario y la contraseña son correctas, pronto podrás entrar", "Hola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                this.txtUsuario.Text = "";
                this.txtContrasena.Text = "";
                this.Visible = false;
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

        private void timer3_Tick(object sender, EventArgs e)
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

    }
}
