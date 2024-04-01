using Octopus.Enum;
using Octopus.Interfaces;
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

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmPrioridad : Form
    {
        Action<Prioridad> action;
        public FrmPrioridad(Form parent, Action<Prioridad> action)
        {
            InitializeComponent();
            this.Opacity= 0;
            this.timer1.Start();
            this.action = action;
        }

        private void FrmPrioridad_Load(object sender, EventArgs e)
        {
            this.cmbPrioridad.Items.Add(Prioridad.Baja.ToString());
            this.cmbPrioridad.Items.Add(Prioridad.Media.ToString());
            this.cmbPrioridad.Items.Add(Prioridad.Alta.ToString());
            this.cmbPrioridad.SelectedIndex = 0;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            Prioridad prioridadSalida;
            string prioridad = cmbPrioridad.SelectedItem.ToString();
            if (prioridad == "Alta")
            {
                prioridadSalida = Prioridad.Alta;
            }
            else if (prioridad == "Media")
            {
                prioridadSalida = Prioridad.Media;
            }
            else
            {
                prioridadSalida = Prioridad.Baja;
            }
            action?.Invoke(prioridadSalida);
            this.timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.15;
            }
            else
            {
                this.Opacity = 1;
                this.timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.15;
            }
            else
            {
                this.Opacity = 0;
                this.timer2.Stop();
                this.Close();
            }
        }
    }
}
