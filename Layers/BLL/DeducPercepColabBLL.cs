using Octopus.Enum;
using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    internal class DeducPercepColabBLL
    {
        public static void Insert(DeducPercepColab deducPercepColab)
        {
            try
            {
                DeducPercepColabDAL.Insert(deducPercepColab);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Delete(int colaboradorID, int deducPercepID)
        {
            try
            {
                DeducPercepColabDAL.Delete(colaboradorID, deducPercepID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<DeducPercepColab> ListaDeducColab(int id)
        {
            List<DeducPercepColab> lista;
            try
            {
                lista = DeducPercepColabDAL.ListaDeducColab(id);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<DeducPercepColab> ListaPercepColab(int id) 
        {
            List<DeducPercepColab> lista;
            try
            {
                lista = DeducPercepColabDAL.ListaPercepColab(id);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
