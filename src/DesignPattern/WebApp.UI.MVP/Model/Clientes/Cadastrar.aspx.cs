using System;
using System.Globalization;
using System.Web.UI;
using MVP.Presenter.Model.Cliente;
using MVP.View.Model.Cliente;

namespace WebApp.UI.MVP.Model.Clientes
{
    public partial class Cadastrar : Page, ICadastrarView
    {
        private CadastrarPresenter _cadastrarPresenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _cadastrarPresenter = new CadastrarPresenter(this);
        }

        public string Nome
        {
            get { return txtNome.Text; }
            set { txtNome.Text = value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        public string Telefone
        {
            get { return txtEmail.Text; }
            set { txtTelefone.Text = value; }
        }

        public DateTime DataNascimento
        {
            get { return Convert.ToDateTime(txtDataNascimento.Text); }
            set { txtDataNascimento.Text = value.ToString(CultureInfo.InvariantCulture); }
        }


        public string Mensagem
        {
           set
            {
                Response.Write("<script>alert('"+value+"');</script>");      
            }
        }

        protected void btncadastrar_Click(object sender, EventArgs e)
        {
            _cadastrarPresenter.Cadastrar();
           
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            _cadastrarPresenter.Limpar();
        }
    }
}