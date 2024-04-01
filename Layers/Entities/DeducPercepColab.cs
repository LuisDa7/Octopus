using Octopus.Enum;
using Octopus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    class DeducPercepColab
    {
        public int DeducPercepID { get; set; }
        public int ColaboradorID { get; set; }
        public Prioridad prioridad { get; set; }
        public Estado estado { get; set; }
    }
}
