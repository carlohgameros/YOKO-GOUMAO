using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YOKO.Helpers;
using YOKO.Models;
using YOKO.Notifications;

namespace YOKO
{
    public partial class changeButton : Form
    {
        Match match = null;
        SQL sqlHelper = new SQL();
        SMTPServer sMTPServer = new SMTPServer();
        SqlConnection sqlConnection = new SqlConnection();
        Dictionary<int, string> mailsDenied = new Dictionary<int, string>();
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Dictionary<int, string> mailsAccepted = new Dictionary<int, string>();
        List<MailSubscription> mailSubscriptions = new List<MailSubscription>();

        const string SQL_QUERY = "select ClienteID, Email, Subscrito from tblClientes where Email != ''";
        string clientMail = "";
        string clientID = "";

        public changeButton() => InitializeComponent();

        private void CreateWebMail_Load(object sender, EventArgs e)
        {
            FilterDictionary(sqlHelper.GetDictionaryFromSQL(SQL_QUERY));
            BaseTableDesiner.SetDefaultStyle(mailsApprovedDataGrid);
            BaseTableDesiner.SetDefaultStyle(mailsDeniedDataGrid);
        }

        private void FilterDictionary(List<MailSubscription> mailSubscriptions)
        {
            this.mailSubscriptions = mailSubscriptions;

            foreach(MailSubscription mail in mailSubscriptions)
            {
                match = regex.Match(mail.email);
                
                if (match.Success)
                {
                    if (mail.subscribted)
                    {
                        mailsAccepted.Add(mail.id, mail.email);
                    }
                    else
                    {
                        mailsDenied.Add(mail.id, mail.email);
                    }
                }
            }

            SetDataSource(mailsAccepted, mailsApprovedDataGrid);
            SetDataSource(mailsDenied, mailsDeniedDataGrid);
        }

        private void SetDataSource(Dictionary<int, string> mails, DataGridView dataGridView)
        {
            if (mails.Count <= 0)
            {
                dataGridView.Visible = false;
                return;
            }

            var accepted = new BindingSource();
            accepted.DataSource = mails;
            dataGridView.DataSource = accepted;

            dataGridView.AutoGenerateColumns = true;
            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Correo";
            dataGridView.AutoResizeColumns();
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }  

        private void ClearDataSource()
        {
            mailsAccepted.Clear();
            mailsDenied.Clear();
            mailsApprovedDataGrid.DataSource = null;
            mailsApprovedDataGrid.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mailsApprovedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clientMail = mailsApprovedDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                clientID = mailsApprovedDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (clientMail != null) buttonChange.Enabled = true;
                buttonChange.ButtonText = "Modificar " + clientMail;
            }
            catch { }
        }

        private void mailsDeniedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clientMail = mailsDeniedDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                clientID = mailsDeniedDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (clientMail != null) buttonChange.Enabled = true;
                buttonChange.ButtonText = "Modificar " + clientMail;
            }
            catch { }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (clientID == "" || clientMail == "") return;

            MailSubscription subscription = mailSubscriptions.Where(mail => mail.id.ToString() == clientID).First();

            bool subscriptionStatus = !subscription.subscribted;
            bool result = sqlHelper.ExecuteSQLCommand
                ("update tblClientes set Subscrito = " + Convert.ToInt32(subscriptionStatus) + " where ClienteID = " + subscription.id);

            if (result)
            {
                HandleDictionaryUpdate();

                clientID = "";
                clientMail = "";
                buttonChange.ButtonText = "Selecciona un usuario para cambiar";
                buttonChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                buttonChange.Enabled = false;

                //NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "¡Listo!", "Subscripción actualizada.", ToolTipIcon.Error);
            }
            else
            {
                //NotificationsCenter.notifyIcon.ShowBalloonTip(1000, "Error al cambiar de subscripcion", "Verifica la conexión a la Base de Datos.", ToolTipIcon.Error);
            }
        }

        private void HandleDictionaryUpdate()
        {
            ClearDataSource();
            FilterDictionary(sqlHelper.GetDictionaryFromSQL(SQL_QUERY));
        }

        private void mailsApprovedDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            mailsApprovedDataGrid.ClearSelection();
            mailsApprovedDataGrid.Rows[e.RowIndex].Selected = true;
        }

        private void mailsDeniedDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            mailsDeniedDataGrid.ClearSelection();
            mailsDeniedDataGrid.Rows[e.RowIndex].Selected = true;
        }

        private void mailsApprovedDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }
    }
}
