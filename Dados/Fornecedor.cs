using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public TipoPessoa tipoFornecedor { get; set; }
        public string cpf_cnpj { get; set; }
        public string razao_social { get; set; }
        public string nome { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Fornecedor fornecedor &&
                   Id == fornecedor.Id &&
                   tipoFornecedor == fornecedor.tipoFornecedor &&
                   cpf_cnpj == fornecedor.cpf_cnpj &&
                   razao_social == fornecedor.razao_social &&
                   nome == fornecedor.nome &&
                   rua == fornecedor.rua &&
                   numero == fornecedor.numero &&
                   bairro == fornecedor.bairro &&
                   cidade == fornecedor.cidade &&
                   complemento == fornecedor.complemento &&
                   cep == fornecedor.cep &&
                   telefone == fornecedor.telefone &&
                   celular == fornecedor.celular &&
                   email == fornecedor.email;
        }

        public override int GetHashCode()
        {
            int hashCode = -1065692353;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + tipoFornecedor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf_cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(razao_social);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rua);
            hashCode = hashCode * -1521134295 + numero.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cidade);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(celular);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            return hashCode;
        }
    }
}
