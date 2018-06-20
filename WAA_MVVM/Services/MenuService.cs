using System;
using System.Collections.Generic;
using WAA_MVVM.Model;

namespace WAA_MVVM.Services
{
    public class MenuService
    {
       

        public List<MenuModel> GetItensMenu()
        {
            
            return new List<MenuModel>
            {
                new MenuModel { Id=1, Descricao = "Meus Cartoes" },
                new MenuModel { Id=2, Descricao = "Pedir Cartao" },
                new MenuModel { Id=3, Descricao = "Vincular Cartao" },
                new MenuModel { Id=4, Descricao = "Consular" },
                new MenuModel { Id=5, Descricao = "Tarifas limites" },
                new MenuModel { Id=6, Descricao = "DNotificacoes" },
                new MenuModel { Id=7, Descricao = "Meu cadastro" },
                new MenuModel { Id=8, Descricao = "Atendimento" },
                new MenuModel { Id=9, Descricao = "Alterar senha" },
                new MenuModel { Id=10, Descricao = "Acesso" },
            };
            
        }
    }
}
