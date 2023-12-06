using MVVM_NAVIGATION.Commands;
using MVVM_NAVIGATION.Stores;
using System.Windows.Input;

namespace MVVM_NAVIGATION.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateAccountCommand(navigationStore);
        }
    }
}
