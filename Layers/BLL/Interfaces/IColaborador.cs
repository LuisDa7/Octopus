using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL.Interfaces
{
    interface IColaborador
    {
        int ID { set; get; }
        string Nombres { set; get; }
        string Apellidos { set; get; }
        DateTime Nacimiento { set; get; }
        int puesto { get; set; }
        string Direccion { set; get; }
        DateTime Ingreso { set; get; }
        Departamento departamento { set; get; }
        double SalarioHora { set; get; }
        string Fotografia { set; get; }
        string Correo { set; get; }
        int supervisor { set; get; }
        string CuentaIBAN { set; get; }
        string Usuario { set; get; }
        string Contrasena { set; get; }
        Estado estado { get; set; }
    }
}
