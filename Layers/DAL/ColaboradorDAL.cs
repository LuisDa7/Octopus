using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Enum;
using System.Security.Policy;
using Octopus.Interfaces;
using Octopus.Layers.Entities;
using System.IO;

namespace Octopus.Layers.DAL
{
    internal class ColaboradorDAL:IColaboradorDAL
    {
        public void Insert(IColaborador colaborador)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_Colaborador";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", colaborador.ID));
                command.Parameters.Add(new SqlParameter("@PuestoID", colaborador.puesto));
                command.Parameters.Add(new SqlParameter("@Nombres", colaborador.Nombres));
                command.Parameters.Add(new SqlParameter("@Apellidos", colaborador.Apellidos));
                command.Parameters.Add(new SqlParameter("@Nacimiento", colaborador.Nacimiento));
                command.Parameters.Add(new SqlParameter("@Direccion", colaborador.Direccion));
                command.Parameters.Add(new SqlParameter("@Ingreso", colaborador.Ingreso));
                command.Parameters.Add(new SqlParameter("@DepartamentoID", colaborador.departamento));
                command.Parameters.Add(new SqlParameter("@SalarioHora", colaborador.SalarioHora));
                command.Parameters.Add(new SqlParameter("@Fotografia", colaborador.Fotografia));
                command.Parameters.Add(new SqlParameter("@Correo", colaborador.Correo));
                command.Parameters.Add(new SqlParameter("@CuentaIBAN", colaborador.CuentaIBAN));
                command.Parameters.Add(new SqlParameter("@Usuario", colaborador.Usuario));
                command.Parameters.Add(new SqlParameter("@Contrasena", colaborador.Contrasena));

                if (colaborador is ColaboradorRegular)
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Colaborador.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", colaborador.supervisor));
                }
                else if (colaborador is Supervisor)
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Supervisor.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", System.Data.SqlTypes.SqlBinary.Null));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Administrador.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", colaborador.supervisor));
                }

                command.Parameters.Add(new SqlParameter("@Estado", colaborador.estado.ToString()));

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

        public void UpdateColaborador(IColaborador colaborador)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_UPDATE_Colaborador";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ID", colaborador.ID));
                command.Parameters.Add(new SqlParameter("@PuestoID", colaborador.puesto));
                command.Parameters.Add(new SqlParameter("@Nombres", colaborador.Nombres));
                command.Parameters.Add(new SqlParameter("@Apellidos", colaborador.Apellidos));
                command.Parameters.Add(new SqlParameter("@Nacimiento", colaborador.Nacimiento));
                command.Parameters.Add(new SqlParameter("@Direccion", colaborador.Direccion));
                command.Parameters.Add(new SqlParameter("@DepartamentoID", colaborador.departamento));
                command.Parameters.Add(new SqlParameter("@SalarioHora", colaborador.SalarioHora));
                command.Parameters.Add(new SqlParameter("@Fotografia", colaborador.Fotografia));
                command.Parameters.Add(new SqlParameter("@Correo", colaborador.Correo));
                command.Parameters.Add(new SqlParameter("@CuentaIBAN", colaborador.CuentaIBAN));
                command.Parameters.Add(new SqlParameter("@Usuario", colaborador.Usuario));
                command.Parameters.Add(new SqlParameter("@Contrasena", colaborador.Contrasena));

                if (colaborador is ColaboradorRegular)
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Colaborador.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", colaborador.supervisor));
                }
                else if (colaborador is Supervisor)
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Supervisor.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", System.Data.SqlTypes.SqlBinary.Null));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@Rol", Rol.Administrador.ToString()));
                    command.Parameters.Add(new SqlParameter("@SupervisorID", colaborador.supervisor));
                }

                command.Parameters.Add(new SqlParameter("@Estado", colaborador.estado.ToString()));

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

        public void DeleteColaboradorID(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_Colaborador_ByID";
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
        public static List<Supervisor> ListaSupervisores()
        {
            List<Supervisor> lista = new List<Supervisor>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_Colaborador_Supervisor";
                command.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    Supervisor s = new Supervisor();
                    s.ID = (int)reader["ID"];
                    s.puesto = (int)reader["PuestoID"];
                    s.Nombres = reader["Nombres"].ToString();
                    s.Apellidos = reader["Apellidos"].ToString();
                    s.Nacimiento = (DateTime)reader["Nacimiento"];
                    s.Direccion = reader["Direccion"].ToString();
                    s.Ingreso = (DateTime)reader["Ingreso"];
                    s.departamento = (int)reader["DepartamentoID"];
                    s.SalarioHora = Convert.ToDouble(reader["SalarioHora"].ToString());
                    s.Fotografia = (byte[])reader["Fotografia"];
                    s.Correo = reader["Correo"].ToString();
                    s.CuentaIBAN = reader["CuentaIBAN"].ToString();
                    s.Usuario = reader["Usuario"].ToString();
                    s.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;


                    lista.Add(s);
                }
            }
            return lista;
        }

        public static List<IColaborador> ListaCompleta()
        {
            List<IColaborador> lista = new List<IColaborador>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_Colaborador_All";
                com.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    string rol = reader["Rol"].ToString();
                    IColaborador c;
                    switch (rol)
                    {
                        case "Supervisor":
                            c = new Supervisor();
                            break;
                        case "Administrador":
                            c = new Administrador();
                            break;
                        case "Colaborador":
                            c = new ColaboradorRegular();
                            break;
                        default:
                            throw new Exception();
                    }

                    c.ID = (int)reader["ID"];
                    c.puesto = (int)reader["PuestoID"];
                    c.Nombres = reader["Nombres"].ToString();
                    c.Apellidos = reader["Apellidos"].ToString();
                    c.Nacimiento = (DateTime)reader["Nacimiento"];
                    c.Direccion = reader["Direccion"].ToString();
                    c.Ingreso = (DateTime)reader["Ingreso"];
                    c.departamento = (int)reader["DepartamentoID"];

                    if (!(c is Supervisor))
                    {
                        c.supervisor = (int)reader["SupervisorID"];
                    }
                    c.SalarioHora = Convert.ToDouble(reader["SalarioHora"].ToString());
                    c.Fotografia = (byte[])reader["Fotografia"];
                    c.Correo = reader["Correo"].ToString();
                    c.CuentaIBAN = reader["CuentaIBAN"].ToString();
                    c.Usuario = reader["Usuario"].ToString();
                    c.Contrasena = reader["Contrasena"].ToString();
                    c.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;


                    lista.Add(c);
                }
            }
            return lista;

        }

        public static IColaborador ColaboradorPorID(int id)
        {
            IColaborador c = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_SELECT_Colaborador_ByID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID", id));



                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read()) 
                {
                    string rol = reader["Rol"].ToString();
                    switch (rol)
                    {
                        case "Supervisor":
                            c = new Supervisor();
                            break;
                        case "Administrador":
                            c = new Administrador();
                            break;
                        case "Colaborador":
                            c = new ColaboradorRegular();
                            break;
                        default:
                            throw new Exception();
                    }
                    c.ID = (int)reader["ID"];
                    c.puesto = (int)reader["PuestoID"];
                    c.Nombres = reader["Nombres"].ToString();
                    c.Apellidos = reader["Apellidos"].ToString();
                    c.Nacimiento = (DateTime)reader["Nacimiento"];
                    c.Direccion = reader["Direccion"].ToString();
                    c.Ingreso = (DateTime)reader["Ingreso"];
                    c.departamento = (int)reader["DepartamentoID"];
                    c.SalarioHora = Convert.ToDouble(reader["SalarioHora"].ToString());
                    c.Fotografia = (byte[])reader["Fotografia"];
                    c.Correo = reader["Correo"].ToString();
                    c.CuentaIBAN = reader["CuentaIBAN"].ToString();
                    c.Usuario = reader["Usuario"].ToString();
                    c.Contrasena = reader["Contrasena"].ToString();
                    c.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    try
                    {
                        c.supervisor = (int)reader["SupervisorID"];
                    }
                    catch (Exception)
                    {
                        c.supervisor = -1;
                    }
                    
                }
            }
            return c;
        }

        

        public static IColaborador LogIn(string usuario, string contrasena)
        {
            IColaborador c = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_LogIn";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@usuario", usuario));
                command.Parameters.Add(new SqlParameter("@contrasena", contrasena));

                IDataReader reader = db.ExecuteReader(command);

                while (reader.Read())
                {
                    string rol = reader["Rol"].ToString();
                    switch (rol)
                    {
                        case "Supervisor":
                            c = new Supervisor();
                            break;
                        case "Administrador":
                            c = new Administrador();
                            break;
                        case "Colaborador":
                            c = new ColaboradorRegular();
                            break;
                        default:
                            throw new Exception();
                    }
                    c.ID = (int)reader["ID"];
                    c.puesto = (int)reader["PuestoID"];
                    c.Nombres = reader["Nombres"].ToString();
                    c.Apellidos = reader["Apellidos"].ToString();
                    c.Nacimiento = (DateTime)reader["Nacimiento"];
                    c.Direccion = reader["Direccion"].ToString();
                    c.Ingreso = (DateTime)reader["Ingreso"];
                    c.departamento = (int)reader["DepartamentoID"];
                    c.SalarioHora = Convert.ToDouble(reader["SalarioHora"].ToString());
                    c.Fotografia = (byte[])reader["Fotografia"];
                    c.Correo = reader["Correo"].ToString();
                    c.CuentaIBAN = reader["CuentaIBAN"].ToString();
                    c.Usuario = reader["Usuario"].ToString();
                    c.Contrasena = reader["Contrasena"].ToString();
                    c.estado = (reader["Estado"].ToString() == Estado.Activo.ToString())
                                    ? Estado.Activo : Estado.Inactivo;
                    try
                    {
                        c.supervisor = (int)reader["SupervisorID"];
                    }
                    catch (Exception)
                    {
                        c.supervisor = -1;
                    }

                }
            }
            return c;
        }

    }
}
