using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases.Campo.Actividades
{
    class Agricola:Actividad
    {
        public int CantidadToneladasCosechas;
        public double PrecioTonelada;

        public Agricola(int periodo, string descripcion):base(periodo, descripcion) {}
        public override double CalcularRendimiento() {
            return CantidadToneladasCosechas * PrecioTonelada;
        }
        public override double CalcularProduccion(){
            return CantidadToneladasCosechas * PrecioTonelada;
        }
    }
}
