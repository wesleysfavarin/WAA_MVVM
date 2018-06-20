using System;
using System.Threading.Tasks;
using WAA_MVVM.Model;
using Xamarin.Forms.Internals;

namespace WAA_MVVM.Services
{
    public class LoginService
    {
        public  async Task<bool> Logar(LoginModel model)
        {

            bool result = false;
            try
            {
                result = true;

            }

            catch (Exception ex)
            {
                Log.Warning("Erro", ex.Message);
            }

            return result;
        }

    }
}
