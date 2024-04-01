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

namespace Octopus.Layers.BLL
{
    internal class PlanillaBLL
    {
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
