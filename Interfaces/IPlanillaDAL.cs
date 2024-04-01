using Octopus.Enum;
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
    interface IPlanillaDAL
    {
        void Insert(Planilla planilla);
        void Update(int id, Estado estado);
        void Delete(int id);
    }
}
