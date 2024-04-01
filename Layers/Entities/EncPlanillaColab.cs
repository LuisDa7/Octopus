using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    public class EncPlanillaColab
    {
        public int ID { get; set; }
        public int PlanillaPagoID { get; set; }
        public int ColaboradorID { get; set; }
        public double HorasTrabajadas {  get; set; }
        public double HorasVacaciones { get; set; }
        public double SalarioInicial { get; set; }
        public double Salario { get; set; }
        public double SalarioDolares { get; set; }
        public double TotalPercep { get; set; }
        public double TotalDeduc {  get; set; }

        public double TipoCambio { get; set; }
    }
}
