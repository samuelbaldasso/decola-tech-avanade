using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Cliente cliente) : base(cliente)
        {
            ValorPercentualRendimento = 0.005M;
        }
        public decimal ValorPercentualRendimento { get; private set; }
    }
}
