using System;
using WAA_MVVM.Model;
using SQLite;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WAA_MVVM.Data
{
    public class DetalhesData : BaseData<DetalhesModel>
    {

        public override int Delete(DetalhesModel entity)
        {
            return this.db.Delete(entity);
        }

        public override List<DetalhesModel> GetAll()
        {
            return new List<DetalhesModel>(db.Table<DetalhesModel>());
        }

        public override DetalhesModel GetById(int id)
        {
            return db.Table<DetalhesModel>().FirstOrDefault(c => c.MenuId == id);
        }

        public override int Save(DetalhesModel entity)
        {
            return db.Insert(entity);
        }

        public override int Update(DetalhesModel entity)
        {
            return db.Update(entity);
        }

        public override void Dispose()
        {
            db.Dispose();
        }

        public void DeleteAll()
        {
            db.DeleteAll<DetalhesModel>();
        }

    }
}
