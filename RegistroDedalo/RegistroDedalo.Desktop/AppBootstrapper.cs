using RegistroDedalo.Desktop.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace RegistroDedalo.Desktop
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<LoginViewModel>();
        }
    }
}
