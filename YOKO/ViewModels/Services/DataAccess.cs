using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YOKO.Models;

namespace YOKO.ViewModels.Services
{
    public class DataAccess
    {
        private readonly Random _random = new Random();
        private int _counter;

        public DataAccess()
        {
            
        }

        public static ObservableCollection<Service> Data = new ObservableCollection<Service>();

        public ObservableCollection<Service> Select()
        {
            var temp = new ObservableCollection<Service>();

            foreach (Service service in Data)
            {
                temp.Add(service);
            }

            return temp;
        }

        public void Update(ObservableCollection<Service> data)
        {
            Data = new ObservableCollection<Service>();

            foreach (Service service in data)
            {
                Data.Add(service);
            }

            if (DatabaseUpdated != null)
                DatabaseUpdated(Data);
        }

        public delegate void UpdateHandler(ObservableCollection<Service> list);
        public UpdateHandler DatabaseUpdated;
    }
}
