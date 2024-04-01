using Octopus.Enum;
using Octopus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    public class SolicitudVacaciones
    {
        public int ID { get; set; }
        public int colaboradorID { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int CantidadDias { get; set; }
        public Estado estado { get; set; }
        public Observaciones observaciones { get; set; }

    }
}
