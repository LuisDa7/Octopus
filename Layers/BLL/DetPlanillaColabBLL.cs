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
    internal class DetPlanillaColabBLL:IDetPlanillaColabBLL
    {
        /// <summary>
        /// Inserta un detalle de planilla
        /// </summary>
        /// <param name="detPlanilla"></param>
        public void Insert(DetPlanillaColab detPlanilla)
        {
            try
            {
                DetPlanillaColabDAL detPlanillaColabDAL = new DetPlanillaColabDAL();
                detPlanillaColabDAL.Insert(detPlanilla);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra un detalle de planilla
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                DetPlanillaColabDAL detPlanillaColabDAL = new DetPlanillaColabDAL();
                detPlanillaColabDAL.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra los detalles que contengan un idEncabezado específico
        /// </summary>
        /// <param name="id"></param>
        public void DeleteByEnc(int id)
        {
            try
            {
                DetPlanillaColabDAL detPlanillaColabDAL = new DetPlanillaColabDAL();
                detPlanillaColabDAL.DeleteByEnc(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Selecciona y retorna los detalles que contengan un idEncabezado específico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<DetPlanillaColab> SelectByEnc(int id)
        {
            List<DetPlanillaColab> lista;
            try
            {
                lista = DetPlanillaColabDAL.SelectByEnc(id);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
