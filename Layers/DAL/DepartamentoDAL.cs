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
    internal class DepartamentoDAL
    {
        public static List<Departamento> ListaCompleta()
        {
            List<Departamento> lista = new List<Departamento>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_Departamento_All";
                com.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    Departamento departamento = new Departamento();
                    departamento.ID = (int)reader["ID"];
                    departamento.Nombre = reader["Nombre"].ToString();
                    departamento.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;


                    lista.Add(departamento);
                }
            }
            return lista;

        }

        public static Departamento DepartamentoPorID(int id)
        {
            Departamento departamento = new Departamento();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_Departamento_ByID";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@ID",id));
                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    departamento.ID = (int)reader["ID"];
                    departamento.Nombre = reader["Nombre"].ToString();
                    departamento.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;

                }
            }
            return departamento;

        }
    }
}
