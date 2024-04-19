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
        /// <summary>
        /// Inserta una solicitud de vacaciones
        /// </summary>
        /// <param name="soli"></param>
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
        /// <summary>
        /// Actualiza una solicitud de vacaciones
        /// </summary>
        /// <param name="soli"></param>
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
        /// <summary>
        /// Borra una solicitud de vacaciones
        /// </summary>
        /// <param name="id"></param>
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
        /// <summary>
        /// Retorna una lista de solicitudes realizadas por colaboradores
        /// bajo el mando de un supervisor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retorna una solicitud por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Retorna la lista completa de solicitudes realizadas
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Retorna una lista de solicitudes por colaborador
        /// </summary>
        /// <param name="colaboradorID"></param>
        /// <returns></returns>
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
