using System;
using System.Collections.Generic;
using System.Linq;
using WAA_MVVM.Data;
using WAA_MVVM.Model;

namespace WAA_MVVM.Services
{
    public class DetalhesService
    {
        DetalhesData _db;
        public DetalhesModel GetDetalhes(int idmenu)
        {
            DetalhesModel result = new DetalhesModel();
            _db = new DetalhesData();
            if(_db.GetAll().Count() > 0)
            {
                result = _db.GetById(idmenu);
            }
            else
            {
                //carga apenas para teste e demonstracao
                var collection = new List<DetalhesModel>
                   {
                    new DetalhesModel { Cidade = "Sao paulo",  Estado = "SP", MenuId=1 , Nome= "Alexandre" },
                    new DetalhesModel { Cidade = "Campinas",   Estado = "SP", MenuId=2 , Nome= "Wesley S. Favarin" },
                    new DetalhesModel { Cidade = "Barueri",    Estado = "SP", MenuId=3 , Nome= "KCAIO" },
                    new DetalhesModel { Cidade = "Ribeirao Preto", Estado = "SP", MenuId=4 , Nome= "Anderson"},
                    new DetalhesModel { Cidade = "Osasco",  Estado = "SP", MenuId=5 , Nome= "Paula" },
                    new DetalhesModel { Cidade = "Votuporanga",  Estado = "SP", MenuId=6 , Nome= "Manuela" },
                    new DetalhesModel { Cidade = "Sumare", Estado = "SP", MenuId=7 , Nome= "Marta"},
                    new DetalhesModel { Cidade = "Mirassol", Estado = "SP", MenuId=8 , Nome= "bruno moraes" },
                    new DetalhesModel { Cidade = "Guapiacu",  Estado = "SP", MenuId=9 , Nome= "jose dirceu" },
                    new DetalhesModel { Cidade = "Monte mor",  Estado = "SP", MenuId=10 , Nome= "Pedro silva" }
                   };

                foreach (var item in collection)
                {
                    _db.Save(item);
                }

            }
            return result;

        }
    }
}
