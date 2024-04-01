using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface IPuestoBLL
    {
        void Insert(Puesto puesto);

        void Delete(string nombre);
    }
}
