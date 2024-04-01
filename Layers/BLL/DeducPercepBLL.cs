using Octopus.Layers.DAL;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.BLL
{
    internal class DeducPercepBLL
    {
        public static void Insert(DeducPercep deducPercep)
        {
            try
            {
                DeducPercepDAL.Insert(deducPercep);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void Update(DeducPercep deducPercep)
        {
            try
            {
                DeducPercepDAL.Update(deducPercep);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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

        public static void Delete(int id)
        {
            try
            {
                DeducPercepDAL.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
