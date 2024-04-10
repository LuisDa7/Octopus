using Octopus.Enum;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using Octopus.Layers.DAL.APIClients;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Layers.Entities
{
    public class Planilla
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public DateTime? FechaPago { get; set; }
        public Estado estado { get; set; }
        public double TipoCambio { get; set; }
        public List<EncPlanillaColab> encabezados { get; set; }
        public List<SolicitudVacaciones> solicitudes;
        public List<DetPlanillaColab> detalles { get; set; }

        public Planilla() 
        {
            try
            {
                solicitudes = SolicitudVacacionesBLL.ListaCompleta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IColaborador> GetColaboradores()
        {
            try
            {
                return ColaboradorBLL.ListaCompleta();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private double CargarTotalHoras(IColaborador colaborador, List<Marcas> marcas)
        {
            double total = 0;
            List<Marcas> marcasColab = marcas.Where((a) => a.ID == colaborador.ID).ToList();
            foreach (Marcas item in marcasColab)
            {
                total += item.CantHoras;
            }

            

            return total;
        }

        private double HorasVacaciones(IColaborador colaborador)
        {
            double total = 0;
            //valida si hay solicitudes aprobadas
            List<SolicitudVacaciones> solicitudVacaciones;
            bool resultado = TieneVacacionesAprobadas(colaborador, out solicitudVacaciones);

            if (resultado == true)
            {
                foreach (SolicitudVacaciones solicitud in solicitudVacaciones)
                {
                    total += solicitud.CantidadDias * 8;
                }
            }
            return total;
        }

        private double SalarioHora(IColaborador colaborador, double horas)
        {
            double salario;
            
            //Valida salario ordinario o extraordinario
            if (horas <= 48)
            {
                salario = colaborador.SalarioHora * horas;
            }
            else
            {
                salario = colaborador.SalarioHora * 48 + ((colaborador.SalarioHora * 2) * (horas - 48));
            }

            return salario;
        }

        private double TotalPercepciones(IColaborador colaborador, double salarioHora)
        {
            double montoTotal = 0;
            double montoIndividual;
            List<DeducPercepColab> lista;
            try
            {
                lista = DeducPercepColabBLL.ListaPercepColab(colaborador.ID);
            }
            catch (Exception)
            {
                throw;
            }

            foreach (DeducPercepColab item in lista)
            {
                DeducPercep percep;
                try
                {
                    percep = DeducPercepBLL.DeducPercepPorID(item.DeducPercepID);
                }
                catch (Exception)
                {
                    throw;
                }
                if (percep.tipoValor == TipoValor.Absoluto)
                {
                    montoIndividual = percep.Valor;
                    montoTotal += montoIndividual;
                }
                else
                {
                    montoIndividual = salarioHora * (percep.Valor / 100);
                    montoTotal += montoIndividual;
                }

                DetPlanillaColab detalle = new DetPlanillaColab()
                {
                    Descripcion = percep.Nombre,
                    Monto = montoIndividual,
                    DeducPercepID = percep.ID
                };

                detalles.Add(detalle);

            }

            return montoTotal;

        }

        private bool TieneVacacionesAprobadas(IColaborador colaborador, 
                                                out List<SolicitudVacaciones> solicitudesAprobadas)
        {
            List<SolicitudVacaciones> listaPorColab;
            
            listaPorColab = solicitudes.Where((a) => a.FechaDesde.Date >= this.FechaDesde.Date && 
            a.FechaHasta.Date <= this.FechaHasta.Date && a.colaboradorID == colaborador.ID).ToList();

            solicitudesAprobadas = listaPorColab.Where((a) => a.observaciones == Observaciones.Aprobada).ToList();
            if (solicitudesAprobadas.Count >= 0)
                return true;
            else
                return false;
        }

        private double TotalDeducciones(IColaborador colaborador, double salario)
        {
            double montoIndividual;
            double montoTotal = 0;
            List<DeducPercepColab> lista;
            try
            {
                lista = DeducPercepColabBLL.ListaDeducColab(colaborador.ID);
            }
            catch (Exception)
            {
                throw;
            }
            List<DeducPercepColab> pAlta = lista.Where((a) => a.prioridad == Prioridad.Alta).ToList();
            List<DeducPercepColab> pMedia = lista.Where((a) => a.prioridad == Prioridad.Media).ToList();
            List<DeducPercepColab> pBaja = lista.Where((a) => a.prioridad == Prioridad.Baja).ToList();
            foreach (DeducPercepColab item in pAlta)
            {

                DeducPercep deduc;
                try
                {
                    deduc = DeducPercepBLL.DeducPercepPorID(item.DeducPercepID);
                }
                catch (Exception)
                {
                    throw;
                }

                if (deduc.tipoValor == TipoValor.Absoluto)
                {
                    montoIndividual = deduc.Valor;
                    montoTotal += montoIndividual;
                }
                else
                {
                    montoIndividual = salario * (deduc.Valor) / 100;
                    montoTotal += montoIndividual;
                }
                if (montoTotal > salario)
                {
                    montoTotal -= montoIndividual;
                    return montoTotal;
                }

                DetPlanillaColab detalle = new DetPlanillaColab()
                {
                    Descripcion = deduc.Nombre,
                    Monto = montoIndividual,
                    DeducPercepID = deduc.ID
                };
                detalles.Add(detalle);

            }
            foreach (DeducPercepColab item in pMedia)
            {

                DeducPercep deduc;
                try
                {
                    deduc = DeducPercepBLL.DeducPercepPorID(item.DeducPercepID);
                }
                catch (Exception)
                {
                    throw;
                }

                if (deduc.tipoValor == TipoValor.Absoluto)
                {
                    montoIndividual = deduc.Valor;
                    montoTotal += montoIndividual;
                }
                else
                {
                    montoIndividual = salario * (deduc.Valor) / 100;
                    montoTotal += montoIndividual;
                }
                if (montoTotal > salario)
                {
                    montoTotal -= montoIndividual;
                    return montoTotal;
                }
                DetPlanillaColab detalle = new DetPlanillaColab()
                {
                    Descripcion = deduc.Nombre,
                    Monto = montoIndividual,
                    DeducPercepID = deduc.ID
                };
                detalles.Add(detalle);

            }
            foreach (DeducPercepColab item in pBaja)
            {

                DeducPercep deduc;
                try
                {
                    deduc = DeducPercepBLL.DeducPercepPorID(item.DeducPercepID);
                }
                catch (Exception)
                {
                    throw;
                }

                if (deduc.tipoValor == TipoValor.Absoluto)
                {
                    montoIndividual = deduc.Valor;
                    montoTotal += montoIndividual;
                }
                else
                {
                    montoIndividual = salario * (deduc.Valor) / 100;
                    montoTotal += montoIndividual;
                }
                if (montoTotal > salario)
                {
                    montoTotal -= montoIndividual;
                    return montoTotal;
                }
                DetPlanillaColab detalle = new DetPlanillaColab()
                {
                    Descripcion = deduc.Nombre,
                    Monto = montoIndividual,
                    DeducPercepID = deduc.ID
                };
                detalles.Add(detalle);

            }
            return montoTotal;
        }

        public void CrearFacturas(List<Marcas> marcas)
        {
            EncPlanillaColabBLL encPlanillaColabBLL = new EncPlanillaColabBLL();
            encabezados = new List<EncPlanillaColab>();
            detalles = new List<DetPlanillaColab>();
            foreach (IColaborador colab in GetColaboradores())
            {
                double horasTrabajadas = CargarTotalHoras(colab, marcas);
                double horasVacaciones = HorasVacaciones(colab);
                double salarioHora = SalarioHora(colab, horasTrabajadas + horasVacaciones);
                double totalPercepciones = TotalPercepciones(colab, salarioHora);
                double salario = totalPercepciones + salarioHora;
                double totalDeducciones = TotalDeducciones(colab, salario);
                double salarioFinal = salario - totalDeducciones;
                double salarioDolares = SalarioDolares(salarioFinal);

                EncPlanillaColab encPlanillaColab = new EncPlanillaColab()
                {
                    PlanillaPagoID = ID,
                    ColaboradorID = colab.ID,
                    HorasTrabajadas = horasTrabajadas,
                    HorasVacaciones = horasVacaciones,
                    SalarioInicial = salarioHora,
                    Salario = salarioFinal,
                    SalarioDolares = salarioDolares,
                    TotalPercep = totalPercepciones,
                    TotalDeduc = totalDeducciones,
                    TipoCambio = this.TipoCambio
                };

                try
                {
                    encPlanillaColabBLL.Insert(encPlanillaColab);
                }
                catch (Exception)
                {
                    throw;
                }

                CrearDetalles();
                encabezados.Add(encPlanillaColab);

            }
        }

        private void CrearDetalles()
        {
            EncPlanillaColab enc;
            int id;
            try
            {
                id = EncPlanillaColabBLL.GetIDActual();
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                enc = EncPlanillaColabBLL.EncPlanillaColabByID(id);
            }
            catch (Exception)
            {

                throw;
            }
            DetPlanillaColabBLL detPlanillaColabBLL = new DetPlanillaColabBLL();
            foreach (DetPlanillaColab item in detalles)
            {
                item.EncPlanillaColabID = enc.ID;

                try
                {
                    detPlanillaColabBLL.Insert(item);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            this.detalles.Clear();
        }

        private double SalarioDolares(double salarioFinal)
        {
            ServiceBCCR service = new ServiceBCCR();
            List<Dolar> lista = (List<Dolar>)service.GetDolar(DateTime.Now, DateTime.Now, "v");
            TipoCambio = lista.ElementAt(0).Monto;
            return salarioFinal / TipoCambio;
        }

    }
}
