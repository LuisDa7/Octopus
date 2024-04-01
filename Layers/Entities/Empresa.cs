using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    class Empresa
    {
        public int ID { set; get; }
        public string TipoID { set; get; }
        public string Nombre { set;  get; } 
        public int Telefono { set; get; }
        public string Direccion { set; get; }
        public byte[] Logo { set; get; }
        public Estado estado { get; set; }
    }
}
