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
    internal class EncPlanillaColabBLL:IEncPlanillaColabBLL
    {
        /// <summary>
        /// Inserta un encabezado de planilla 
        /// </summary>
        /// <param name="encPlanilla"></param>
        public void Insert(EncPlanillaColab encPlanilla)
        {
            try
            {
                EncPlanillaColabDAL encPlanillaColab = new EncPlanillaColabDAL();
                encPlanillaColab.Insert(encPlanilla);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra un encabezado de planilla
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                EncPlanillaColabDAL encPlanillaColab = new EncPlanillaColabDAL();
                encPlanillaColab.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna el id de la ultima inserción
        /// </summary>
        /// <returns></returns>
        public static int GetIDActual()
        {
            try
            {
                return EncPlanillaColabDAL.GetIDActual();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna los encabezados que se encuentran en un rango de fechas
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static List<EncPlanillaColab> EncabezadosPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<EncPlanillaColab> lista;
            try
            {
                lista = EncPlanillaColabDAL.EncabezadosPorFechas(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lista;
        }
        /// <summary>
        /// Retorna un encabezado de una planilla por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static EncPlanillaColab EncPlanillaColabByID(int id)
        {
            EncPlanillaColab encPlanillaColab;
            try
            {
                encPlanillaColab = EncPlanillaColabDAL.EncPlanillaColabByID(id);
                return encPlanillaColab;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna la lista completa de encabezados de planilla
        /// </summary>
        /// <returns></returns>
        public static List<EncPlanillaColab> ListaCompleta()
        {
            List<EncPlanillaColab> lista;
            try
            {
                lista = EncPlanillaColabDAL.ListaCompleta();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
