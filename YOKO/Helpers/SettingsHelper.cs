using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Helpers
{
    public class SettingsHelper
    {
        public decimal iva = 8.0m;
        public bool isIVAActive = false;

        public float dolar = 20.0f;
        public bool showDolarUpdates = true;
        public bool updateDolarValue = true;

        private static SettingsHelper settingsHelperInstance;

        private SettingsHelper()
        {
            GetStoredInformation();
        }

        public static SettingsHelper getInstance()
        {
            if (settingsHelperInstance == null)
            {
                settingsHelperInstance = new SettingsHelper();
            }

            return settingsHelperInstance;
        }

        private void GetStoredInformation()
        {
            iva = Properties.Settings.Default.iva;
            isIVAActive = Properties.Settings.Default.includeIVA;

            dolar = Properties.Settings.Default.Dolar;
            showDolarUpdates = Properties.Settings.Default.ShowDolar;
            updateDolarValue = Properties.Settings.Default.CheckDolar;
        }

        public void SetIVA(decimal newIVA)
        {
            Properties.Settings.Default.iva = newIVA;
            Properties.Settings.Default.Save();
            iva = newIVA;
        }

        public void SetIsIvaActive(bool isActive)
        {
            Properties.Settings.Default.includeIVA = isActive;
            Properties.Settings.Default.Save();
            isIVAActive = isActive;
        }

        public void SetDolar(float newDolar)
        {
            Properties.Settings.Default.Dolar = newDolar;
            Properties.Settings.Default.Save();
            dolar = newDolar;
        }

        public void SetShouldShowDolar(bool shouldShow)
        {
            Properties.Settings.Default.ShowDolar = shouldShow;
            Properties.Settings.Default.Save();
            showDolarUpdates = shouldShow;
        }

        public void SetShouldCheckDolarUpdates(bool shouldCheck)
        {
            Properties.Settings.Default.CheckDolar = shouldCheck;
            Properties.Settings.Default.Save();
            updateDolarValue = shouldCheck;
        }

        public decimal GetIVA()
        {
            return iva;
        }

        public bool IsIvaActive()
        {
            return isIVAActive;
        }

        public float GetDolar()
        {
            return dolar;
        }

        public bool ShouldShowDolar()
        {
            return showDolarUpdates;
        }

        public bool ShouldCheckDolarUpdates()
        {
            return updateDolarValue;
        }
    }
}
