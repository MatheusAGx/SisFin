using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Conta
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public Categoria categoria { get; set; }
        public TipoConta tipoConta { get; set; }
        public bool status { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Conta conta &&
                   id == conta.id &&
                   descricao == conta.descricao &&
                   EqualityComparer<Categoria>.Default.Equals(categoria, conta.categoria) &&
                   tipoConta == conta.tipoConta &&
                   status == conta.status;
        }

        public override int GetHashCode()
        {
            int hashCode = -1408687769;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descricao);
            hashCode = hashCode * -1521134295 + EqualityComparer<Categoria>.Default.GetHashCode(categoria);
            hashCode = hashCode * -1521134295 + tipoConta.GetHashCode();
            hashCode = hashCode * -1521134295 + status.GetHashCode();
            return hashCode;
        }
    }
}
