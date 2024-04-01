using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Interfaces
{
    interface IDetPlanillaColabBLL
    {
        void Insert(DetPlanillaColab detPlanilla); 

        void Delete(int id);

        void DeleteByEnc(int id);
    }
}
