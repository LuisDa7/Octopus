using Octopus.Enum;
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
    internal class DeducPercepColabDAL
    {
        public static void Insert(DeducPercepColab deducPercepColab)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_DeducPercepColab";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ColaboradorID", deducPercepColab.ColaboradorID));
                command.Parameters.Add(new SqlParameter("@DeducPercepID", deducPercepColab.DeducPercepID));
                command.Parameters.Add(new SqlParameter("@Prioridad", deducPercepColab.prioridad.ToString()));
                command.Parameters.Add(new SqlParameter("@Estado", deducPercepColab.estado.ToString()));

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

        public static void Delete(int colaboradorID, int deducPercepID)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_DeducPercepColab_ByID";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ColaboradorID", colaboradorID));
                command.Parameters.Add(new SqlParameter("@DeducPercepID", deducPercepID));

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

        public static List<DeducPercepColab> ListaDeducColab(int id)
        {
            List<DeducPercepColab> lista = new List<DeducPercepColab>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_DeducColab";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@ID", id));

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    DeducPercepColab deducPercepColab = new DeducPercepColab();
                    deducPercepColab.DeducPercepID = (int)(reader["DeducPercepID"]);
                    deducPercepColab.ColaboradorID = (int)(reader["ColaboradorID"]);
                    string prioridad = reader["Prioridad"].ToString();
                    if (prioridad == "Alta")
                    {
                        deducPercepColab.prioridad = Prioridad.Alta;
                    }
                    else if (prioridad == "Media")
                    {
                        deducPercepColab.prioridad = Prioridad.Media;
                    }
                    else
                    {
                        deducPercepColab.prioridad = Prioridad.Baja;
                    }
                    deducPercepColab.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    lista.Add(deducPercepColab);
                }
            }
            return lista;
        }

        public static List<DeducPercepColab> ListaPercepColab(int id) //todo arreglar bll y carga de dgv en asignardeducpercep y sp
        {
            List<DeducPercepColab> lista = new List<DeducPercepColab>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_PercepColab";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@ID", id));

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    DeducPercepColab deducPercepColab = new DeducPercepColab();
                    deducPercepColab.DeducPercepID = (int)(reader["DeducPercepID"]);
                    deducPercepColab.ColaboradorID = (int)(reader["ColaboradorID"]);
                    string prioridad = reader["Prioridad"].ToString();
                    if (prioridad == "Alta")
                    {
                        deducPercepColab.prioridad = Prioridad.Alta;
                    }
                    else if (prioridad == "Media")
                    {
                        deducPercepColab.prioridad = Prioridad.Media;
                    }
                    else
                    {
                        deducPercepColab.prioridad = Prioridad.Baja;
                    }
                    deducPercepColab.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    lista.Add(deducPercepColab);
                }
            }
            return lista;
        }

    }

    
}
