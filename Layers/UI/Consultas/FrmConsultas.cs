using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Reflection;
using System.Threading;

namespace Octopus.Layers.UI.Consultas
{
    public partial class FrmConsultas : Form
    {
        private IColaborador colab;
        private List<EncPlanillaColab> encabezados;
        public FrmConsultas(IColaborador colaborador)
        {
            InitializeComponent();

            this.colab = colaborador;
            IniciarEncabezados();
            this.Opacity = 0;
            timer1.Start();
        }
        public void IniciarEncabezados()
        {
            try
            {
                encabezados = EncPlanillaColabBLL.ListaCompleta();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al llenar la lista", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            encabezados = encabezados.Where((a) => a.ColaboradorID == colab.ID).ToList();
            LlenarDGV(encabezados);
        }
        public void LlenarDGV(List<EncPlanillaColab> lista)
        {
            dgvPlanilla.Font = new System.Drawing.Font("Roboto", 10, FontStyle.Regular);
            dgvPlanilla.Rows.Clear();
            dgvPlanilla.RowTemplate.Height = 50;
            Entities.Planilla planilla;
            
            foreach (EncPlanillaColab enc in lista)
            {
                try
                {
                    planilla = PlanillaBLL.PlanillaByID(enc.PlanillaPagoID);
                }
                catch (Exception)
                {

                    throw;
                }
                dgvPlanilla.Rows.Add(enc.ID, enc.HorasTrabajadas,enc.HorasVacaciones,
                    "₡" + enc.SalarioInicial.ToString("N2"),
                    "₡" + enc.TotalPercep.ToString("N2"),
                    "₡" + enc.TotalDeduc.ToString("N2"), "₡" + enc.Salario.ToString("N2"),
                    "$" + enc.SalarioDolares.ToString("N2"), planilla.FechaPago.Value.ToString("dd/MM/yy"));
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = this.dtpDesde.Value;
            DateTime fechaHasta = this.dtpHasta.Value;
            List<EncPlanillaColab> lista;
            try
            {
                lista = EncPlanillaColabBLL.EncabezadosPorFechas(fechaDesde, fechaHasta);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al llenar la lista", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lista = lista.Where((a) => a.ColaboradorID == this.colab.ID).ToList();

            LlenarDGV(lista);
            this.btnFiltrar.Enabled = false;    
            this.btnRestablecer.Enabled = true;
            this.dtpDesde.Enabled = false;
            this.dtpHasta.Enabled = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            LlenarDGV(this.encabezados);
            this.btnFiltrar.Enabled = true;
            this.btnRestablecer.Enabled = false;
            this.dtpDesde.Enabled = true;
            this.dtpHasta.Enabled = true;
        }

        private void dgvPlanilla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanilla.SelectedRows.Count > 0)
            {
                this.btnReenviar.Enabled = true;
            }
            else
            {
                this.btnReenviar.Enabled = false;
            }
        }

        private async void btnReenviar_Click(object sender, EventArgs e)
        {
            if (dgvPlanilla.SelectedRows.Count > 0)
            {
                EncPlanillaColab enc;
                Entities.Planilla planilla;
                try
                {
                    enc = EncPlanillaColabBLL.EncPlanillaColabByID((int)dgvPlanilla.SelectedRows[0].Cells[0].Value);
                    planilla = PlanillaBLL.PlanillaByID(enc.PlanillaPagoID);
                }
                catch (Exception)
                {

                    throw;
                }
                this.btnFiltrar.Enabled = false;
                this.btnCerrar.Enabled = false;
                this.btnReenviar.Enabled = false;
                this.btnRestablecer.Enabled = false;
                this.dtpDesde.Enabled = false;
                this.dtpHasta.Enabled = false;

                await HacerComprobante(enc, planilla);
                
            }
        }

        private async Task HacerComprobante(EncPlanillaColab enc, Entities.Planilla planilla)
        {
            
            try
            {
                // Creamos un escritor para el documento PDF
                string outputFile = Application.StartupPath + @"\Documents\Comprobante" + planilla.Nombre + " " + colab.ID + ".pdf";
                Document doc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputFile, FileMode.Create));
                doc.Open();

                // Fonts
                iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                iTextSharp.text.Font apellidosFont = FontFactory.GetFont(FontFactory.HELVETICA, 24);
                iTextSharp.text.Font nombresFont = FontFactory.GetFont(FontFactory.HELVETICA, 18);
                iTextSharp.text.Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                // Titulos
                Paragraph titulo = new Paragraph("Comprobante de Pago " + planilla.Nombre, tituloFont);
                titulo.Alignment = Element.ALIGN_CENTER;

                doc.Add(titulo);
                doc.Add(new Chunk("\n"));

                //colaborador
                Paragraph nombreColaborador = new Paragraph("Colaborador:", normalFont);
                nombreColaborador.Alignment = Element.ALIGN_LEFT;
                doc.Add(nombreColaborador);

                Paragraph apellidos = new Paragraph(" " + colab.Apellidos + "\n", apellidosFont);
                apellidos.Alignment = Element.ALIGN_LEFT;
                doc.Add(apellidos);

                Paragraph nombres = new Paragraph(" " + colab.Nombres + "\n", nombresFont);
                nombres.Alignment = Element.ALIGN_LEFT;
                doc.Add(nombres);

                doc.Add(new Chunk("\n"));

                Paragraph horas = new Paragraph("Horas trabajadas: " + enc.HorasTrabajadas + ", horas de vacaciones: " + enc.HorasVacaciones + "\n",
                    normalFont);
                horas.Alignment = Element.ALIGN_LEFT;
                doc.Add(horas);

                Paragraph salIni = new Paragraph("Salario inicial: ₡" + enc.SalarioInicial.ToString("N2") + " colones\n",
                    normalFont);
                salIni.Alignment = Element.ALIGN_LEFT;
                doc.Add(salIni);

                Paragraph percep = new Paragraph("Total de percepciones: ₡" + enc.TotalPercep.ToString("N2") + " colones\n",
                    normalFont);
                percep.Alignment = Element.ALIGN_LEFT;
                doc.Add(percep);

                Paragraph deduc = new Paragraph("Total de deducciones: ₡" + enc.TotalDeduc.ToString("N2") + " colones\n",
                    normalFont);
                deduc.Alignment = Element.ALIGN_LEFT;
                doc.Add(deduc);

                Paragraph salFin = new Paragraph("Salario final: ₡" + enc.Salario.ToString("N2") + " colones\n",
                    normalFont);
                salFin.Alignment = Element.ALIGN_LEFT;
                doc.Add(salFin);

                Paragraph tCambio = new Paragraph("Tipo de cambio: ₡" + enc.TipoCambio.ToString("N2") + " colones\n",
                    normalFont);
                tCambio.Alignment = Element.ALIGN_LEFT;
                doc.Add(tCambio);

                Paragraph dolares = new Paragraph("Salario en dólares: $" + enc.SalarioDolares.ToString("N2") + "\n",
                    normalFont);
                dolares.Alignment = Element.ALIGN_LEFT;
                doc.Add(dolares);

                //Tabla
                doc.Add(new Chunk("\n"));
                Paragraph det = new Paragraph("Detalles de Deducciones y Percepciones\n",
                    tituloFont);
                det.Alignment = Element.ALIGN_CENTER;
                doc.Add(det);
                doc.Add(new Chunk("\n"));

                PdfPTable table = new PdfPTable(3); // 3 columnas para descripción, tipo y monto
                table.WidthPercentage = 100;

                // Encabezados de tabla
                table.AddCell("Descripción");
                table.AddCell("Tipo");
                table.AddCell("Monto");
                List<DetPlanillaColab> detalles = DetPlanillaColabBLL.SelectByEnc(enc.ID);
                foreach (DetPlanillaColab detalle in detalles)
                {
                    DeducPercep deducPercep;
                    try
                    {
                        deducPercep = DeducPercepBLL.DeducPercepPorID(detalle.DeducPercepID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar datos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    table.AddCell(detalle.Descripcion);
                    table.AddCell(deducPercep.tipo.ToString());
                    table.AddCell(detalle.Monto.ToString("N2") + " colones");
                }
                doc.Add(table);



                //QR
                string data = colab.ID + ", " + colab.Nombres + " " + colab.Apellidos + "\n Salario: ₡" + enc.Salario.ToString("N2") + " colones" +
                    "\nSalario en dólares: $" + enc.SalarioDolares.ToString("N2");

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.M);

                QRCode qrCode = new QRCode(qrCodeData);

                Bitmap qrCodeImage = qrCode.GetGraphic(5);

                MemoryStream ms = new MemoryStream();
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] bitmapData = ms.ToArray();


                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(bitmapData);

                // Centrar la imagen en el documento PDF
                float x = (doc.PageSize.Width - imagen.ScaledWidth) / 2 + 2f * 72f; // Se suman 2 cm a la derecha
                float y = (doc.PageSize.Height - imagen.ScaledHeight) / 2 + 3f * 72f; // Se suman 3 cm arriba

                imagen.SetAbsolutePosition(x, y);

                // Agregamos la imagen al documento
                doc.Add(imagen);

                // Cerramos el documento
                doc.Close();

                string correoDestino = colab.Correo;
                await EnviarCorreoElectronico(correoDestino, outputFile);
                ms.Close();
                IniciarEncabezados();
                this.dtpDesde.Enabled = true;
                this.dtpHasta.Enabled = true;
                this.btnReenviar.Enabled = true;
                this.btnFiltrar.Enabled = true;
                this.btnCerrar.Enabled = true;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al crear el documento PDF", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IniciarEncabezados();
                this.dtpDesde.Enabled = true;
                this.dtpHasta.Enabled = true;
                this.btnReenviar.Enabled = true;
                this.btnFiltrar.Enabled = true;
                this.btnCerrar.Enabled = true;
                return;
            }
            MessageBox.Show("Ya recibió el respectivo comprobante con éxito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private async Task EnviarCorreoElectronico(string destinatarioCorreo, string outputFile)
        {
            string remitenteCorreo = "SoftwareS.AOficial@gmail.com";
            string remitenteContraseña = "tehi maam corn iuej";

            // Asunto y cuerpo del correo electrónico
            string asunto = "Envío de comprobante";
            string cuerpo = "Adjunto encontrarás el archivo comprobante PDF.";

            // Configuración del cliente SMTP
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.Port = 587;
            clienteSmtp.EnableSsl = true;
            clienteSmtp.UseDefaultCredentials = false;
            clienteSmtp.Credentials = new NetworkCredential(remitenteCorreo, remitenteContraseña);

            // Creación del mensaje de correo electrónico
            MailMessage mensaje = new MailMessage(remitenteCorreo, destinatarioCorreo, asunto, cuerpo);

            mensaje.Attachments.Add(new Attachment(outputFile));

            try
            {
                // Envío del correo electrónico
                await clienteSmtp.SendMailAsync(mensaje);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // Liberar recursos
                mensaje.Dispose();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }
    }
}
