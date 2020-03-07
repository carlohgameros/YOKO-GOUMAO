using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YOKO.Models;
using YOKO.ViewModels.Commands;
using YOKO.ViewModels.Services;

namespace YOKO.ViewModels
{
    public class ServicesViewModel : INotifyPropertyChanged
    {
        //Properties
        public Service service { get; set; }
        
        public ServicesViewModel()
        {
            var serviceModel = new ServiceModel();
            serviceModel.PropertyChanged += this.ServicesPropertyChanged;
            ServicesList = serviceModel.services;
        }

        #region Commands

        private ICommand _addToListCommand;
        public ICommand AddToListCommand
        {
            get
            {
                if (_addToListCommand == null)
                    _addToListCommand = new AddToList(this);
                return _addToListCommand;
            }
        }

        private ICommand _titleChangedCommand;
        public ICommand TitleChangedCommand
        {
            get
            {
                if (_titleChangedCommand == null)
                    _titleChangedCommand = new ServiceChanged(this);
                return _titleChangedCommand;
            }
        }

        private ObservableCollection<Service> _servicesList;
        public ObservableCollection<Service> ServicesList
        {
            get => _servicesList;

            set
            {
                _servicesList = value;
                _servicesList.CollectionChanged += new NotifyCollectionChangedEventHandler(ServicesCollectionChanged);
            }
        }

        #endregion

        #region Propery Changed Handlers

        void ServicesPropertyChanged(object sender, PropertyChangedEventArgs e) => this.ServicesList = (ObservableCollection<Service>)sender;

        void ServicesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e) => NotifyPropertyChanged("Services");

        private void NotifyPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        #region Methods

        public void Execute(object sender, object parameter) => ((ICommand)sender).Execute(parameter);

        #endregion
    }
}
