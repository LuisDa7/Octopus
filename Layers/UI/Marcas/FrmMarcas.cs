using Octopus.Interfaces;
using Octopus.Layers.BLL;
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

namespace Octopus.Layers.UI.Marcas
{
    public partial class FrmMarcas : Form
    {
        List<Entities.Marcas> marcas = new List<Entities.Marcas>();
        Action<List<Entities.Marcas>> action;
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmMarcas(List<Entities.Marcas> lista, Action<List<Entities.Marcas>> action)
        {
            InitializeComponent();
            Opacity = 0;
            CargarLista(lista);
            this.action = action;
            timer1.Start();
        }

        private void CargarLista(List<Entities.Marcas> lista)
        {
            if (lista.Count > 0)
            {
                LlenarDGV(lista);
                this.btnCargar.Enabled = false;
                this.btnBorrar.Enabled = true;
                this.lblCargadas.Visible = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
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
                this.Opacity -= 0.05;
            }
            else
            {
                this.Opacity = 0;
                this.timer2.Stop();
                this.Close();
            }
        }

        private void btnCerrarMant_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ARCHIVO JSON|*.json";
            ofd.InitialDirectory = Application.StartupPath + @"\JSON";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    marcas = Entities.Marcas.Cargar(ofd.FileName);
                    _MyLogControlEventos.Info("Se cargaron las marcas");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se realizó la acción de cargar correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _MyLogControlEventos.Error("Error al cargar marcas");
                    return;
                }
                LlenarDGV(marcas);
                if (Entities.Marcas.HayVacios(marcas))
                {
                    this.lblCorregir.Visible = true;
                    this.btnCorregir.Enabled = true;
                    this.btnCerrar.Enabled = false;
                }
                else
                {
                    List<Entities.Marcas> marcasCorregidas;
                    List<Entities.Marcas> marcasHorasListas;
                    marcasCorregidas = Entities.Marcas.CorregirAusencias(marcas);
                    marcasHorasListas = Entities.Marcas.CorregirHoras(marcasCorregidas);
                    LlenarDGV(marcasHorasListas);
                    this.btnCorregir.Enabled = false;
                    this.lblCargadas.Visible = true;
                    action?.Invoke(marcasHorasListas);
                }
                this.btnBorrar.Enabled = true;
                this.btnCargar.Enabled = false;
                Cursor.Current = Cursors.Default;
            }
        }

        private void LlenarDGV(List<Entities.Marcas> marcas)
        {
            dgvMarcas.Rows.Clear();
            List<IColaborador> colaboradores;

            try
            {
                colaboradores = ColaboradorBLL.ListaCompleta();
            }
            catch (Exception)
            {
                MessageBox.Show("No se realizó la acción de cargar colaborador correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Entities.Marcas item in marcas)
            {
                IColaborador colaborador = colaboradores.Where((a) => a.ID.Equals(item.ID)).FirstOrDefault();
                if (colaborador != null)
                {
                    string fechaEntrada = (item.Entrada == null) ? "No hay fecha" : item.Entrada.Value.ToString("hh:mm tt"); ;
                    string fechaSalida = (item.Salida == null) ? "No hay fecha" : item.Salida.Value.ToString("hh:mm tt"); ;

                    dgvMarcas.Rows.Add(colaborador.ToString(), item.Fecha.ToString("dd/MM/yyyy"),
                        fechaEntrada, fechaSalida, item.CantHoras);

                    if (fechaEntrada == "No hay fecha" || fechaSalida == "No hay fecha")
                    {
                        dgvMarcas.Rows[dgvMarcas.Rows.Count - 1].DefaultCellStyle.BackColor = Color.FromArgb(219, 92, 92);
                    }
                }
                
            }
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            List<Entities.Marcas> marcasCorregidas;
            List<Entities.Marcas> marcasHorasListas;
            marcasCorregidas = Entities.Marcas.CorregirAusencias(marcas);
            marcasHorasListas = Entities.Marcas.CorregirHoras(marcasCorregidas);
            LlenarDGV(marcasHorasListas);
            this.btnCorregir.Enabled = false;
            this.lblCorregir.Visible = false;
            this.lblCargadas.Visible = true;
            this.btnCerrar.Enabled = true;
            action?.Invoke(marcasHorasListas);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.dgvMarcas.Rows.Clear();
            this.marcas.Clear();
            action?.Invoke(marcas);
            this.btnBorrar.Enabled = false;
            this.btnCorregir.Enabled = false;
            this.btnCargar.Enabled = true;
            this.lblCargadas.Visible = false;
            this.btnCerrar.Enabled = true;
        }
    }
}
