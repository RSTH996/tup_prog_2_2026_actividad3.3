using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases.Campo.Actividades.Ganaderías
{
    class Crla:Ganadera
    {
        public int CantidadVacasMadres;
        public int CantidadTerrenosDestete;
        public double PrecioTerreno;

        public Crla(int periodo, string descripcion, int cantidad) : base(periodo,descripcion,cantidad) {}
        public override double CalcularProduccion()
        {
            return CantidadVacasMadres = base.CantidadCabezas * 132;
        }
        public override double CalcularRendimiento()
        {
            return CantidadTerrenosDestete = CantidadVacasMadres / base.Periodo;
        }
    }
}
