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
    internal class EmpresaDAL:IEmpresaDAL
    {
        public void Insert(Empresa empresa)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_Empresa";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", empresa.ID));
                command.Parameters.Add(new SqlParameter("@TipoID", empresa.TipoID));
                command.Parameters.Add(new SqlParameter("@Nombre", empresa.Nombre));
                command.Parameters.Add(new SqlParameter("@Telefono", empresa.Telefono));
                command.Parameters.Add(new SqlParameter("@Direccion", empresa.Direccion));
                command.Parameters.Add(new SqlParameter("@Logo", empresa.Logo));
                command.Parameters.Add(new SqlParameter("@Estado", empresa.estado.ToString()));

                db.ExecuteNonQuery(command);
            }
        }

        public static Empresa EmpresaByID(int id) 
        {
            Empresa emp = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_Empresa_ByID";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", id));

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    emp = new Empresa();
                    emp.ID = (int)reader["ID"];
                    emp.TipoID = reader["TipoID"].ToString();
                    emp.Nombre = reader["Nombre"].ToString();
                    emp.Telefono = (int)reader["Telefono"];
                    emp.Logo = (byte[])reader["Logo"];
                    emp.Direccion = reader["Direccion"].ToString();
                    string estado = reader["Estado"].ToString();
                    if (estado == "Activo")
                    {
                        emp.estado = Estado.Activo;
                    }
                    else
                    {
                        emp.estado = Estado.Inactivo;
                    }

                }
                return emp;
            }
            


        }
    }
}
