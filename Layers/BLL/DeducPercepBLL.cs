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

        
    }
}
