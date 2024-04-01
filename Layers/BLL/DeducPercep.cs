using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    class DeducPercep
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public Tipo tipo { get; set; } 
        public double Valor { get; set; }
        public TipoValor tipoValor { get; set; }

    }
}
