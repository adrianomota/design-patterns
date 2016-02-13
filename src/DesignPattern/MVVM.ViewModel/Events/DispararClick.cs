using System;
using System.Windows.Input;

namespace MVVM.ViewModel.Events
{
    public sealed class DispararClick : ICommand
    {
        private Action _metodo;

        public DispararClick(Action metodo_)
        {
            _metodo = metodo_;
        }

        //Habilita ou desabilita os botões.
        public bool CanExecute(object parameter)
        {
            return true;
        }


        //serve para executar (disparar) o comando
        public void Execute(object parameter)
        {
            _metodo();
        }

        public event EventHandler CanExecuteChanged;
    }
}