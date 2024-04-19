using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using Octopus.Patterns;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.BLL
{
    internal class ColaboradorBLL:IColaboradorBLL
    {
		/// <summary>
		/// Inserta un colaborador
		/// </summary>
		/// <param name="colaborador"></param>
        public void Insert(IColaborador colaborador)
        {
			try
			{
                ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
                colaboradorDAL.Insert(colaborador);
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
		/// <summary>
		/// Retorna la lista de supervisores
		/// </summary>
		/// <returns></returns>
        public static List<Supervisor> ListaSupervisores()
		{
			try
			{
				return ColaboradorDAL.ListaSupervisores();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		/// <summary>
		/// Retorna la lista completa de colaboradores
		/// </summary>
		/// <returns></returns>
        public static List<IColaborador> ListaCompleta()
		{
			try
			{
				return ColaboradorDAL.ListaCompleta();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		/// <summary>
		/// Retorna el colaborador buscado por id
		/// </summary>
		/// <param name="id">Id buscada</param>
		/// <returns></returns>
        public static IColaborador ColaboradorPorID(int id)
		{
			try
			{
				return ColaboradorDAL.ColaboradorPorID(id);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		/// <summary>
		/// Actualiza el colaborador
		/// </summary>
		/// <param name="colaborador"></param>
        public void UpdateColaborador(IColaborador colaborador)
		{
			try
			{
				ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
				colaboradorDAL.UpdateColaborador(colaborador);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		/// <summary>
		/// Borra el colaborador por id
		/// </summary>
		/// <param name="id"></param>
		/// <exception cref="Exception"></exception>
		public void DeleteColaboradorID(int id)
		{
			if (ColaboradorDAL.ColaboradorPorID(id) == null)
			{
				throw new Exception("El id no existe");
			}
			try
			{
                ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
                colaboradorDAL.DeleteColaboradorID(id);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		/// <summary>
		/// Retorna el colaborador con el usuario y contraseña ingresada
		/// </summary>
		/// <param name="usuario"></param>
		/// <param name="contrasena"></param>
		/// <returns></returns>
		public static IColaborador LogIn(string usuario, string contrasena)
		{
			IColaborador colaborador;
			try
			{
				colaborador = ColaboradorDAL.LogIn(usuario, contrasena);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return colaborador;
		}
    }
}
