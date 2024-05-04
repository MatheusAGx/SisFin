﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class FornecedorService
    {
        private FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email, string cpf_cnpj, DateTime dataNascimento, string rua, int numero, string bairro, string complemento, string cep, string telefone, string celular, decimal limite)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor();


            _repository.Insert(fornecedor);

        }

        public void Insert(Fornecedor Fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(fornecedor);

        }

        public Fornecedor FindById(int id)
        {
            foreach (Fornecedor c in _repository.getAll())
            {
                if (c.id == id) return c;
            }
            return null;
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Fornecedor> getAll()
        {
            return _repository.ObterTodos().ToList<Fornecedor>();
        }

    }
}