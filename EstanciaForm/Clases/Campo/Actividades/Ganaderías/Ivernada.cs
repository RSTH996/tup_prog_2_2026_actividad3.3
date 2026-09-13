using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases.Campo.Actividades.Ganaderías
{
    class Ivernada:Ganadera
    {
        public int CantidadKilosInicial;
        public int CantidadKilosFinal;
        public int PrecioKilo;

        public Ivernada(int periodo, string descripcion, int cantidad) : base(periodo, descripcion, cantidad) { }

        public override double CalcularProduccion()
        {
            return CantidadKilosFinal = CantidadKilosInicial / 2;
        }
        public override double CalcularRendimiento()
        {
            return CantidadKilosFinal = CantidadKilosFinal / PrecioKilo;
        }
    }
}
