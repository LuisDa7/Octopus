using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using QRCoder;
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

namespace Octopus.Layers.UI.Reportes
{
    public partial class FrmComprobantes : Form
    {
        private Entities.Planilla planilla;
        public FrmComprobantes()
        {
            InitializeComponent();
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
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FrmSeleccionarPlanilla frmSeleccionarPlanilla = new FrmSeleccionarPlanilla((Entities.Planilla planilla) => 
            { 
                this.planilla = planilla;
                this.lblPlanilla.Text = "Planilla " + planilla.Nombre;
            
            });
            frmSeleccionarPlanilla.ShowDialog();
            if (planilla != null)
            {
                LlenarDGV();
            }
            
        }

        private void LlenarDGV()
        {
            dgvQRs.Rows.Clear();
            dgvQRs.RowTemplate.Height = 100;
            List<EncPlanillaColab> enc;
            try
            {
                enc = EncPlanillaColabBLL.ListaCompleta();
            }
            catch (Exception)
            {
                throw;
            }
            enc = enc.Where((a) => a.PlanillaPagoID == planilla.ID).ToList();
            foreach (EncPlanillaColab item in enc)
            {
                IColaborador colab;
                try
                {
                    colab = ColaboradorBLL.ColaboradorPorID(item.ColaboradorID);
                }
                catch (Exception)
                {
                    throw;
                }

                //QR
                string data = colab.ID + ", " + colab.Nombres + " " + colab.Apellidos + "\n Salario: ₡" + item.Salario.ToString("N2") + " colones" +
                    "\nSalario en dólares: $" + item.SalarioDolares.ToString("N2");

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.M);

                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap qrCodeImage = qrCode.GetGraphic(2);

                Image imagenQR = qrCodeImage as Image;

                dgvQRs.Rows.Add(colab.ID, imagenQR);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
