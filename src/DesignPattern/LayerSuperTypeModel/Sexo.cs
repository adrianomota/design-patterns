using System;

namespace LayerSuperTypeModel
{
    public sealed class Sexo:BaseModel
    {
        private Sexo(){}

        public Sexo(string descricao)
        {
            Descricao = descricao;
        }
        public string Descricao { get; private set; }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public override void ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(Descricao))
            {
                throw new ApplicationException("Campo Descrição obrigatório!");
            }

            base.ValidarCamposObrigatorios();
        }
    }
}