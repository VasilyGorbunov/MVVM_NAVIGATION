using MVVM_NAVIGATION.Stores;
using MVVM_NAVIGATION.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MVVM_NAVIGATION
{
    
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);

            MainWindow = new MainWindow() 
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
