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
    internal class DeducPercepBLL:IDeducPercepBLL
    {
        /// <summary>
        /// Inserta una deducción o percepción
        /// </summary>
        /// <param name="deducPercep"></param>
        public void Insert(DeducPercep deducPercep)
        {
            try
            {
                DeducPercepDAL deducPercepDAL = new DeducPercepDAL();
                deducPercepDAL.Insert(deducPercep);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Borra una deducpercep por id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            try
            {
                DeducPercepDAL deducPercepDAL = new DeducPercepDAL();
                deducPercepDAL.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Actualiza una deducpercep
        /// </summary>
        /// <param name="deducPercep"></param>
        public void Update(DeducPercep deducPercep)
        {
            try
            {
                DeducPercepDAL deducPercepDAL = new DeducPercepDAL();
                deducPercepDAL.Update(deducPercep);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Retorna la siguiente id para una inserción
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns></returns>
        public static int GetNextIdentityValue(string tabla)
        {
            int id = -1;
            try
            {
                id = DeducPercepDAL.GetNextIdentityValue(tabla);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return id;
        }
        /// <summary>
        /// Retorna la lista completa de deducciones y percepciones
        /// </summary>
        /// <returns></returns>
        public static List<DeducPercep> ListaCompleta()
        {
            List<DeducPercep> lista;
            try
            {
                lista = DeducPercepDAL.ListaCompleta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }
        /// <summary>
        /// Retorna una DeducPercep buscada por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DeducPercep DeducPercepPorID(int id)
        {
            DeducPercep deducPercep;
            try
            {
                deducPercep = DeducPercepDAL.DeducPercepPorID(id); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return deducPercep;
        }
        /// <summary>
        /// Retorna una DeducPercep buscada por nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static DeducPercep DeducPercepPorNombre(string nombre)
        {
            DeducPercep deducPercep;
            try
            {
                deducPercep = DeducPercepDAL.DeducPercepPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return deducPercep;
        }

        
    }
}
