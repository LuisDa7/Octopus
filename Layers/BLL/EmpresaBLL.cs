using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octopus.Layers.DAL;
using Octopus.Interfaces;

namespace Octopus.Layers.BLL
{
    internal class EmpresaBLL:IEmpresaBLL
    {
        /// <summary>
        /// Inserta una empresa
        /// </summary>
        /// <param name="empresa"></param>
        public void Insert(Empresa empresa)
        {
            try
            {
                EmpresaDAL empresaDAL = new EmpresaDAL();
                empresaDAL.Insert(empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Selecciona una empresa por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Empresa EmpresaByID(int id)
        {
            Empresa empresa;
            try
            {
                empresa = EmpresaDAL.EmpresaByID(id);
            }
            catch (Exception)
            {
                throw;
            }
            return empresa;
        }
    }
}
