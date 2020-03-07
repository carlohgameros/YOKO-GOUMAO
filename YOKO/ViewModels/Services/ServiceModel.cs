using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.Models;

namespace YOKO.ViewModels.Services
{
    public class ServiceModel : INotifyPropertyChanged
    {
        public ObservableCollection<Service> services { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private DataAccess dataAccess = new DataAccess();

        public ServiceModel()
        {
            services = dataAccess.Select();
            dataAccess.DatabaseUpdated += new DataAccess.UpdateHandler(UpdateFromDataAccess);
            services.CollectionChanged += new NotifyCollectionChangedEventHandler(ServicesChanged);
        }

        void ServicesChanged(object sender, NotifyCollectionChangedEventArgs e) => dataAccess.Update(services);

        private void UpdateFromDataAccess(ObservableCollection<Service> list)
        {
            services = list;
            services.CollectionChanged += new NotifyCollectionChangedEventHandler(ServicesChanged);
            PropertyChanged?.Invoke(services, null);
        }
    }
}
