using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Interfaces;

namespace Octopus.Layers.DAL
{
    internal class DetPlanillaColabDAL:IDetPlanillaColabDAL
    {
        public void Insert(DetPlanillaColab detPlanilla)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_DetPlanillaColab";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@EncPlanillaColabID", detPlanilla.EncPlanillaColabID));
                command.Parameters.Add(new SqlParameter("@Descripcion", detPlanilla.Descripcion));
                command.Parameters.Add(new SqlParameter("@Monto", detPlanilla.Monto));
                command.Parameters.Add(new SqlParameter("@DeducPercepID", detPlanilla.DeducPercepID));
                
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

        public void Delete(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_DetPlanillaColab_ByID";
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

        public void DeleteByEnc(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_DetPlanillaColab_ByIDEnc";
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

        public static List<DetPlanillaColab> SelectByEnc(int id)
        {
            List<DetPlanillaColab> lista = new List<DetPlanillaColab>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_DetPlanillaColab_ByIDEnc";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@EncID", id));
                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    DetPlanillaColab detPlanillaColab = new DetPlanillaColab();
                    detPlanillaColab.ID = (int)reader["ID"];
                    detPlanillaColab.EncPlanillaColabID = (int)reader["EncPlanillaColabID"];
                    detPlanillaColab.Descripcion = reader["Descripcion"].ToString();
                    detPlanillaColab.Monto = Convert.ToDouble(reader["Monto"]);
                    detPlanillaColab.DeducPercepID = (int)reader["DeducPercepID"];

                    lista.Add(detPlanillaColab);
                }
            }
            return lista;
        }
    }
}
