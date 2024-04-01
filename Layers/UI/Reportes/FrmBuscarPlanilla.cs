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
    public partial class FrmBuscarPlanilla : Form
    {
        private Action<string> nombre;
        public FrmBuscarPlanilla(Action<string> nombre)
        {
            InitializeComponent();
            this.Opacity = 0;
            timer1.Start();
            this.nombre = nombre;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre de la planilla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            nombre.Invoke(txtNombre.Text);
            timer2.Start();
        }
    }
}
