using System;
using System.Collections.Generic;

namespace Builder.Model.Builders
{
    public sealed class ClienteBuilder
    {
        private Cliente _novoCliente = new Cliente();

        public ClienteBuilder()
        {
            _novoCliente.Fotos = new List<Foto>();
            _novoCliente.Telefones = new List<Telefone>();
        }

        public ClienteBuilder SetarDadosPessoais(string nome_, string email_, DateTime dataNascimento_)
        {
            _novoCliente.Nome = nome_;
            _novoCliente.Email = email_;
            _novoCliente.DataNascimento = dataNascimento_;

            return this;
        }

        public ClienteBuilder SetarEndereco(string endereco_, string numero_,string cep_)
        {
            _novoCliente.CEP = cep_;
            _novoCliente.Endereco = endereco_;
            _novoCliente.Numero = numero_;

            return this;
        }

        public ClienteBuilder SetarTelefone(string ddd_, string numero_, string operadora_)
        {
            _novoCliente.Telefones.Add(new Telefone()
            {
                DDD = ddd_,
                Numero = numero_,
                Operadora = operadora_
            });

            return this;
        }

        public ClienteBuilder SetarFoto(string caminho_, string nome_, string extensao_)
        {
            _novoCliente.Fotos.Add(new Foto()
            {
                Nome = nome_,
                Caminho = caminho_,
                Extensao = extensao_
            });

            return this;
        }

        public Cliente Gerar()
        {
            return _novoCliente;
        }
    }
}