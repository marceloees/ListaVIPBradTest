using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaVIP
{
    public class IngressoVip : Ingresso
    {
        private double valorAdicional;

        public IngressoVip(double valor, double valorAdicional) : base(valor)
        {
            this.valorAdicional = valorAdicional;
        }

        public override string ToString()
        {
            double valorTotal = valor + valorAdicional;
            return $"Ingresso VIP com valor: R${valorTotal:F2} (Valor do Ingresso: R${valor:F2}, Valor Adicional: R${valorAdicional:F2})";
        }

    }
}
