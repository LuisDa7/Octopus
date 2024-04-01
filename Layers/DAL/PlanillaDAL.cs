using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Enum;
using Octopus.Interfaces;

namespace Octopus.Layers.DAL
{
    internal class PlanillaDAL:IPlanillaDAL
    {
        public void Insert(Planilla planilla)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_PlanillaPago";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nombre", planilla.Nombre));
                command.Parameters.Add(new SqlParameter("@FechaDesde", planilla.FechaDesde));
                command.Parameters.Add(new SqlParameter("@FechaHasta", planilla.FechaHasta));
                if (planilla.FechaPago == null)
                {
                    command.Parameters.Add(new SqlParameter("@FechaPago", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@FechaPago", planilla.FechaPago));
                }
                command.Parameters.Add(new SqlParameter("@Estado", planilla.estado.ToString()));

                db.ExecuteNonQuery(command);
            }
        }

        public static int GetID()
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = "SELECT dbo.fIDPlanillaPago()";

                return (int)db.ExecuteScalar(command2) - 1;
            }
        }

        public void Update(int id, Estado estado)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_UPDATE_PlanillaPago";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));
                command.Parameters.Add(new SqlParameter("@estado", estado.ToString()));
                
                db.ExecuteNonQuery(command);
            }
        }
        public void Delete(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_PlanillaPago_ByID";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));

                db.ExecuteNonQuery(command);
            }
        }

        public static Planilla PlanillaByID(int id)
        {
            Planilla planilla = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_PlanillaPago_ByID";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    planilla = new Planilla();
                    planilla.ID = (int)reader["ID"];
                    planilla.Nombre = reader["Nombre"].ToString();
                    planilla.FechaDesde = (DateTime) reader["FechaDesde"];
                    planilla.FechaHasta = (DateTime)reader["FechaHasta"];
                    planilla.FechaPago = (DateTime?)reader["FechaPago"];
                    string estado = reader["Estado"].ToString();
                    if (estado == "por enviar")
                    {
                        planilla.estado = Estado.PorEnviar;
                    }
                    else if (estado == "enviada")
                    {
                        planilla.estado = Estado.Enviada;
                    }
                    else
                    {
                        planilla.estado = Estado.Inactivo;
                    }

                }
            }
            return planilla;
        }

        public static List<Planilla> PlanillaAll()
        {
            List<Planilla> lista = new List<Planilla>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_PlanillaPago_All";
                command.CommandType = CommandType.StoredProcedure;


                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    Planilla planilla = new Planilla();
                    planilla.ID = (int)reader["ID"];
                    planilla.Nombre = reader["Nombre"].ToString();
                    planilla.FechaDesde = (DateTime)reader["FechaDesde"];
                    planilla.FechaHasta = (DateTime)reader["FechaHasta"];
                    planilla.FechaPago = (DateTime)reader["FechaPago"];
                    string estado = reader["Estado"].ToString();
                    if (estado == "por enviar")
                    {
                        planilla.estado = Estado.PorEnviar;
                    }
                    else if (estado == "enviada")
                    {
                        planilla.estado = Estado.Enviada;
                    }
                    else
                    {
                        planilla.estado = Estado.Inactivo;
                    }
                    lista.Add(planilla);
                }
            }
            return lista;
        }
    }
}
