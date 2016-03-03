using ActiveRecord.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ActiveRecord.Model
{
    public sealed class Contato : EntityBase, IBaseModel<Contato>
    {
        private readonly ActiveRecordContext _context;

        private Contato()
        {
            _context = new ActiveRecordContext();
        }

        public Contato(string nome_, string email_, string telefone_, DateTime dataNascimento_)
        {
            Nome = nome_;
            Email = email_;
            Telefone = telefone_;
            DataNascimento = dataNascimento_;
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

        public IEnumerable<Contato> Listar()
        {
            return _context.Contato.ToList();
        }

        public void Cadastrar()
        {
            //var contexto = new ValidationContext(this);
            //var erros = new List<ValidationResult>();
            _context.Contato.Add(this);
            _context.SaveChanges();
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