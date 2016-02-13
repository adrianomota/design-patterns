using MVVM.ViewModel.Events;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MVVM.ViewModel.Annotations;

namespace MVVM.ViewModel.Cliente
{
    //Aqui ficaria toda a programação da Tela.
    //MODEL são das dados que vão ou vem das tabelas
    //VIEWMODEL são dados que vão ou vem da tela.

    //Tecnicas Específicas:

    //Binding - sincronização de dados
    //Commands - Eventos (click do botão)
    //Notifications - Mandando um sinal (notificação para a tela)

    public sealed class CadastrarViewModel:INotifyPropertyChanged
    {
        #region Constructor
        public CadastrarViewModel()
        {
            Click_Limpar = new DispararClick(Limpar);
            Click_Cadastrar = new DispararClick(Cadastrar);
        }
        #endregion

        #region Properties

        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;

                PropertyChanged(this,new PropertyChangedEventArgs("Nome"));
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }


        private string _telefone;
        public string Telefone {
            get
            {
                return _telefone;
            }

            set
            {
                _telefone = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Telefone"));
            }
        }

        private DateTime? _dataNascimento;

        public DateTime? DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
            set
            {
                _dataNascimento = value;
                PropertyChanged(this, new PropertyChangedEventArgs("DataNascimento"));
            }
        }

        #endregion Properties

        #region Commands

        public ICommand Click_Limpar { get; set; }

        public ICommand Click_Cadastrar { get; set; }

        public void Limpar()
        {
            Nome = string.Empty;
            Email = string.Empty;
            Telefone = string.Empty;
        }

        public void Cadastrar()
        {
            //lógica para inserir o cliente no BD
            var cliente = new Model.Cliente(Nome, Email,Telefone, DataNascimento);

            Debug.WriteLine(cliente.Nome);
            Debug.WriteLine(cliente.Email);
            Debug.WriteLine(cliente.Telefone);
            Debug.WriteLine(cliente.DataNascimento.Value.ToShortDateString());
        }

        #endregion Commands

        #region NotifyEvent
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion 
    }
}