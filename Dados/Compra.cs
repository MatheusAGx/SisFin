using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
    {
        class Compra
        {
            public int id { get; set; }
            public DateTime instante { get; set; }
            public string descricao { get; set; }
            public double desconto { get; set; }
            public double valor_total { get; set; }

            public override bool Equals(object obj)
            {
                return obj is Compra compra &&
                       id == compra.id &&
                       instante == compra.instante &&
                       descricao == compra.descricao &&
                       desconto == compra.desconto &&
                       valor_total == compra.valor_total;
            }

            public override int GetHashCode()
            {
                int hashCode = -1890985869;
                hashCode = hashCode * -1521134295 + id.GetHashCode();
                hashCode = hashCode * -1521134295 + instante.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(descricao);
                hashCode = hashCode * -1521134295 + desconto.GetHashCode();
                hashCode = hashCode * -1521134295 + valor_total.GetHashCode();
                return hashCode;
            }
        }
    }
