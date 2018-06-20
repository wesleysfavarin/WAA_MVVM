using System;
using System.Threading.Tasks;
using WAA_MVVM.ViewModel;

namespace WAA_MVVM.Services.Navigation
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : BaseVM;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseVM;

        Task NavigateToAsync(Type viewModelType);
    }
}
