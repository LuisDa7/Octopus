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
    interface IDeducPercepDAL
    {
        void Insert(DeducPercep deducPercep);
        void Update(DeducPercep deducPercep);

        void Delete(int id);
    }
}
