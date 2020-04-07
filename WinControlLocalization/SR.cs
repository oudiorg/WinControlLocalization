using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WinControlLocalization
{
    public sealed class SR
    {
        private static SR loader;
        private ResourceManager resources;
        public const string ControlTextLocalization = "TextLocalization";


        public SR()
        {
            resources = new ResourceManager("WinControlLocalization.Properties.Resources", typeof(SR).Assembly);
        }

        private static SR GetLoader()
        {
            if (SR.loader == null) SR.loader = new SR();
            return SR.loader;
        }

        public static ResourceManager Resources
        {
            get
            {
                return SR.GetLoader().resources;
            }
        }

        public static string GetString(string name)
        {
            var culture=System.Globalization.CultureInfo.GetCultureInfo("zh-CN");
            System.Diagnostics.Debug.WriteLine(string.Format("CultureName {0} {1}={2}", culture.Name, name, SR.Resources.GetString(name, culture)));
            culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            System.Diagnostics.Debug.WriteLine(string.Format("CultureName {0} {1}={2}", culture.Name, name, SR.Resources.GetString(name, culture)));
            return SR.Resources.GetString(name, System.Threading.Thread.CurrentThread.CurrentCulture);
        }
    }
}
