using System;
using System.Windows.Input;

namespace Lands.ViewModels
{
    internal class RelayCommands : ICommand
    {
        private object login;

        public RelayCommands(object login)
        {
            this.login = login;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}