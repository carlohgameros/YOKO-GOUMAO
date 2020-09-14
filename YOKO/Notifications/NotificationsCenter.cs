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

        public static void DisposeNotifyIcon(object sender, EventArgs e)
        {
            try
            {
                notifyIcon.Icon = null;
                notifyIcon.Dispose();
            }
            catch { }
        }

        public static void DisposeNotifyIcon()
        {
            try
            {
                notifyIcon.Icon = null;
                notifyIcon.Dispose();
            }
            catch { }
        }

        public static void ShowErrorMessageForConection()
        {
            notifyIcon.ShowBalloonTip(1000, "Oh oh, algo salió mal.", "Revisa tu conexión a la base de datos", ToolTipIcon.Error);
        }

        public static void ShowErrorMessageForException(Exception exception)
        {
            notifyIcon.ShowBalloonTip(1000, "Oh oh, algo salió mal.", exception.Message, ToolTipIcon.Error);
        }

        public static void ShowWarningMessage(string title, string message)
        {
            notifyIcon.ShowBalloonTip(1000, "Oh oh, algo salió mal.", message, ToolTipIcon.Warning);
        }

        public static void ShowWarningMessage(string message)
        {
            notifyIcon.ShowBalloonTip(1000, "Oh oh, algo salió mal.", message, ToolTipIcon.Warning);
        }

        public static void ShowErrorMessage(string title, string message)
        {
            notifyIcon.ShowBalloonTip(1000, title, message, ToolTipIcon.Error);
        }

        public static void ShowErrorMessage(string message)
        {
            notifyIcon.ShowBalloonTip(1000, "Oh oh, algo salió mal.", message, ToolTipIcon.Error);
        }

        public static void ShowSucessMessage(string title, string subtitle)
        {
            notifyIcon.ShowBalloonTip(1000, title, subtitle, ToolTipIcon.Info);
        }
    }
}
