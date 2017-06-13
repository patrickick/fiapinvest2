using System;
using System.Globalization;

namespace FiapInvest.Models
{
    public class SaldoFundo
    {
        public int IdSaldo { get; set; }
        public int IdCliente { get; set; }
        public int IdFundo { get; set; }
        public String NomeFundo { get; set; }
        public string Cor { get; set; }

        public double ValorSaldo { get; set; }
        public string ValorSaldoFormatado {
            get {
                //return string.Format("{0:N}", ValorSaldo) ;  // FORMATA NÚMERO
                //return string.Format("{0:C}", ValorSaldo);   // FORMATA MOEDA
                //return string.Format("{0:f}", ValorSaldo);   // FORMATA PONTO FIXO
                return string.Format("{0:p}", ValorSaldo);     // FORMATA PERCENTUAL
            }
        }
      
    }
}
