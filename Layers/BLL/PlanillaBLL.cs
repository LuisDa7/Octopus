using Octopus.Enum;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Layers.DAL;
using Octopus.Interfaces;

namespace Octopus.Layers.BLL
{
    internal class PlanillaBLL:IPlanillaBLL
    {
        /// <summary>
        /// Inserta una planilla
        /// </summary>
        /// <param name="planilla"></param>
        public void Insert(Planilla planilla)
        {
            try
            {
                PlanillaDAL planillaDAL = new PlanillaDAL();
                planillaDAL.Insert(planilla);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna la id siguiente para inserción
        /// </summary>
        /// <returns></returns>
        public static int GetID()
        {
            try
            {
                return PlanillaDAL.GetID();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Actualiza una planilla
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado"></param>
        public void Update(int id, Estado estado)
        {
            try
            {
                PlanillaDAL planillaDAL = new PlanillaDAL();
                planillaDAL.Update(id, estado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra una planilla
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                PlanillaDAL planillaDAL = new PlanillaDAL();
                planillaDAL.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna una planilla por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Planilla PlanillaByID(int id)
        {
            Planilla planilla;
            try
            {
                planilla = PlanillaDAL.PlanillaByID(id);
                return planilla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna todas las planillas
        /// </summary>
        /// <returns></returns>
        public static List<Planilla> PlanillaAll()
        {
            List<Planilla> lista;
            try
            {
                lista = PlanillaDAL.PlanillaAll();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
