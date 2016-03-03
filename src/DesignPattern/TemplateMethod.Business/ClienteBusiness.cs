using System.Diagnostics;
using System.Net.WebSockets;
using TemplateMethodModel;

namespace TemplateMethod.Business
{
    public sealed class ClienteBusiness:BaseBusiness<Cliente>
    {
        protected override bool ValidarCamposObrigatorios(Cliente obj)
        {
            bool retorno = !string.IsNullOrWhiteSpace(obj.Nome);

            return retorno;
        }

        protected override void Cadastrar(Cliente obj)
        {
            Debug.WriteLine("Cliente cadastrado com sucesso!");
        }
    }
}