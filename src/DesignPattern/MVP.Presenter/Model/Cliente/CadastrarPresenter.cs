using System;
using MVP.View.Model.Cliente;

namespace MVP.Presenter.Model.Cliente
{
    public class CadastrarPresenter
    {
        private ICadastrarView _view;
        public CadastrarPresenter(ICadastrarView view)
        {
            _view = view;
        }

        public void Limpar()
        {
            _view.Nome = string.Empty;
            _view.Email = string.Empty;
            _view.Telefone = string.Empty;
            _view.DataNascimento = DateTime.Now;
        }

        public void Cadastrar()
        {
          var cliente = new MVP.Model.Cliente("Adriano","011881260484",DateTime.Now);
            _view.Mensagem = string.Format("Cliente {0} cadastrado com sucesso!",cliente.Nome);

#warning "Implementar o padrão de acesso a dadoos"
        }
    }
}