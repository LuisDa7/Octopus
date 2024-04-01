using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Patterns
{
    internal class ColaboradorFactory
    {
        public IColaborador CrearColaborador(int id, int puesto, string nombres
            , string apellidos, DateTime fechaNacimiento, string direccion, int departamento,
            double salarioHora, byte[] foto, string correo, int supervisor, string cuentaIBAN,
            string usuario, string contrasena, Rol rol, DateTime ingreso)
        {
            IColaborador colaborador;
            switch (rol)
            {
                case Rol.Administrador:
                    colaborador = new Administrador();
                    break;
                case Rol.Supervisor:
                    colaborador = new Supervisor();
                    break;
                case Rol.Colaborador:
                    colaborador = new ColaboradorRegular();
                    break;
                default:
                    return null;
            }
            colaborador.supervisor = supervisor;
            colaborador.ID = id;
            colaborador.puesto = puesto;
            colaborador.Nombres= nombres;
            colaborador.Apellidos= apellidos;
            colaborador.Nacimiento = fechaNacimiento;
            colaborador.Direccion= direccion;
            colaborador.departamento = departamento;
            colaborador.SalarioHora = salarioHora;
            colaborador.Fotografia = foto;
            colaborador.Correo = correo;
            
            colaborador.CuentaIBAN = cuentaIBAN;
            colaborador.Usuario = usuario;
            colaborador.Contrasena = contrasena;
            colaborador.estado = Estado.Activo;
            colaborador.Ingreso = ingreso;

            return colaborador;
        }
    }
}
