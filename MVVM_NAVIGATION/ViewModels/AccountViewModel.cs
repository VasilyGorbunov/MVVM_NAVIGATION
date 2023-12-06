using MVVM_NAVIGATION.Commands;
using MVVM_NAVIGATION.Stores;
using System.Windows.Input;

namespace MVVM_NAVIGATION.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        public string Name => "VasilyGorbunov";

        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
        }
    }
}
