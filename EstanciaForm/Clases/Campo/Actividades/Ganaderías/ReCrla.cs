using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases.Campo.Actividades.Ganaderías
{
    class ReCrla : Ganadera
    {
        public int CantidadKilosCarneFinal;

        public ReCrla(int periodo, string descripcion, int cantidad) : base(periodo, descripcion, cantidad) {}

        public override double CalcularProduccion(){
            return CantidadKilosCarneFinal = base.CantidadCabezas * 132;
        }
        public override double CalcularRendimiento(){
            return CantidadKilosCarneFinal = CantidadKilosCarneFinal / base.Periodo;
        }
    }
}
