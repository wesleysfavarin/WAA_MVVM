using System;
using System.Threading.Tasks;
using WAA_MVVM.Model;
using WAA_MVVM.Services;
using WAA_MVVM.Services.Navigation;

namespace WAA_MVVM.ViewModel
{
    public class DetalhesViewModel : BaseVM
    {
        DetalhesService _detalhesService;
        INavigationService _serviceNavigation;
        public DetalhesViewModel(INavigationService serviceNavigation)
        {
            _detalhesService = new DetalhesService();
            _serviceNavigation = serviceNavigation;
        }


        public override Task InitializeAsync(object navigationData)
        {
            if (navigationData is MenuModel)
            {
                var detalhe = _detalhesService.GetDetalhes(((MenuModel)navigationData).Id);
                this.Nome = detalhe.Nome;
                this.Cidade = detalhe.Cidade;
                this.Estado = detalhe.Estado;

            }
            return base.InitializeAsync(navigationData);
        }


       
        private string nome = string.Empty;
        public string Nome { get { return nome; } set { this.Set("Nome", ref nome, value); } }

       
        private string cidade = string.Empty;
        public string Cidade { get { return cidade; } set { this.Set("Cidade", ref cidade, value); } }
       
       
        private string estado = string.Empty;
        public string Estado { get { return estado; } set { this.Set("Estado", ref estado, value); } }


    }


}
