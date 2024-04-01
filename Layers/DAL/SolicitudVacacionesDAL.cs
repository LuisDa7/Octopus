using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.DAL
{
    internal class SolicitudVacacionesDAL
    {
        public static void Insert(SolicitudVacaciones soli)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_SolicitudVacaciones";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ColaboradorID", soli.colaboradorID));
                command.Parameters.Add(new SqlParameter("@FechaSolicitud", soli.FechaSolicitud));
                command.Parameters.Add(new SqlParameter("@FechaDesde", soli.FechaDesde));
                command.Parameters.Add(new SqlParameter("@FechaHasta", soli.FechaHasta));
                command.Parameters.Add(new SqlParameter("@CantidadDias", soli.CantidadDias));
                command.Parameters.Add(new SqlParameter("@Estado", soli.estado.ToString() ));
                command.Parameters.Add(new SqlParameter("@Observaciones", soli.observaciones.ToString()));

                try
                {
                    db.ExecuteNonQuery(command);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }
        }

        public static void Update(SolicitudVacaciones soli)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_UPDATE_SolicitudVacaciones";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", soli.ID));
                command.Parameters.Add(new SqlParameter("@ColaboradorID", soli.colaboradorID));
                command.Parameters.Add(new SqlParameter("@FechaSolicitud", soli.FechaSolicitud));
                command.Parameters.Add(new SqlParameter("@FechaDesde", soli.FechaDesde));
                command.Parameters.Add(new SqlParameter("@FechaHasta", soli.FechaHasta));
                command.Parameters.Add(new SqlParameter("@CantidadDias", soli.CantidadDias));
                command.Parameters.Add(new SqlParameter("@Estado", soli.estado.ToString()));
                command.Parameters.Add(new SqlParameter("@Observaciones", soli.observaciones.ToString()));

                try
                {
                    db.ExecuteNonQuery(command);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }
        }

        public static void Delete(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_SolicitudVacaciones_ByID";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));

                try
                {
                    db.ExecuteNonQuery(command);
                }
                catch (SqlException ex)
                {
                    throw ex;
                }

            }
        }

        public static SolicitudVacaciones SolicitudPorID(int id)
        {
            SolicitudVacaciones soli = new SolicitudVacaciones();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_SolicitudVacaciones_ByID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", id));



                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    soli.ID = Convert.ToInt32(reader["ID"].ToString());
                    soli.colaboradorID = Convert.ToInt32(reader["ColaboradorID"].ToString());
                    soli.FechaSolicitud = (DateTime)reader["FechaSolicitud"];
                    soli.FechaDesde = (DateTime)reader["FechaDesde"];
                    soli.FechaHasta = (DateTime)reader["FechaHasta"];
                    soli.CantidadDias = Convert.ToInt32(reader["CantidadDias"].ToString());
                    soli.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    string obs = reader["Observaciones"].ToString();
                    if (obs == "Aprobada")
                    {
                        soli.observaciones = Observaciones.Aprobada;
                    }
                    else if (obs == "Rechazada")
                    {
                        soli.observaciones = Observaciones.Rechazada;
                    }
                    else
                    {
                        soli.observaciones = Observaciones.Pendiente;
                    }
                }
            }
            return soli;
        }

        public static List<SolicitudVacaciones> ListaCompleta()
        {
            List<SolicitudVacaciones> lista = new List<SolicitudVacaciones>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_SolicitudVacaciones_All";
                command.CommandType = CommandType.StoredProcedure;



                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    SolicitudVacaciones soli = new SolicitudVacaciones();
                    soli.ID = Convert.ToInt32(reader["ID"]);
                    soli.colaboradorID = Convert.ToInt32(reader["ColaboradorID"]);
                    soli.FechaSolicitud = (DateTime)reader["FechaSolicitud"];
                    soli.FechaDesde = (DateTime)reader["FechaDesde"];
                    soli.FechaHasta = (DateTime)reader["FechaHasta"];
                    soli.CantidadDias = Convert.ToInt32(reader["CantidadDias"]);
                    soli.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    string obs = reader["Observaciones"].ToString();
                    if (obs == "Aprobada")
                    {
                        soli.observaciones = Observaciones.Aprobada;
                    }
                    else if (obs == "Rechazada")
                    {
                        soli.observaciones = Observaciones.Rechazada;
                    }
                    else
                    {
                        soli.observaciones = Observaciones.Pendiente;
                    }

                    lista.Add(soli);
                }
            }
            return lista;
        }

        public static List<SolicitudVacaciones> ListaBySupervisor(int id)
        {
            List<SolicitudVacaciones> lista = new List<SolicitudVacaciones>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_SolicitudVacaciones_BySupervisor";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Supervisor", id));


                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    SolicitudVacaciones soli = new SolicitudVacaciones();
                    soli.ID = Convert.ToInt32(reader["ID"]);
                    soli.colaboradorID = Convert.ToInt32(reader["ColaboradorID"]);
                    soli.FechaSolicitud = (DateTime)reader["FechaSolicitud"];
                    soli.FechaDesde = (DateTime)reader["FechaDesde"];
                    soli.FechaHasta = (DateTime)reader["FechaHasta"];
                    soli.CantidadDias = Convert.ToInt32(reader["CantidadDias"]);
                    soli.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    string obs = reader["Observaciones"].ToString();
                    if (obs == "Aprobada")
                    {
                        soli.observaciones = Observaciones.Aprobada;
                    }
                    else if (obs == "Rechazada")
                    {
                        soli.observaciones = Observaciones.Rechazada;
                    }
                    else
                    {
                        soli.observaciones = Observaciones.Pendiente;
                    }

                    lista.Add(soli);
                }
            }
            return lista;
        }

        public static List<SolicitudVacaciones> ListaPorColaborador(int colaboradorID)
        {
            List<SolicitudVacaciones> lista = new List<SolicitudVacaciones>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_SolicitudVacaciones_ByColaboradorID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ColaboradorID", colaboradorID));


                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    SolicitudVacaciones soli = new SolicitudVacaciones();
                    soli.ID = Convert.ToInt32(reader["ID"]);
                    soli.colaboradorID = Convert.ToInt32(reader["ColaboradorID"]);
                    soli.FechaSolicitud = (DateTime)reader["FechaSolicitud"];
                    soli.FechaDesde = (DateTime)reader["FechaDesde"];
                    soli.FechaHasta = (DateTime)reader["FechaHasta"];
                    soli.CantidadDias = Convert.ToInt32(reader["CantidadDias"]);
                    soli.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    string obs = reader["Observaciones"].ToString();
                    if (obs == "Aprobada")
                    {
                        soli.observaciones = Observaciones.Aprobada;
                    }
                    else if (obs == "Rechazada")
                    {
                        soli.observaciones = Observaciones.Rechazada;
                    }
                    else
                    {
                        soli.observaciones = Observaciones.Pendiente;
                    }

                    lista.Add(soli);
                }
            }
            return lista;
        }
    }

    
}
