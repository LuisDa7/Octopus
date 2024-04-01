using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    public class DetPlanillaColab
    {
        public int ID { get; set; }
        public int EncPlanillaColabID { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public int DeducPercepID { get; set; }
    }
}
