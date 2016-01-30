using System;
using System.Collections.Generic;
using MVP.Model;
using MVP.Presenter.Model.Cliente;
using MVP.View.Model.Cliente;

namespace WebApp.UI.MVP.Model.Clientes
{
    public partial class Listar : System.Web.UI.Page,IListarView
    {
        private ListarPresenter _listarPresenter
            ;
        protected void Page_Load(object sender, EventArgs e)
        {
            _listarPresenter =new ListarPresenter(this);
        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            _listarPresenter.Carregar();
        }

        public ICollection<Cliente> Clientes
        {
            get
            {
                return GridView1.DataSource as ICollection<Cliente>;
            }
            set
            {
                GridView1.DataSource = value; 
                GridView1.DataBind();
            }
        }
    }
}