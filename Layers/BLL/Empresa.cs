using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    class Empresa
    {
        public string ID { get; }
        public string TipoID { get; }
        public string Nombre { set;  get; } 
        public int Telefono { set; get; }
        public string Direccion { set; get; }
        public string Logo { set; get; }
        public Estado estado { get; set; }
    }
}
