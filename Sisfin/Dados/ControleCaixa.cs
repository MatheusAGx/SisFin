using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class ControleCaixa
    {
        public int id { get; set; }
        public ContaReceber contaReceber { get; set; }
        public ContaPagar contaPagar { get; set; }
        public Caixa caixa { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ControleCaixa caixa &&
                   id == caixa.id &&
                   EqualityComparer<ContaReceber>.Default.Equals(contaReceber, caixa.contaReceber) &&
                   EqualityComparer<ContaPagar>.Default.Equals(contaPagar, caixa.contaPagar) &&
                   EqualityComparer<Caixa>.Default.Equals(this.caixa, caixa.caixa) &&
                   valor == caixa.valor &&
                   data == caixa.data;
        }

        public override int GetHashCode()
        {
            int hashCode = 1572889066;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ContaReceber>.Default.GetHashCode(contaReceber);
            hashCode = hashCode * -1521134295 + EqualityComparer<ContaPagar>.Default.GetHashCode(contaPagar);
            hashCode = hashCode * -1521134295 + EqualityComparer<Caixa>.Default.GetHashCode(caixa);
            hashCode = hashCode * -1521134295 + valor.GetHashCode();
            hashCode = hashCode * -1521134295 + data.GetHashCode();
            return hashCode;
        }
    }
}
