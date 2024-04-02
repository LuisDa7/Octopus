using Octopus.Layers.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface IColaboradorBLL
    {
        void Insert(IColaborador colaborador);
        void UpdateColaborador(IColaborador colaborador);
        void DeleteColaboradorID(int id);
    }
}
