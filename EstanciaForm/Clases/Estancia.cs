using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases
{
    class Estancia
    {
        public string Nombre;
        public readonly int CantidadCampos;
        public readonly int CantidadActividad;
        public readonly int CantidadPuestos;

        private ArrayList campos = new ArrayList();
        private List<Actividad> actividades = new List<Actividad>();
        private List<Puesto> puestos = new List<Puesto>();
        Casco casco; 

        public Estancia(string nombreEstancia, Campo campo) {
            this.Nombre = nombreEstancia;
            campos.Add(campo);
        }
        public bool AltaActividad(int Actividad) {
            return false;
        }
        public Campo VerCampo(int idx) {
            return (Campo)campos[idx];
        }
        public Actividad AgregarActividad(int periodo, string descripcion, int tipo){
            Actividad a = new Actividad(periodo, descripcion);
            return actividades.Add(a);
        }
    }
}
