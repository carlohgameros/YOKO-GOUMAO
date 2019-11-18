using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Helpers;
using YOKO.Models;
using YOKO.ViewModels;

namespace YOKO
{
    public partial class ServicesWatcher : Form
    {
        private ServicesViewModel servicesViewModel;

        public ServicesWatcher(List<Service> service) => servicesViewModel = new ServicesViewModel();

        private void ServicesWatcher_Load(object sender, EventArgs e)
        {
            BaseTableDesiner.SetDefaultStyle(servicesDataGrid);
            servicesViewModel.PropertyChanged += new PropertyChangedEventHandler(ServicesChanged);
        }

        private void BindDataGridView()
        {
            var binding = new BindingSource();
            binding.DataSource = servicesViewModel.ServicesList;
            servicesDataGrid.DataSource = binding;
        }

        void ServicesChanged(object sender, PropertyChangedEventArgs e)
        {
            BindDataGridView();
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
