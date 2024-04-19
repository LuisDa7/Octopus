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
        /// <summary>
        /// Constructor que inicializa la lista de solicitudes 
        /// </summary>
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
        /// <summary>
        /// retorna la lista de colaboradores
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Asigna el total de horas trabajadas al respectivo colaborador
        /// </summary>
        /// <param name="colaborador">Colaborador al cual se le asignarán las horas</param>
        /// <param name="marcas">lista de marcas</param>
        /// <returns></returns>
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
        /// <summary>
        /// Calcula las horas de vacaciones del colaborador
        /// </summary>
        /// <param name="colaborador">Colaborador al cual se le van a calcular las horas de vacaciones</param>
        /// <returns></returns>
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
        /// <summary>
        /// Calcula el salario por horas trabajadas del colaborador
        /// </summary>
        /// <param name="colaborador">Colaborador al que se le calculará el salario por horas</param>
        /// <param name="horas">Horas trabajadas</param>
        /// <returns></returns>
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
        /// <summary>
        /// Calcula el monto total de percepciones
        /// </summary>
        /// <param name="colaborador">Colaborador al que se le calculará el monto</param>
        /// <param name="salarioHora">Calculo de salario por horas</param>
        /// <returns></returns>
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
        /// <summary>
        /// Valida si el colaborador tiene vacaciones aprobadas
        /// </summary>
        /// <param name="colaborador">Colaborador al que se le validará</param>
        /// <param name="solicitudesAprobadas">parámetro de salida que contiene las solicitudes</param>
        /// <returns></returns>
        private bool TieneVacacionesAprobadas(IColaborador colaborador, 
                                                out List<SolicitudVacaciones> solicitudesAprobadas)
        {
            List<SolicitudVacaciones> listaPorColab;
            
            listaPorColab = solicitudes.Where((a) => a.FechaDesde.Date >= this.FechaDesde.Date && 
            a.FechaHasta.Date <= this.FechaHasta.Date && a.colaboradorID == colaborador.ID).ToList();

            solicitudesAprobadas = listaPorColab.Where((a) => a.observaciones == Observaciones.Aprobada).ToList();
            if (solicitudesAprobadas.Count > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Calcula el total de deducciones para un colaborador
        /// </summary>
        /// <param name="colaborador">Colaborador al cuál se le calculará el monto de deducciones</param>
        /// <param name="salario">Salario base</param>
        /// <returns></returns>
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
                    if (deduc.Nombre.Contains("Renta"))
                    {
                        montoIndividual = CalcularRenta(deduc,salario);
                        montoTotal += montoIndividual;
                    }
                    else
                    {
                        montoIndividual = salario * (deduc.Valor) / 100;
                        montoTotal += montoIndividual;
                    }
                    
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
                    if (deduc.Nombre.Contains("Renta"))
                    {
                        montoIndividual = CalcularRenta(deduc, salario);
                        montoTotal += montoIndividual;
                    }
                    else
                    {
                        montoIndividual = salario * (deduc.Valor) / 100;
                        montoTotal += montoIndividual;
                    }
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
                    if (deduc.Nombre.Contains("Renta"))
                    {
                        montoIndividual = CalcularRenta(deduc, salario);
                        montoTotal += montoIndividual;
                    }
                    else
                    {
                        montoIndividual = salario * (deduc.Valor) / 100;
                        montoTotal += montoIndividual;
                    }
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
        /// <summary>
        /// Calcula el impuesto de renta
        /// </summary>
        /// <param name="deduc">Deducción asignada</param>
        /// <param name="salario">salario base</param>
        /// <returns></returns>
        private double CalcularRenta(DeducPercep deduc,double salario)
        {
            double excedente;
            if (deduc.Valor == 10)
            {
                excedente = salario - 232250;
            }
            else if (deduc.Valor == 15)
            {
                excedente = salario - 340750;
            }
            else if (deduc.Valor == 20)
            {
                excedente = salario - 598000;
            }
            else
            {
                excedente = salario - 1195750;
            }
            return excedente*(deduc.Valor/100);

        }
        /// <summary>
        /// Crea las facturas 
        /// </summary>
        /// <param name="marcas">Lista de marcas</param>
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
        /// <summary>
        /// Crea los detalles del encabezado activo
        /// </summary>
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
        /// <summary>
        /// Realiza la conversión del salario de colones a dolares
        /// </summary>
        /// <param name="salarioFinal">salario en colones</param>
        /// <returns></returns>
        private double SalarioDolares(double salarioFinal)
        {
            ServiceBCCR service = new ServiceBCCR();
            List<Dolar> lista = (List<Dolar>)service.GetDolar(DateTime.Now, DateTime.Now, "v");
            TipoCambio = lista.ElementAt(0).Monto;
            return salarioFinal / TipoCambio;
        }

    }
}
