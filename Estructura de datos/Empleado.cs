using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_datos
{
    public class Empleado
    {   
        //Propiedades para la pila
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public decimal SalarioDia { get; set; }
        public int  DíasLaborados { get; set; }
        public decimal Devengado { get; set; }

        public decimal CalcularDevengado(decimal SalarioDia, int DiasLaborados)
        {
            Devengado = (SalarioDia * DiasLaborados);
            return Devengado;
        }
    }
}
