using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//invocacion de carpetas de clases
using EstanciaForm.Clases.Campo.Actividades;
using EstanciaForm.Clases.Campo.Actividades.Ganaderías;

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

        public Estancia(string nombreEstancia, Campos campo) {
            this.Nombre = nombreEstancia;
            campos.Add(campo);
        }
        public bool AltaActividad(int Actividad) {
            return false;
        }
        public Campos VerCampo(int idx) {
            return (Campos)campos[idx];
        }
        public Actividad AgregarActividad(int periodo, string descripcion, int tipo) {
            Actividad a = new Agricola(0," ");
            switch (tipo) { 
                case 1:
                    a = new Agricola(periodo, descripcion);
                    break;
                case 2:
                    a = new Crla(periodo, descripcion, tipo);
                    break;
                case 3:
                    a = new Ivernada(periodo, descripcion, tipo);
                    break;
                case 4:
                    a = new ReCrla(periodo, descripcion, tipo);
                    break;
            }
            actividades.Add(a);
            return a;
        }
        public Puesto AgregarPuesto(string encargado) {
            Puesto p = new Puesto();
            p.Encargado = encargado;
            puestos.Add(p);
            return p;
        }
    }
}
