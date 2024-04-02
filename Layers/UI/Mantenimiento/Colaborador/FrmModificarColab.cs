using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using Octopus.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.UI.Mantenimiento.Colaborador
{
    public partial class FrmModificarColab : Form
    {
        IColaborador colaborador;
        byte[] imagen;
        string id;
        public FrmModificarColab()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.timer1.Start();
            LlenarCombos();
            this.mtbID.ReadOnly= true;

        }

        private void LlenarCombos()
        {
            List<Departamento> departamentos = DepartamentoBLL.ListaCompleta();
            if (departamentos.LongCount() > 0)
            {
                cmbDepartamento.DataSource = departamentos;
                cmbDepartamento.DisplayMember = "Nombre";
                cmbDepartamento.SelectedIndex = 0;
            }

            cmbRol.Items.Add(Rol.Administrador);
            cmbRol.Items.Add(Rol.Colaborador);
            cmbRol.Items.Add(Rol.Supervisor);
            cmbRol.SelectedIndex = 0;

            List<Puesto> puestos = PuestoBLL.ListaCompleta();

            if (puestos.LongCount() > 0)
            {
                cmbPuesto.DataSource = puestos;
                cmbPuesto.DisplayMember = "Nombre";
                cmbPuesto.SelectedIndex = 0;
            }

            List<Supervisor> supervisor = ColaboradorBLL.ListaSupervisores();

            if (supervisor.LongCount() > 0)
            {
                foreach (Supervisor item in supervisor)
                {
                    cmbSupervisor.Items.Add(item);
                }
                cmbSupervisor.SelectedIndex = 0;
            }

        }
        public void setID(string id)
        {
            this.id = id;
        }
        private void CargarColab()
        {
            
            try
            {
                int id = int.Parse(this.id);
                colaborador = ColaboradorBLL.ColaboradorPorID(id);
            }
            catch (Exception)
            {
                MessageBox.Show("No se cargó el colaborador", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            byte[] imageBytes = colaborador.Fotografia;
            this.imagen = imageBytes;
            Image imagen = Image.FromStream(new MemoryStream(imageBytes));
            pbFotografia.Image = imagen;

            this.txtNombres.Text = colaborador.Nombres;
            this.txtApellidos.Text = colaborador.Apellidos;
            this.mtbID.Text = colaborador.ID.ToString();
            this.txtCorreo.Text = colaborador.Correo;
            this.txtIban.Text = colaborador.CuentaIBAN;
            this.txtSalarioXHora.Text = colaborador.SalarioHora.ToString();
            this.rtbDireccion.Text = colaborador.Direccion;
            this.txtUsuario.Text = colaborador.Usuario;
            this.txtContrasena.Text = colaborador.Contrasena;

            Departamento departamento = DepartamentoBLL.DepartamentoPorID(colaborador.departamento);
            int indiceDep = this.cmbDepartamento.FindString(departamento.Nombre);
            this.cmbDepartamento.SelectedIndex = indiceDep;

            int indiceRol;
            if (colaborador is Supervisor)
            {
                indiceRol = this.cmbRol.FindString("Supervisor");
            }
            else if (colaborador is Administrador)
            {
                indiceRol = this.cmbRol.FindString("Administrador");
            }
            else
            {
                indiceRol = this.cmbRol.FindString("Colaborador");
            }

            cmbRol.SelectedIndex = indiceRol;
            cmbRol_SelectedIndexChanged(this, EventArgs.Empty);
            int indicePuesto;
            Puesto puesto = PuestoBLL.PuestoPorID(colaborador.puesto);
            indicePuesto = this.cmbPuesto.FindString(puesto.Nombre);
            this.cmbPuesto.SelectedIndex = indicePuesto;
            dtpFechaNacim.Value = colaborador.Nacimiento;
            int indiceSuper;
            if (colaborador.supervisor == -1)
            {
                indiceSuper = this.cmbSupervisor.FindString("Ninguno");
            }
            else
            {
                Supervisor supervisor =(Supervisor) ColaboradorBLL.ColaboradorPorID(colaborador.supervisor);
                indiceSuper = this.cmbSupervisor.FindString(supervisor.ToString());
            }
            this.cmbSupervisor.SelectedIndex = indiceSuper;

            

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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Imagen JPG|*.jpg";
                openFileDialog.InitialDirectory = Application.StartupPath;
                var result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.imagen = ImageToByteArray(openFileDialog.FileName);
                    MemoryStream ms = new MemoryStream(this.imagen);
                    Image imagen = Image.FromStream(ms);
                    pbFotografia.Image = imagen;

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public byte[] ImageToByteArray(string imagePath)
        {
            byte[] imageBytes;
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imageBytes = br.ReadBytes((int)fs.Length);
                }
            }
            return imageBytes;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void FrmModificarColab_Load(object sender, EventArgs e)
        {
            CargarColab();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = cmbRol.SelectedItem.ToString();
            if (result == "Supervisor")
            {
                cmbSupervisor.Items.Add("Ninguno");
            }
            else if (result != "Ninguno")
            {
                cmbSupervisor.Items.Remove("Ninguno");
            }
        }

        private bool IsEmailValido(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (imagen == null)
            {
                MessageBox.Show("Por favor seleccione la foto de perfil.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFoto.Focus();
                return;
            }

            if (txtNombres.Text == "")
            {
                MessageBox.Show("Por favor digite los nombres.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return;
            }

            if (txtApellidos.Text == "")
            {
                MessageBox.Show("Por favor digite los apellidos.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor digite el correo.", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }


            if (txtIban.Text == "")
            {
                MessageBox.Show("Por favor digite la cuenta IBAN", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIban.Focus();
                return;
            }

            if (rtbDireccion.Text == "")
            {
                MessageBox.Show("Por favor digite la dirección", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbDireccion.Focus();
                return;
            }

            double monto;
            try
            {
                monto = Convert.ToDouble(txtSalarioXHora.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor digite el salario por hora correctamente", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioXHora.Focus();
                return;
            }

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor digite el usuario", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor digite la contraseña", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }
            if (txtContrasena.Text.Length != 7)
            {
                MessageBox.Show("La contraseña debe ser de 7 dígitos", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }

            if (cmbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el departamento", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartamento.Focus();
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el rol", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRol.Focus();
                return;
            }

            if (cmbPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el puesto", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPuesto.Focus();
                return;
            }

            if (cmbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el departamento", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartamento.Focus();
                return;
            }

            int id = Convert.ToInt32(mtbID.Text.Trim());
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (!IsEmailValido(correo))
            {
                MessageBox.Show("Dirección de correo electrónico no válida", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }
            string cuentaIban = txtIban.Text.Trim();
            string direccion = rtbDireccion.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contra = txtContrasena.Text.Trim();
            Puesto puesto = cmbPuesto.SelectedItem as Puesto;
            int puestoID = puesto.ID;
            Departamento departamento = cmbDepartamento.SelectedItem as Departamento;
            int departamentoID = departamento.ID;
            int supervisorID;
            if (cmbSupervisor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el supervisor", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupervisor.Focus();
                return;
            }
            string supervisorCmb = this.cmbSupervisor.SelectedItem.ToString();
            if (supervisorCmb == "Ninguno")
            {
                supervisorID = -1;
            }
            else
            {
                Supervisor supervisor = (Supervisor)cmbSupervisor.SelectedItem;
                supervisorID = supervisor.ID;
            }

            Rol rol = (Rol)cmbRol.SelectedItem;

            ColaboradorFactory colaboradorFactory = new ColaboradorFactory();
            IColaborador colaborador = colaboradorFactory.CrearColaborador(id, puestoID, nombres, apellidos, dtpFechaNacim.Value,
                direccion, departamentoID, monto, this.imagen, correo, supervisorID, cuentaIban,
                usuario, contra, rol, DateTime.Now);

            try
            {
                ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
                colaboradorBLL.UpdateColaborador(colaborador);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("edad"))
                {
                    MessageBox.Show("La edad debe ser mayor o igual a 18", "Opsss", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (ex.Message.Contains("IBAN"))
                {
                    MessageBox.Show("La cuenta IBAN ya está registrada", "Opsss", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (ex.Message.Contains("fecha"))
                {
                    MessageBox.Show("La fecha debe indicar que es mayor de edad", "Opsss", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                return;
            }

            MessageBox.Show("Se modificó el colaborador exitosamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            this.Close();
        }
    }
}
