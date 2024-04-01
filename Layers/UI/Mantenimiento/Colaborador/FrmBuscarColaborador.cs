using Octopus.Interfaces;
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

namespace Octopus.Layers.UI.Mantenimiento.Colaborador
{
    public partial class FrmBuscarColaborador : Form
    {
        private Action<IColaborador> action;
        public FrmBuscarColaborador(Form parent, Action<IColaborador> action)
        {
            InitializeComponent();
            this.Opacity = 0;
            this.timer1.Start();
            this.action = action;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            IColaborador colaborador = null;
            try
            {
                int id = int.Parse(this.mtbID.Text);

                colaborador = ColaboradorBLL.ColaboradorPorID(id);
                if (colaborador == null)
                {
                    MessageBox.Show("No existe el colaborador", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("format"))
                {
                    MessageBox.Show("El identificador debe ser numérico", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                throw ex;
            }

            action?.Invoke(colaborador);
            timer2.Start();

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
