using Octopus.Enum;
using Octopus.Layers.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers
{
    class SolicitudVacaciones
    {
        public int ID { get; set; }
        public IColaborador colaborador { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public int CantidadDias { get; set; }
        public Estado estado { get; set; }
        public string Observaciones { get; set; }

    }
}
