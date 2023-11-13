using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVIP
{
    public class Ingresso
    {
        protected double valor;

        public Ingresso(double valor)
        {
            this.valor = valor;
        }

        public override string ToString()
        {
            return $"Ingresso com valor: R${valor:F2}";
        }
    }
}
