using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YOKO.Models;

namespace YOKO.ViewModels.Commands
{
    public class AddToList : ICommand
    {
        public ServicesViewModel servicesViewModel { get; set; }
        public event EventHandler CanExecuteChanged;

        public AddToList(ServicesViewModel servicesViewModel) => this.servicesViewModel = servicesViewModel;
        public void Execute(object parameter) => HandleLsit();
        public bool CanExecute(object parameter) => throw new NotImplementedException();

        private void HandleLsit()
        {
            if (servicesViewModel.service != null)
            {
                servicesViewModel.ServicesList.Add(item: servicesViewModel.service);
            }
        }
    }
}
