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
		/// <summary>
		/// Inserta un puesto
		/// </summary>
		/// <param name="puesto"></param>
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
		/// <summary>
		/// Borra un puesto
		/// </summary>
		/// <param name="nombre"></param>
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
		/// <summary>
		/// Retorna la lista completa de puestos
		/// </summary>
		/// <returns></returns>
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
		/// <summary>
		/// Retorna un puesto por id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
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
