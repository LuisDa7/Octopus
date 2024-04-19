using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.DAL
{
    internal class PuestoDAL:IPuestoDAL
    {
        public void Insert(Puesto puesto)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_Puesto";
                command.CommandType = CommandType.StoredProcedure;

                SqlCommand command2 = new SqlCommand();
                command2.CommandText = "SELECT dbo.fID()";

                puesto.ID = (int) db.ExecuteScalar(command2);

                command.Parameters.Add(new SqlParameter("@ID", puesto.ID));
                command.Parameters.Add(new SqlParameter("@Nombre", puesto.Nombre));
                command.Parameters.Add(new SqlParameter("@Estado", puesto.estado.ToString()));

                db.ExecuteNonQuery(command);
            }
        }

        public void Delete(string nombre)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_Puesto_ByNombre";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nombre", nombre));

                db.ExecuteNonQuery(command);
            }
        }

        public static List<Puesto> ListaCompleta()
        {
            List<Puesto> lista = new List<Puesto>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_Puesto_All";
                command.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    Puesto puesto = new Puesto();
                    puesto.ID = (int) reader["ID"];
                    puesto.Nombre = reader["Nombre"].ToString();
                    puesto.estado = (reader["Estado"].ToString()==Estado.Activo.ToString())
                                    ? Estado.Activo:Estado.Inactivo;

                    lista.Add(puesto);
                }
            }
            return lista;
        }

        public static Puesto PuestoPorID(int id)
        {
            Puesto puesto = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_Puesto_ByID";
                command.Parameters.Add(new SqlParameter("@ID",id));
                command.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    puesto = new Puesto();
                    puesto.ID = (int)reader["ID"];
                    puesto.Nombre = reader["Nombre"].ToString();
                    puesto.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;

                }
            }
            return puesto;
        }
    }
}
