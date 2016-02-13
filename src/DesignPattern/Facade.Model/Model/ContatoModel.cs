using Facade.Model.Model.Base;
using System;

namespace Facade.Model.Model
{
    // uma classe quando não tem nada na frente não é private é internal.
    // coocando classes como sealed ajuda a CLR a otimizar o aceso a classe.
    public sealed class ContatoModel : BaseModel
    {
        public Int32 CodigoSexo { get; set; }
        public Int32 CodigoEstadoCivil { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivilModel Estado { get; set; }
        public SexoModel Sexo { get; set; }
    }
}