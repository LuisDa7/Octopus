using Octopus.Enum;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Patterns
{
    internal class SolicitudVacacionesFactory
    {
        public SolicitudVacaciones Crear(int colaboradorID, DateTime fechaSolicitud, DateTime fechaDesde
            , DateTime fechaHasta, int cantidadDias, Estado estado, Observaciones observaciones)
        {
            return new SolicitudVacaciones()
            {
                colaboradorID = colaboradorID,
                FechaSolicitud = fechaSolicitud,
                FechaDesde = fechaDesde,
                FechaHasta = fechaHasta,
                CantidadDias = cantidadDias,
                estado = estado,
                observaciones = observaciones
            };
        }
    }
}
