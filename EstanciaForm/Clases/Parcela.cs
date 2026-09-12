using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaForm.Clases
{
    class Parcela:IComparable
    {
        public int Numero;
        public double Superficie;

        public Parcela(double superficie) {
            Superficie = superficie;
        }
        public int CompareTo(object obj)
        {
            // Idea A
            if (obj == null) return -1;
            Parcela i = obj as Parcela;
            return this.Numero.CompareTo(i.Numero);
            /*
             * Idea B
            if (obj != null && obj is Parcela)
            return this.Numero.CompareTo(((Parcela)obj).Numero));  //Menor a Mayor
            return (((Parcela)obj).Numero).CompareTo(this.Numero); //Mayor a Menor
            else 
            return 0;
             */
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
