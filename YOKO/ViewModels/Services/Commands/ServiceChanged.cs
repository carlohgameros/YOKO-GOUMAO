using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YOKO.Models;

namespace YOKO.ViewModels.Commands
{
    class ServiceChanged : ICommand
    {
        public ServicesViewModel servicesViewModel;
        public event EventHandler CanExecuteChanged;

        public ServiceChanged(ServicesViewModel servicesViewModel) => this.servicesViewModel = servicesViewModel;
        public void Execute(object parameter) => this.servicesViewModel.service = (Service)parameter;
        public bool CanExecute(object parameter) => throw new NotImplementedException();
    }
}