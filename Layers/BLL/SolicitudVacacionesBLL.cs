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
    internal class SolicitudVacacionesBLL:ISolicitudVacacionesBLL
    {
        public void Insert(SolicitudVacaciones soli)
        {
            try
            {
                SolicitudVacacionesDAL solicitudVacacionesDAL = new SolicitudVacacionesDAL();
                solicitudVacacionesDAL.Insert(soli);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(SolicitudVacaciones soli)
        {
            try
            {
                SolicitudVacacionesDAL solicitudVacacionesDAL = new SolicitudVacacionesDAL();
                solicitudVacacionesDAL.Update(soli);
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
                SolicitudVacacionesDAL solicitudVacacionesDAL = new SolicitudVacacionesDAL();
                solicitudVacacionesDAL.Delete(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<SolicitudVacaciones> ListaBySupervisor(int id)
        {
            List<SolicitudVacaciones> lista;
            try
            {
                lista = SolicitudVacacionesDAL.ListaBySupervisor(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }
        public static SolicitudVacaciones SolicitudPorID(int id)
        {
            SolicitudVacaciones soli;
            try
            {
                soli = SolicitudVacacionesDAL.SolicitudPorID(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return soli;
        }

        public static List<SolicitudVacaciones> ListaCompleta()
        {
            List<SolicitudVacaciones> lista;
            try
            {
                lista = SolicitudVacacionesDAL.ListaCompleta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public static List<SolicitudVacaciones> ListaPorColaborador(int colaboradorID)
        {
            List<SolicitudVacaciones> lista;
            try
            {
                lista = SolicitudVacacionesDAL.ListaPorColaborador(colaboradorID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }
    }
}
