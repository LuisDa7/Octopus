using Newtonsoft.Json;
using Octopus.Interfaces;
using Octopus.Layers.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Octopus.Layers.Entities
{
    public class Marcas
    {
        public int ID { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Salida { get; set; }
        public DateTime Fecha { get; set; }
        public double CantHoras { get; set; }

        public static List<Marcas> Cargar(string ruta)
        {
            string json = System.IO.File.ReadAllText(ruta);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            List<Marcas> lista = JsonConvert.DeserializeObject<List<Marcas>>(json, settings);
            return lista;
        }

        public static void GenerarJSONs()
        {
            DateTime lunesInicio = new DateTime(2024, 5,27);
            DateTime viernesFinal = new DateTime(2024, 5, 31);
            DateTime ciclo = lunesInicio;
            Random rnd = new Random();
            List<Marcas> listaMarcas = new List<Marcas>();
            List<IColaborador> listaColab;
            try
            {
                listaColab = ColaboradorBLL.ListaCompleta();
            }
            catch (Exception)
            {

                throw;
            }
            string nombre ="";
            while (ciclo <= viernesFinal)
            {
                if (ciclo.DayOfWeek == DayOfWeek.Monday)
                {
                    nombre = ciclo.Day.ToString() + ciclo.ToString("MMMM");
                }
                foreach (IColaborador colab in listaColab)
                {
                    DateTime fechaEntrada = ciclo;
                    fechaEntrada = fechaEntrada.AddHours(6).AddMinutes(50);
                    fechaEntrada = fechaEntrada.AddMinutes(rnd.Next(0, 20));

                    DateTime fechaSalida = ciclo;
                    fechaSalida = fechaSalida.AddHours(16).AddMinutes(50);
                    fechaSalida = fechaSalida.AddMinutes(rnd.Next(0, 20));

                    double cantHoras = CalcularHorasTrabajadas(fechaEntrada, fechaSalida);
                    cantHoras = Convert.ToDouble(cantHoras.ToString("F2"));
                    Marcas marca = new Marcas()
                    {
                        ID = colab.ID,
                        Fecha = ciclo,
                        Entrada = fechaEntrada,
                        Salida = fechaSalida,
                        CantHoras = cantHoras
                    };
                    listaMarcas.Add(marca);
                }
                if (ciclo.DayOfWeek == DayOfWeek.Friday)
                {
                    nombre += ciclo.Day.ToString() + ciclo.ToString("MMMM");
                    string ruta = Application.StartupPath + @"\JSON\"+nombre+".json";
                    string json = JsonConvert.SerializeObject(listaMarcas);
                    listaMarcas = new List<Marcas>();

                    try
                    {
                        File.WriteAllText(ruta, json);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    ciclo = ciclo.AddDays(3);
                }
                else
                {
                    ciclo = ciclo.AddDays(1);
                }
            }

            
        }

        public static bool HayVacios(List<Marcas> lista)
        {
            foreach (Marcas item in lista)
            {
                if (item.Entrada == null && item.Salida == null)
                {
                    continue;
                }
                else if (item.Entrada == null)
                {
                    return true;
                }
                else if (item.Salida == null)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Marcas> CorregirAusencias(List<Marcas> lista)
        {
            foreach (Marcas item in lista)
            {
                if (item.Entrada == null && item.Salida == null)
                {
                    item.CantHoras = 0;
                }
                else if(item.Entrada == null)
                {
                    item.Entrada = new DateTime(item.Salida.Value.Year,item.Salida.Value.Month,
                        item.Salida.Value.Day,7,0,0);
                    item.CantHoras = CalcularHorasTrabajadas(item.Entrada.Value, item.Salida.Value);
                }
                else if(item.Salida == null)
                {
                    item.Salida = new DateTime(item.Entrada.Value.Year, item.Entrada.Value.Month,
                        item.Entrada.Value.Day,17, 0, 0);
                    item.CantHoras = CalcularHorasTrabajadas(item.Entrada.Value, item.Salida.Value);
                }
            }
            return lista;
        }

        private static double CalcularHorasTrabajadas(DateTime? entrada, DateTime? salida)
        {
            TimeSpan diferencia = salida.Value - entrada.Value;
            return diferencia.TotalHours;
        }

        public static List<Marcas> CorregirHoras(List<Marcas> lista)
        {
            double decimales;
            double horas;
            foreach (Marcas item in lista)
            {
                horas = item.CantHoras;
                decimales = horas % 1;
                if ( decimales <= 0.25)
                {
                    item.CantHoras = horas - decimales;
                }
                else if (decimales <= 0.50)
                {
                    item.CantHoras = horas + (0.50 - decimales);
                }
                else if (decimales <= 0.75)
                {
                    item.CantHoras = horas - (decimales - 0.50);
                }
                else
                {
                    item.CantHoras = (horas - decimales)+1;
                }
            }
            return lista;
        }
    }

    
}
