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
        private Service selectedService = null;

        public ServicesViewModel servicesViewModel { get; set; }

        public ServicesWatcher()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ServicesWatcher_Load);
            InitializeEventHandlers();
        }

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

        private void InitializeEventHandlers()
        {
            Load += (sender, e) =>
            {
                var binding = new BindingSource
                {
                    DataSource = servicesViewModel.ServicesList
                };

                servicesDataGrid.DataSource = binding;
                servicesViewModel.PropertyChanged += (o, eventArg) => BindDataGridView();
            };
        }

        private void servicesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = (int) servicesDataGrid.Rows[e.RowIndex].Cells[0].Value;
                selectedService = servicesViewModel.ServicesList[index];
            }
            catch { }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e) => selectedService.startService();

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            selectedService.finishService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            selectedService.cancelService();
        }
    }
}
