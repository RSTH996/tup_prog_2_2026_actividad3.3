using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases.Campo.Actividades
{
    abstract class Ganadera:Actividad
    {
        public int CantidadCabezas;

        public Ganadera(int periodo, string descripcion, int cantidad) : base(periodo, descripcion) {
            CantidadCabezas = cantidad;
        }
    }
}
