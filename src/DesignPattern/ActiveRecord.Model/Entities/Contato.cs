using ActiveRecord.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ActiveRecord.Model
{
    public sealed class Contato : EntityBase, IBaseModel<Contato>
    {
        private readonly ActiveRecordContext _context;

        private Contato(){}

        public Contato(string nome_, string email_, string telefone_, DateTime dataNascimento_)
        {
            Nome = nome_;
            Email = email_;
            Telefone = telefone_;
            DataNascimento = dataNascimento_;

            _context = new ActiveRecordContext();
        }

        public Int32 CodigoSexo { get; private set; }
        public Int32 CodigoEstadoCivil { get; private set; }
        public String Nome { get; private set; }
        public String Email { get; private set; }
        public String Telefone { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public Sexo Sexo { get; private set; }

        public void AlterarNome(string value_)
        {
            Nome = value_;
        }

        public void AlterarEmail(String value_)
        {
            Email = value_;
        }

        public void AlterarTelefone(string value_)
        {
            Telefone = value_;
        }

        public void AlterarDataNascimento(DateTime value_)
        {
            DataNascimento = value_;
        }

        public void AssociarSexo(int idSexo_)
        {
            CodigoSexo = idSexo_;
        }

        public void AssociarEstadoCivil(int idEstadoCivil)
        {
            CodigoEstadoCivil = idEstadoCivil;
        }

        public IEnumerable<Contato> Pesquisar(Expression<Func<Contato, bool>> predicate)
        {
            return _context.Contato.Where(predicate);
        }

        public IEnumerable<Contato> Listar()
        {
            return _context.Contato.ToList();
        }

        public void Cadastrar()
        {
           
            //graças aos Data Annotations conseguimos fazer validações sem IFs, sem Data Annotations, tem que fazer If(Braçal)

            //A classe ValidationContext dispara as anotações de 1 determinada classe (this)
            var contexto = new ValidationContext(this);

            //cada campo que nao foi devidamente preenchido, ele retorna 1 erro = ValidationResult
            var erros = new List<ValidationResult>();

            //Disparamos as validacoes
            Validator.TryValidateObject(this, contexto, erros);

            if (!erros.Any())
            {
                //o this é a palavra de Contexto para pegar a classe corrente
                //this -> filha = classe corrente
                //base -> classe pai

                _context.Contato.Add(this);
                _context.SaveChanges();
            }

         
        }

        public void Atualizar()
        {
            _context.Entry(this).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar()
        {
            _context.Entry(this).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}