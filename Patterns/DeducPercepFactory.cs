using Octopus.Enum;
using Octopus.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octopus.Patterns
{
    internal class DeducPercepFactory
    {
        public DeducPercep CrearDeducPercep(int id,string nombre, Tipo tipo, TipoValor tipoValor, double valor)
        {
            return new DeducPercep()
            {
                ID= id,
                Nombre = nombre,
                tipo = tipo,
                tipoValor = tipoValor,
                Valor = valor
            };
        }
    }
}
