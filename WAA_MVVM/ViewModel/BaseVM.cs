using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WAA_MVVM.ViewModel
{
    public class BaseVM : ViewModelBase
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
