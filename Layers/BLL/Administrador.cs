using Octopus.Enum;
using Octopus.Layers.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    internal class Administrador : IColaborador
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Direccion { get; set; }
        public DateTime Ingreso { get; set; }
        public int puesto { get; set; }
        public Departamento departamento { get; set; }
        public double SalarioHora { get; set; }
        public string Fotografia { get; set; }
        public string Correo { get; set; }
        public int supervisor { get; set; }
        public string CuentaIBAN { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public Estado estado { get; set; }
    }
}
