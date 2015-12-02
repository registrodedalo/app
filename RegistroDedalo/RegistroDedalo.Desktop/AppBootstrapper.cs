using RegistroDedalo.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Windows;
using RegistroDedalo.Desktop.Views;

namespace RegistroDedalo.Desktop
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            base.Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.DisplayRootViewFor<LoginViewModel>();
        }
    }
}
