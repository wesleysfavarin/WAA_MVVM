using System;
using WAA_MVVM.ViewModel;

namespace WAA_MVVM.Model
{
    public class LoginModel : BaseVM
    {
        public int Id
        {
            get;
            set;
        }

       public string Usuario
        {
            get;
            set;
        }

        public string Senha
        {
            get;
            set;
        }
    }
}
