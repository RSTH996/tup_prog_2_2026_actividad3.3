using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases
{
    abstract class Actividad
    {
        public int Periodo;
        public string Descripcion;
        private List<Parcela> lotesAsignados = new List<Parcela>();

        public Actividad(int periodo, string descipcion) {
            Periodo = periodo;
            Descripcion = descipcion;
        }
        public double CalcularSuperficieOcupada() {
            double parcelaTotal = 0;
            foreach (Parcela p in lotesAsignados) {
                parcelaTotal += p.Superficie;
            }
            return parcelaTotal;
        }
        public abstract double CalcularRendimiento();
        public abstract double CalcularProduccion();

        public override string ToString()
        {
            return $"Lote de {Descripcion} con periodo de {Periodo} años";
        }
    }
}
