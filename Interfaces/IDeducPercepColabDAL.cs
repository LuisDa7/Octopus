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
    interface IDeducPercepColabDAL
    {
        void Insert(DeducPercepColab deducPercepColab);
        void Delete(int colaboradorID, int deducPercepID);
    }
}
