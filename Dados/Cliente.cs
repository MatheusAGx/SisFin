using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Cliente
    {
        //Guid = numero de 16 bytes usado como identificador único
        public int id { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf_cnpj { get; set; }
        public DateTime dataNascimento { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public decimal limite { get; set; }

        public Cliente(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            this.id = id;
            this.tipoPessoa = tipoPessoa;
            this.nome = nome;
            this.email = email;
            this.cpf_cnpj = cpf_cnpj;
            this.dataNascimento = dataNascimento;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.complemento = complemento;
            this.cep = cep;
            this.telefone = telefone;
            this.celular = celular;
            this.limite = limite;
        }

        public Cliente()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   Id == cliente.Id &&
                   tipoPessoa == cliente.tipoPessoa &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email &&
                   cpf_cnpj == cliente.cpf_cnpj &&
                   dataNascimento == cliente.dataNascimento &&
                   rua == cliente.rua &&
                   numero == cliente.numero &&
                   bairro == cliente.bairro &&
                   complemento == cliente.complemento &&
                   cep == cliente.cep &&
                   telefone == cliente.telefone &&
                   email == cliente.email &&
                   celular == cliente.celular &&
                   limite == cliente.limite;
        }

        public override int GetHashCode()
        {
            int hashCode = 1797279552;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + tipoPessoa.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cpf_cnpj);
            hashCode = hashCode * -1521134295 + dataNascimento.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(rua);
            hashCode = hashCode * -1521134295 + numero.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bairro);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(complemento);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(celular);
            hashCode = hashCode * -1521134295 + limite.GetHashCode();
            return hashCode;
        }
    }
}
