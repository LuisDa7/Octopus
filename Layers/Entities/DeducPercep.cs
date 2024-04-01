using Octopus.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    class DeducPercep
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Tipo tipo { get; set; } 
        public double Valor { get; set; }
        public TipoValor tipoValor { get; set; }

    }
}
