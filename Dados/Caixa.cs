using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Caixa
    {
        public int id { get; set; }
        public string nome { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Caixa caixa &&
                   id == caixa.id &&
                   nome == caixa.nome;
        }

        public override int GetHashCode()
        {
            int hashCode = 227894096;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            return hashCode;
        }
    }
}
