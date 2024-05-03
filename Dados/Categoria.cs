using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Categoria
    {
        public int id { get; set; }
        public string nome { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Categoria categoria &&
                   nome == categoria.nome;
        }

        public override int GetHashCode()
        {
            return 109702896 + EqualityComparer<string>.Default.GetHashCode(nome);
        }
    }
}
