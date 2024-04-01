using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    class Puesto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Estado estado { get; set; }
    }
}
