using System;
using System.Collections.Generic;
using MVP.View.Model.Cliente;

namespace MVP.Presenter.Model.Cliente
{
    public sealed class ListarPresenter
    {
        private IListarView _view;
        public ListarPresenter(IListarView view)
        {
            _view = view;
        }

        public void Carregar()
        {
#warning "Listando do banco"
            IList<MVP.Model.Cliente> listaClientes = new List<MVP.Model.Cliente>()
            {
                new MVP.Model.Cliente("Adriano Mota", "(011)9999-4444", DateTime.Now),
                new MVP.Model.Cliente("Gleyce Gonçalves", "(011)9999-4444", DateTime.Now),
                new MVP.Model.Cliente("Zina de Souza", "(011)9999-4444", DateTime.Now)
            };

            _view.Clientes = listaClientes;
        }
    }
}