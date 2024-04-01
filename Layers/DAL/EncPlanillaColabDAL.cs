using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Enum;
using Octopus.Layers.BLL;
using Octopus.Interfaces;

namespace Octopus.Layers.DAL
{
    internal class EncPlanillaColabDAL:IEncPlanillaColabDAL
    {
        public void Insert(EncPlanillaColab encPlanilla)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_INSERT_EncPlanillaColab";
                command.CommandType = CommandType.StoredProcedure;

                SqlCommand command2 = new SqlCommand();
                command2.CommandText = "SELECT dbo.fIDSiguienteEncPlanilla()";

                encPlanilla.ID = (int)db.ExecuteScalar(command2);
                command.Parameters.Add(new SqlParameter("@ID", encPlanilla.ID));
                command.Parameters.Add(new SqlParameter("@PlanillaPagoID", encPlanilla.PlanillaPagoID));
                command.Parameters.Add(new SqlParameter("@ColaboradorID", encPlanilla.ColaboradorID));
                command.Parameters.Add(new SqlParameter("@HorasTrabajadas", encPlanilla.HorasTrabajadas));
                command.Parameters.Add(new SqlParameter("@HorasVacaciones", encPlanilla.HorasVacaciones));
                command.Parameters.Add(new SqlParameter("@SalarioInicial", encPlanilla.SalarioInicial));
                command.Parameters.Add(new SqlParameter("@Salario", encPlanilla.Salario));
                command.Parameters.Add(new SqlParameter("@TipoCambio", encPlanilla.TipoCambio));
                command.Parameters.Add(new SqlParameter("@SalarioDolares", encPlanilla.SalarioDolares));
                command.Parameters.Add(new SqlParameter("@TotalPercep", encPlanilla.TotalPercep));
                command.Parameters.Add(new SqlParameter("@TotalDeduc", encPlanilla.TotalDeduc));

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

        public static int GetIDActual()
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command2 = new SqlCommand();
                command2.CommandText = "SELECT dbo.fIDSiguienteEncPlanilla()";

                return (int)db.ExecuteScalar(command2) - 1;
            }
        }

        public void Delete(int id)
        {
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "sp_DELETE_EncPlanillaColab_ByID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ID",id));

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

        public static EncPlanillaColab EncPlanillaColabByID(int id)
        {
            EncPlanillaColab encPlanillaColab = null;
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_EncPlanillaColab_ByID";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@ID", id));

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    encPlanillaColab = new EncPlanillaColab();
                    encPlanillaColab.ID = (int)reader["ID"];
                    encPlanillaColab.PlanillaPagoID = (int)reader["PlanillaPagoID"];
                    encPlanillaColab.ColaboradorID = (int)reader["ColaboradorID"];
                    encPlanillaColab.HorasTrabajadas = Convert.ToDouble(reader["HorasTrabajadas"]);
                    encPlanillaColab.HorasVacaciones = Convert.ToDouble(reader["HorasVacaciones"]);
                    encPlanillaColab.SalarioInicial = Convert.ToDouble(reader["SalarioInicial"]);
                    encPlanillaColab.Salario = Convert.ToDouble(reader["Salario"]);
                    encPlanillaColab.TipoCambio = Convert.ToDouble(reader["TipoCambio"]);
                    encPlanillaColab.SalarioDolares = Convert.ToDouble(reader["SalarioDolares"]);
                    encPlanillaColab.TotalPercep = Convert.ToDouble(reader["TotalPercep"]);
                    encPlanillaColab.TotalDeduc = Convert.ToDouble(reader["TotalDeduc"]);
                }
            }
            return encPlanillaColab;
        }
        public static List<EncPlanillaColab> ListaCompleta()
        {
            List<EncPlanillaColab> lista = new List<EncPlanillaColab>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_EncPlanillaColab_All";
                com.CommandType = CommandType.StoredProcedure;

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    EncPlanillaColab encPlanillaColab = new EncPlanillaColab();
                    encPlanillaColab.ID = (int)reader["ID"];
                    encPlanillaColab.PlanillaPagoID = (int) reader["PlanillaPagoID"];
                    encPlanillaColab.ColaboradorID = (int)reader["ColaboradorID"];
                    encPlanillaColab.HorasTrabajadas = Convert.ToDouble(reader["HorasTrabajadas"]);
                    encPlanillaColab.HorasVacaciones = Convert.ToDouble(reader["HorasVacaciones"]);
                    encPlanillaColab.SalarioInicial = Convert.ToDouble(reader["SalarioInicial"]);
                    encPlanillaColab.Salario = Convert.ToDouble(reader["Salario"]);
                    encPlanillaColab.TipoCambio = Convert.ToDouble(reader["TipoCambio"]);
                    encPlanillaColab.SalarioDolares = Convert.ToDouble(reader["SalarioDolares"]);
                    encPlanillaColab.TotalPercep = Convert.ToDouble(reader["TotalPercep"]);
                    encPlanillaColab.TotalDeduc = Convert.ToDouble(reader["TotalDeduc"]);

                    lista.Add(encPlanillaColab);
                }
            }
            return lista;
        }

        public static List<EncPlanillaColab> EncabezadosPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<EncPlanillaColab> lista = new List<EncPlanillaColab>();
            using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "sp_SELECT_EncPlanillaColab_byFechaPago";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter("@FechaDesde", fechaDesde));
                com.Parameters.Add(new SqlParameter("@FechaHasta", fechaHasta));

                IDataReader reader = db.ExecuteReader(com);

                while (reader.Read())
                {
                    EncPlanillaColab encPlanillaColab = new EncPlanillaColab();
                    encPlanillaColab.ID = (int)reader["ID"];
                    encPlanillaColab.PlanillaPagoID = (int)reader["PlanillaPagoID"];
                    encPlanillaColab.ColaboradorID = (int)reader["ColaboradorID"];
                    encPlanillaColab.HorasTrabajadas = Convert.ToDouble(reader["HorasTrabajadas"]);
                    encPlanillaColab.HorasVacaciones = Convert.ToDouble(reader["HorasVacaciones"]);
                    encPlanillaColab.SalarioInicial = Convert.ToDouble(reader["SalarioInicial"]);
                    encPlanillaColab.Salario = Convert.ToDouble(reader["Salario"]);
                    encPlanillaColab.SalarioDolares = Convert.ToDouble(reader["SalarioDolares"]);
                    encPlanillaColab.TotalPercep = Convert.ToDouble(reader["TotalPercep"]);
                    encPlanillaColab.TotalDeduc = Convert.ToDouble(reader["TotalDeduc"]);

                    lista.Add(encPlanillaColab);
                }
            }
            return lista;
        }

    }
}
