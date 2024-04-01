using Octopus.Enum;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Patterns
{
    internal class DeducPercepColabFactory
    {
        public DeducPercepColab Crear(int colaboradorID, int deducPercepID, Prioridad prioridad, Estado estado)
        {
            return new DeducPercepColab(){
                ColaboradorID = colaboradorID,
                DeducPercepID = deducPercepID,
                prioridad= prioridad,
                estado= estado
            };
        }
    }
}
