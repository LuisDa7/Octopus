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
using Octopus.Interfaces;

namespace Octopus.Layers.BLL
{
    internal class DeducPercepColabBLL:IDeducPercepColabBLL
    {
        /// <summary>
        /// Inserta un DeducPercepColab
        /// </summary>
        /// <param name="deducPercepColab"></param>
        public void Insert(DeducPercepColab deducPercepColab)
        {
            try
            {
                DeducPercepColabDAL deducPercepColabDAL = new DeducPercepColabDAL();
                deducPercepColabDAL.Insert(deducPercepColab);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra un DeducPercepColab por id´s
        /// </summary>
        /// <param name="colaboradorID"></param>
        /// <param name="deducPercepID"></param>
        public void Delete(int colaboradorID, int deducPercepID)
        {
            try
            {
                DeducPercepColabDAL deducPercepColabDAL = new DeducPercepColabDAL();
                deducPercepColabDAL.Delete(colaboradorID, deducPercepID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna una lista de deducciones por colaborador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retorna una lista de percepciones por colaborador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
