using Octopus.Enum;
using Octopus.Layers.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    class DeducPercepColab
    {
        public DeducPercep deducPercep { get; set; }
        public IColaborador colaborador { get; set; }
        public Prioridad prioridad { get; set; }
        public Estado estado { get; set; }
    }
}
