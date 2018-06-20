using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DLToolkit.Forms.Controls;
using WAA_MVVM.Model;
using WAA_MVVM.Services;
using WAA_MVVM.Services.Navigation;
using WAA_MVVM.View;
using Xamarin.Forms;

namespace WAA_MVVM.ViewModel
{
    public class HomeViewModel : BaseVM
    {
        MenuService service;
        public FlowObservableCollection<MenuModel> ItensMenu { get; set; }
        INavigationService _serviceNavigation;
        public HomeViewModel(INavigationService serviceNavigation)
        {
            ItensMenu = new FlowObservableCollection<MenuModel>();
            service = new MenuService();
            _serviceNavigation = serviceNavigation;
            CarregarMenu();
        }


        public void CarregarMenu()
        {
           var collection = service.GetItensMenu();
            foreach (var item in collection)
            {
              ItensMenu.Add(item);
            }
        }

        public ICommand ItemSelectedCommand
        {
            get
            {
                return new Command(async (value) =>
                {
                    MenuModel item = value as MenuModel;
                    await  _serviceNavigation.NavigateToAsync<DetalhesViewModel>(item);
                });
            }
        }

    }
}
