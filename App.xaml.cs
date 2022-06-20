using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Demo_Omen
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow Window = new MainWindow();
            Demo_Omen.ViewModel.OmenViewModel Vm = new Demo_Omen.ViewModel.OmenViewModel();
            Window.DataContext = Vm;
            Window.Show();
        }
    }
}
