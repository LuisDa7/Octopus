using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface IDeducPercepBLL
    {
        void Insert(DeducPercep deducPercep);
        void Delete(int id);
        void Update(DeducPercep deducPercep);
    }
}
