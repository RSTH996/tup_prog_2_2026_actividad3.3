using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases
{
    class Campos
    {
        string Identificador;
        double SuperficieTotal;
        public readonly int Cantidadparcelas;

        private List<Parcela> parcelas = new List<Parcela>();

        public Campos(string identificador, double superficie) {
            Identificador = identificador;
            SuperficieTotal += superficie;
        }

        public bool CrearParcela(string Identificador, double Superficie) {
            bool verificacion = false; //crear verificador
            if (BuscarParcela(Convert.ToInt32(Identificador)) >= 0 && Superficie < SuperficieOcupadaTotal()) {
                Parcela p = new Parcela(Superficie); //añadir superficie
                p.Numero = Convert.ToInt32(Identificador); //añadir numero de identificacion
                parcelas.Add(p); //se añade el objeto
                verificacion = true; //finaliza verificador
            }
            return verificacion;
        }
        public Parcela VerParcela(int idx) {            
            return parcelas[idx];
        }
        private double SuperficieOcupadaTotal() {
            return SuperficieTotal;
        }
        public int BuscarParcela(int identificador) {
            Parcela busqueda = new Parcela(0);
            busqueda.Numero = Convert.ToInt32(Identificador);
            int orden = parcelas.BinarySearch(busqueda);
            return orden;
        }
        public List<Parcela> ParcelasDisponibles() {
            List<Parcela> retorno = new List<Parcela>(parcelas.Count);
            for (int i = 0; i <retorno.Count; i++)
            {
                retorno.Add(parcelas[i]);
            }
            return retorno;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
