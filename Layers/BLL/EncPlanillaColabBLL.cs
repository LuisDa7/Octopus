using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Layers.DAL;

namespace Octopus.Layers.BLL
{
    internal class EncPlanillaColabBLL
    {
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
