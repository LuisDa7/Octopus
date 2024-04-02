using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface IDeducPercepColabBLL
    {
        void Insert(DeducPercepColab deducPercepColab);
        void Delete(int colaboradorID, int deducPercepID);
    }
}
