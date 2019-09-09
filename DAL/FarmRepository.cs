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

        private FarmStorage _farmStorage;

        public FarmRepository(FarmStorage farmStorage)
        {
            _farmStorage = farmStorage;
        }

        public void Add(FarmEntity farmEntity)
        {

            _farmStorage.AddFarm(farmEntity);

        }


        public void Delete(FarmEntity farmEntity)
        {
            _farmStorage.DeleteFarm(farmEntity.Id);

        }


        public FarmEntity GetById(int id)
        {
            return _farmStorage.GetFarmById(id);
        }

        public IEnumerable<FarmEntity> GetAll()
        {
            return _farmStorage.GetAllFarms();
        }


    }
}
