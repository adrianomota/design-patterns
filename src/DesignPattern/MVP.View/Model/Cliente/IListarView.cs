using System.Collections.Generic;

namespace MVP.View.Model.Cliente
{
    public interface IListarView
    {
        ICollection<MVP.Model.Cliente> Clientes { get; set; }
    }
}