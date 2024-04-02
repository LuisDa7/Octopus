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
using System.Collections;

namespace Octopus.Layers.DAL
{
    internal class DeducPercepDAL:IDeducPercepDAL
    {
        public void Insert(DeducPercep deducPercep)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_DeducPercep";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nombre", deducPercep.Nombre));
                command.Parameters.Add(new SqlParameter("@Tipo", deducPercep.tipo.ToString()));
                command.Parameters.Add(new SqlParameter("@Valor", deducPercep.Valor));
                command.Parameters.Add(new SqlParameter("@TipoValor", deducPercep.tipoValor.ToString()));
                
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

        public void Update(DeducPercep deducPercep)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_UPDATE_DeducPercep";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", deducPercep.ID));
                command.Parameters.Add(new SqlParameter("@Nombre", deducPercep.Nombre));
                command.Parameters.Add(new SqlParameter("@Tipo", deducPercep.tipo.ToString()));
                command.Parameters.Add(new SqlParameter("@Valor", deducPercep.Valor));
                command.Parameters.Add(new SqlParameter("@TipoValor", deducPercep.tipoValor.ToString()));

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
                command.CommandText = "sp_DELETE_DeducPercep_ByID";
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

        public static int GetNextIdentityValue(string tabla)
        {
            int id = -1;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT [dbo].[fGetNextIdentityValue]('"+tabla+"')";
                id = (int)db.ExecuteScalar(command);
            }

            return id;
        }

        public static List<DeducPercep> ListaCompleta()
        {
            List<DeducPercep> lista = new List<DeducPercep>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_DeducPercep_All";
                com.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    DeducPercep deducPercep = new DeducPercep();
                    deducPercep.ID = Convert.ToInt32(reader["ID"]);
                    deducPercep.Nombre = reader["Nombre"].ToString();
                    deducPercep.tipo = (reader["Tipo"].ToString()=="Deducciones")?Tipo.Deducciones:Tipo.Percepciones;
                    deducPercep.Valor = Convert.ToDouble(reader["Valor"]);
                    deducPercep.tipoValor = (reader["TipoValor"].ToString() == "Porcentaje") ? TipoValor.Porcentaje : TipoValor.Absoluto;


                    lista.Add(deducPercep);
                }
            }
            return lista;
        }

        public static DeducPercep DeducPercepPorID(int id)
        {
            DeducPercep deducPercep = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_DeducPercep_ByID";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@ID", id));
                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    deducPercep = new DeducPercep();
                    deducPercep.ID = Convert.ToInt32(reader["ID"]);
                    deducPercep.Nombre = reader["Nombre"].ToString();
                    deducPercep.tipo = (reader["Tipo"].ToString() == "Deducciones") ? Tipo.Deducciones : Tipo.Percepciones;
                    deducPercep.Valor = Convert.ToDouble(reader["Valor"]);
                    deducPercep.tipoValor = (reader["TipoValor"].ToString() == "Porcentaje") ? TipoValor.Porcentaje : TipoValor.Absoluto;

                }
            }
            return deducPercep;
        }

        public static DeducPercep DeducPercepPorNombre(string nombre)
        {
            DeducPercep deducPercep = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_DeducPercep_ByNombre";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@nombre", nombre));
                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    deducPercep = new DeducPercep();
                    deducPercep.ID = Convert.ToInt32(reader["ID"]);
                    deducPercep.Nombre = reader["Nombre"].ToString();
                    deducPercep.tipo = (reader["Tipo"].ToString() == "Deducciones") ? Tipo.Deducciones : Tipo.Percepciones;
                    deducPercep.Valor = Convert.ToDouble(reader["Valor"]);
                    deducPercep.tipoValor = (reader["TipoValor"].ToString() == "Porcentaje") ? TipoValor.Porcentaje : TipoValor.Absoluto;

                }
            }
            return deducPercep;
        }
    }
}
