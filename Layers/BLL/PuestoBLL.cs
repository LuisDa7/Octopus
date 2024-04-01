using Octopus.Interfaces;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    internal class PuestoBLL:IPuestoBLL
    {
        public void Insert(Puesto puesto)
        {
			try
			{
                PuestoDAL puestoDAL = new PuestoDAL();
                puestoDAL.Insert(puesto);
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public void Delete(string nombre)
		{
			try
			{
				PuestoDAL puestoDAL = new PuestoDAL();
				puestoDAL.Delete(nombre);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

        public static List<Puesto> ListaCompleta()
		{
			try
			{
				return PuestoDAL.ListaCompleta();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

        public static Puesto PuestoPorID(int id)
		{
			try
			{
				return PuestoDAL.PuestoPorID(id);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }
}
