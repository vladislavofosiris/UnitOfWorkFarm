using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFarmRepository
    {
        void Add(FarmEntity farmEntity);
        void Delete(FarmEntity farmEntity);
        IEnumerable<FarmEntity> GetAll();
        FarmEntity GetById(int id);
    }

    public class FarmRepository : IFarmRepository
    {

        private FarmContext _db;

        public FarmRepository(FarmContext context)
        {
            _db = context;
        }

        public void Add(FarmEntity farmEntity)
        {

            _db.FarmEntities.Add(farmEntity);

        }


        public void Delete(FarmEntity farmEntity)
        {
            _db.FarmEntities.Remove(farmEntity);
        }


        public FarmEntity GetById(int id)
        {
            return _db.FarmEntities.Find(id);
        }

        public IEnumerable<FarmEntity> GetAll()
        {
            return _db.FarmEntities;
        }
        public void Update(FarmEntity farmEntity)
        {
            _db.FarmEntities.Attach(GetById(farmEntity.Id));
        }


    }
}
