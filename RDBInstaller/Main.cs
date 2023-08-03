using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RDBInstaller
{
    [RunInstaller(true)]
    public class Main: Installer
    {
        public Main(): base()
        {
            this.AfterInstall += SetAppEnviroment;
        }

        private void SetAppEnviroment(object sender, InstallEventArgs args)
        {
            Environment.SetEnvironmentVariable("PATH", String.Format("{0};{1}", 
                Environment.GetEnvironmentVariable("PATH"), args.SavedState["TARGETDIR"]));
        }
    }
}
