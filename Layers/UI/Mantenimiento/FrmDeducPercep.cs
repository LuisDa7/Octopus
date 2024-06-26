﻿using Octopus.Enum;
using Octopus.Layers.BLL;
using Octopus.Layers.Entities;
using Octopus.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Mantenimiento
{
    public partial class FrmDeducPercep : Form
    {
        private int id;
        private static readonly log4net.ILog _MyLogControlEventos =
                                log4net.LogManager.GetLogger("MyControlEventos");
        public FrmDeducPercep()
        {
            InitializeComponent();
            LlenarDGV();
            this.txtCod.Text = DeducPercepBLL.GetNextIdentityValue("DeducPercep").ToString();
            dgvTabla.RowTemplate.Height = 50;
            this.Opacity= 0;
            timer1.Start();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
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
                timer1.Stop();

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
                timer2.Stop();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCod.Text == "")
            {
                MessageBox.Show("Por favor genere el código.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Por favor digite el nombre.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double valor;
            try
            {
                valor = Double.Parse(this.txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite el valor correctamente.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = this.txtNombre.Text.Trim();
            
            Tipo tipo;
            if (rbtDeduc.Checked)
            {
                tipo = Tipo.Deducciones;
            }
            else
            {
                tipo = Tipo.Percepciones;
            }

            TipoValor tipoValor;
            if (rbtAbsoluto.Checked)
            {
                tipoValor = TipoValor.Absoluto;
            }
            else
            {
                tipoValor = TipoValor.Porcentaje;
            }

            DeducPercepFactory deducPercepFactory = new DeducPercepFactory();
            DeducPercep deducPercep = deducPercepFactory.CrearDeducPercep(id,nombre, tipo, tipoValor, valor);

            
                DeducPercepBLL deducPercepBLL = new DeducPercepBLL();
                deducPercepBLL.Insert(deducPercep);
                LlenarDGV();
                btnLimpiar.PerformClick();
                _MyLogControlEventos.Info("Se agrego una deducpercep");
            }
            catch (Exception)
            {
                MessageBox.Show("No se insertó correctamente.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _MyLogControlEventos.Error("Error: No se insertó deducpercep correctamente ");
            }

        }

        public void LlenarDGV()
        {

            try
            {
                dgvTabla.DataSource = null;
                dgvTabla.Rows.Clear();
                List<DeducPercep> lista = DeducPercepBLL.ListaCompleta();
                dgvTabla.DataSource = lista;

            }
            catch (Exception)
            {
                MessageBox.Show("No se llenó la tabla", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void dgvTabla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {
                DeducPercep dp = dgvTabla.SelectedRows[0].DataBoundItem as DeducPercep;
                id = dp.ID;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
                this.txtCod.Text = id.ToString();
                this.txtNombre.Text = dp.Nombre;
                this.txtValor.Text = dp.Valor.ToString();
                if (dp.tipo == Tipo.Percepciones)
                {
                    this.rbtPercep.Checked = true;
                }
                else
                {
                    this.rbtDeduc.Checked = true;
                }
                if (dp.tipoValor == TipoValor.Absoluto)
                {
                    this.rbtAbsoluto.Checked = true;
                }
                else
                {
                    this.rbtPorcetaje.Checked = true;
                }
                this.btnAgregar.Enabled = false;
            }
        }

        private void FrmDeducPercep_Load(object sender, EventArgs e)
        {
            dgvTabla.ClearSelection();
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCod.Text = "";
            this.txtNombre.Text = "";
            this.txtValor.Text = "";
            rbtPercep.Checked = true;
            rbtPorcetaje.Checked = true;
            this.btnAgregar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.txtCod.Text = DeducPercepBLL.GetNextIdentityValue("DeducPercep").ToString();
            dgvTabla.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DeducPercepBLL deducPercepBLL = new DeducPercepBLL();
                deducPercepBLL.Delete(Convert.ToInt32(this.txtCod.Text));
                _MyLogControlEventos.Info("Se eliminó una deducpercep");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar, asegúrese de borrar las deducciones y percepciones de los clientes", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _MyLogControlEventos.Error("No se eliminó una deducpercep");
                return;
            }

            LlenarDGV();
            btnLimpiar.PerformClick();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCod.Text == "")
            {
                MessageBox.Show("Por favor genere el código.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Por favor digite el nombre.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtValor.Text == "")
            {
                MessageBox.Show("Por favor digite el valor.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = this.txtNombre.Text.Trim();
            double valor = Double.Parse(this.txtValor.Text);
            Tipo tipo;
            if (rbtDeduc.Checked)
            {
                tipo = Tipo.Deducciones;
            }
            else
            {
                tipo = Tipo.Percepciones;
            }

            TipoValor tipoValor;
            if (rbtAbsoluto.Checked)
            {
                tipoValor = TipoValor.Absoluto;
            }
            else
            {
                tipoValor = TipoValor.Porcentaje;
            }

            DeducPercepFactory deducPercepFactory = new DeducPercepFactory();
            DeducPercep deducPercep = deducPercepFactory.CrearDeducPercep(id,nombre, tipo, tipoValor, valor);
            
            
                DeducPercepBLL deducPercepBLL = new DeducPercepBLL();
                deducPercepBLL.Update(deducPercep);
                _MyLogControlEventos.Info("Se actualizó un deducpercep");

            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos, no se actualizó.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _MyLogControlEventos.Error("No se actualizó un deducpercep");
                return;
            }

            LlenarDGV();
            btnLimpiar.PerformClick();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            FrmAsignarDeducPercep frmAsignarDeducPercep = new FrmAsignarDeducPercep();
            frmAsignarDeducPercep.ShowDialog();
        }
    }
}
