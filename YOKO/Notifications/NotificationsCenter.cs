using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YOKO.Properties;

namespace YOKO.Notifications
{
    public class NotificationsCenter
    {
        public static NotifyIcon notifyIcon;

        public NotificationsCenter(NotifyIcon notifyIconFromForm)
        {
            notifyIcon = notifyIconFromForm;
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(DisposeNotifyIcon);
        }

        public void DisposeNotifyIcon(object sender, EventArgs e)
        {
            notifyIcon.Dispose();
        }
    }
}
