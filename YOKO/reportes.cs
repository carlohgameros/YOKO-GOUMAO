using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using System.Data.SqlClient;

namespace YOKO
{
    public partial class reportes : Form
    {
        SqlConnection conn = new SqlConnection();

        public reportes()
        {
            InitializeComponent();
            
            test();
        }

        private void test()
        {
            var datos = new[] { 3, 4, 6, 8, 11, 13, 15, 15, 13, 10, 6, 4 };
            Console.WriteLine();
            IObservable<int> flujoDatos = datos.ToObservable();
            flujoDatos.Subscribe(
                onNext: dato => { Console.Write($"{dato}, "); },
                onCompleted: () => { Console.WriteLine("\nTest"); }).Dispose();
        }

        private void reportes_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = ConnectionString.connectionString;
        }
    }
}
