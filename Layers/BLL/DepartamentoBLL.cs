using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    internal class DepartamentoBLL
    {
        public static List<Departamento> ListaCompleta()
        {
			try
			{
				return DepartamentoDAL.ListaCompleta();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static Departamento DepartamentoPorID(int id)
		{
            try
            {
                return DepartamentoDAL.DepartamentoPorID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
