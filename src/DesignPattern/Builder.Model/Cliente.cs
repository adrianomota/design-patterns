using System;
using System.Collections.Generic;

namespace Builder.Model
{
    public sealed class Cliente
    {
        #region Informações Pessoais

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        #endregion Informações Pessoais

        #region Informações de localização

        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }

        #endregion Informações de localização



        #region Informações de Associações
        //IEnumerable - somente leitura
        //IList - Leitura - gravaçao e pesquisa
        //IQueriable - Lista de pesquisa e leitura
        //ICollection - alternativa ao IList
        public ICollection<Foto> Fotos { get; set; }

        public ICollection<Telefone> Telefones { get; set; }
        #endregion
    }
}