using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface ISolicitudVacacionesDAL
    {
        void Insert(SolicitudVacaciones soli);

        void Update(SolicitudVacaciones soli);
        void Delete(int id);
    }
}
